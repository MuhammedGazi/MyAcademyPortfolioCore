using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class BannerController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var  values=context.Banners.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Banner banner)
        {
            context.Banners.Add(banner);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            var value=context.Banners.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(Banner banner)
        {
            context.Banners.Update(banner);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deletedvalue=context.Banners.Find(id);
            context.Banners.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
