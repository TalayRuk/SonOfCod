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
    public class SubscriptionsController : Controller
    {
        // GET: /<controller>/
        private AdminDbContext _db;

        public SubscriptionsController (AdminDbContext db)
        {
            _db = db;
        }

        //Anyone can view Subscriptions page ***Note: views Page folder need to have the exact same name as controller
        //Subscriptions index page didn't work before b/c Controller name: Subscriptions but the Views folder: Subscription !!missing "s"!
        
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(Subscriber subscriber)
        {
            _db.Subscribers.Add(subscriber);
            _db.SaveChanges();
            return RedirectToAction("Thanks");
        }

        public IActionResult Thanks()
        {
            return View();
        }
    }
}
