using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class SkillsController(PortfolioContext _context) : Controller
    {
        public IActionResult Skills()
        {
            var skills=_context.Skills.ToList();
            return View(skills);
        }

        [HttpGet]
        public IActionResult createSkills()
        {
            return View();
        }
        [HttpPost]
        public IActionResult createSkills(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("Skills");
        }

    
        public IActionResult deleteSkill(int id)
        {
            var deletedValue=_context.Skills.Find(id);
            _context.Skills.Remove(deletedValue);
            _context.SaveChanges();
            return RedirectToAction("Skills");
        }

        [HttpGet]
        public IActionResult editSkill(int id)
        {
            var value= _context.Skills.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult editSkill(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("Skills");
        }


    }
}
