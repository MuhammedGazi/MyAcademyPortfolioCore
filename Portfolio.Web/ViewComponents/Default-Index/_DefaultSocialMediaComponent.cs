using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultSocialMediaComponent(PortfolioContext _context):ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var socialvalue=_context.socialMedias.ToList();
            return View(socialvalue);
        }
    }
}
