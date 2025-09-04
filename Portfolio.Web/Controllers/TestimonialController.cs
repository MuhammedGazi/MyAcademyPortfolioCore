using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class TestimonialController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var values=context.Testimonials.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value=context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult Update(Testimonial testimonial)
        {
            context.Testimonials.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deletedvalue = context.Testimonials.Find(id);
            context.Testimonials.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
