using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;
using Portfolio.Web.Models;

namespace Portfolio.Web.Controllers
{
    public class ProfilController(PortfolioContext _context) : Controller
    {

        [HttpGet] 
        public IActionResult ProfilDetails()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProfilDetails(ProfileEdirtModel model)
        {
            var userDb = _context.Users.FirstOrDefault();
            userDb.UserName = model.UserName;

            if (!string.IsNullOrEmpty(model.NewPassword))
            {
                if (userDb.Password == model.CurrentPassword)
                {
                    userDb.Password = model.NewPassword;
                }
                else
                {
                    return RedirectToAction("ProfilDetails");
                }
            }
            _context.SaveChanges();
            return RedirectToAction("ProfilDetails");
        }
    }
}
