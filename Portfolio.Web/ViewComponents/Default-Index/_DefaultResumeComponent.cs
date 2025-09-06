using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Context;
using Portfolio.Web.Models;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultResumeComponent(PortfolioContext context):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var aboutData = context.Abouts.FirstOrDefault();
            var educationsData = context.Educations.OrderByDescending(e => e.StartYear).ToList();
            var experiencesData = context.Experiences.OrderByDescending(x => x.StartYear).ToList();
            var viewModel = new ResumeViewModel
            {
                AboutInfo = aboutData,
                Educations = educationsData,
                Experiences = experiencesData
            };

            return View(viewModel);
        }
    }
}
