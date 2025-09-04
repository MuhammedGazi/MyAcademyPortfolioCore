using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class ExperienceController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value=context.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deletedvalue=context.Experiences.Find(id);
            context.Experiences.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
