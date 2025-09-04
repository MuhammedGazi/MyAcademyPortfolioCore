using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class EducationController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Educations.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Education education)
        {
            context.Educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value=context.Educations.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Education education)
        {
            context.Educations.Update(education);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var value= context.Educations.Find(id);
            context.Educations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
