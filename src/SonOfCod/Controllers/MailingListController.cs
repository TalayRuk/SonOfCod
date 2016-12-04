using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    [Authorize]
    public class MailingListController : Controller
    {
        // GET: /<controller>/
        private readonly AdminDbContext _db;
        private readonly UserManager<AdminUser> _userManager;

        public MailingListController (UserManager<AdminUser> userManager, AdminDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        //only Authorized admin can view index
        public IActionResult Index()
        {
            return View(db.Subscribers.ToList());
        }

        //Anyone can view Subscription page ***AllowAnonymous will override any Authorize cmd so Don't put it at Controller level
        [AllowAnonymous]
        public IActionResult Subscribe()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Subscribe(Subscriber subscriber)
        {
            _db.Subscribers.Add(subscriber);
            _db.SaveChanges();
            return RedirectToAction("Thanks");
        }
    }
}
