using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
    public class MessageController(PortfolioContext _context) : Controller
    {
        public IActionResult Index()
        {
            var messages=_context.UserMessages.ToList();
            return View(messages);
        }

        public IActionResult DetailMessage(int id)
        {
            var message = _context.UserMessages.FirstOrDefault(x => x.UserMessageId == id);
            if (!message.IsRead)
            {
                message.IsRead = true;
                _context.Update(message);
                _context.SaveChanges();
            }
            return PartialView("MessageDetail", message);
        }

        public IActionResult DeleteMessage(int id)
        {
            var deletedvalue = _context.UserMessages.Find(id);
            _context.UserMessages.Remove(deletedvalue);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
