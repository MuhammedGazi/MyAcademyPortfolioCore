using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
    public class StatisticsController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            ViewBag.projectCount = context.Projects.Count();
            ViewBag.skillAverage = context.Skills.Any()
                         ? context.Skills.Average(x => x.Percentage).ToString("00.00")
                         : 0.0.ToString("00.00");
            ViewBag.unreadMessageCount = context.UserMessages.Count(x => x.IsRead == false);
            ViewBag.lastMessageOwner = context.UserMessages.OrderByDescending(x => x.UserMessageId)
                .Select(x => x.Name).FirstOrDefault();
            var startyear = context.Experiences.Min(x => x.StartYear);
            ViewBag.experienceCount = DateTime.Now.Year - startyear;
            ViewBag.companyCount = context.Experiences.Select(x => x.Company).Distinct().Count();
            ViewBag.reviewAverage = context.Testimonials.Any()
                ? context.Testimonials.Average(x => x.Review).ToString("0.0")
                : "Henüz Değerlendirme Yapılmadı";
            ViewBag.reviewMax = context.Testimonials.OrderByDescending(x=>x.Review).Select(x => x.Name).FirstOrDefault();
            ViewBag.testiCount = context.Testimonials.Count();
            ViewBag.lastProject = context.Projects.OrderByDescending(x=>x.ProjectId).Select(x=>x.ProjectName).FirstOrDefault();
            ViewBag.readMessage=context.UserMessages.Count(x=>x.IsRead==true);
            ViewBag.mostCategory=context.Projects
                .GroupBy(x=>x.CategoryId)
                .OrderByDescending(y=>y.Count())
                .Select(z=>z.Key)
                .FirstOrDefault();
            return View();
        }
    }
}