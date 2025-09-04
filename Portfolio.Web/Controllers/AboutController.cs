using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class AboutController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var abouts=context.Abouts.ToList();
            return View(abouts);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(About about)
        {
            if (about == null)
            {
                return View(about);
            }
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var about=context.Abouts.Find(id);
            return View(about);
        }
        [HttpPost]
        public IActionResult EditAbout(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAbout(int id)
        {
            var deletedvalue=context.Abouts.Find(id);
            context.Abouts.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult IsAvailable(int id)
        {
            var value=context.Abouts.Find(id);
            value.IsAvailable = !value.IsAvailable;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
