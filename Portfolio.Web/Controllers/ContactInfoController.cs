using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class ContactInfoController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var value=context.ContactInfos.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ContactInfo contactInfo)
        {
            context.ContactInfos.Add(contactInfo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var value= context.ContactInfos.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(ContactInfo contactInfo)
        {
            context.ContactInfos.Update(contactInfo);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deletedvalue = context.ContactInfos.Find(id);
            context.ContactInfos.Remove(deletedvalue);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
