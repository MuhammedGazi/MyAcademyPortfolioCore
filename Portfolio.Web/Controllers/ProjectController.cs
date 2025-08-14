using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class ProjectController(PortfolioContext context) : Controller
    {
        private void CategoryDropdown()
        {
            var categories = context.Categories.ToList();
            ViewBag.categories = (from x in categories
                                  select new SelectListItem
                                  {
                                      Text = x.CategoryName,
                                      Value = x.CategoryId.ToString()
                                  }).ToList();
        }
        public IActionResult Index()
        {
            //Eager Loading
            var projects=context.Projects.Include(x=>x.Category).ToList();
            return View(projects);
        }

        [HttpGet]
        public IActionResult CreateProject()
        {
            CategoryDropdown();
            return View();
        }

        [HttpPost]
        public IActionResult CreateProject(Project model)
        {
            CategoryDropdown();
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            context.Projects.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
