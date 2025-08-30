using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultStatsComponent(PortfolioContext _context):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.clients = _context.Testimonials.Count();
            ViewBag.experiences = _context.Experiences.Count();
            ViewBag.projects= _context.Projects.Count();
            ViewBag.userMessage= _context.UserMessages.Count();
            return View();
        }
    }
}
