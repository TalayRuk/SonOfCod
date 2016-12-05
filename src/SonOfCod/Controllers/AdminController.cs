using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;
using SonOfCod.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        private readonly AdminDbContext _db;
        private readonly UserManager<AdminUser> _userManager;
        private readonly SignInManager<AdminUser> _signInManager;

        public AdminController (UserManager<AdminUser> userManger, SignInManager<AdminUser> signInManager, AdminDbContext db)
        {
            _userManager = userManger;
            _signInManager = signInManager;
            _db = db;

        }
        public IActionResult Index()
        {
            return View();
        }
        // next add view/account/index

        //create register view
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var user = new AdminUser { UserName = model.Email };
            IdentityResult result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }

        //create Log in
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            //model at the login view
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: true, lockoutOnFailure: false);
            //SigninAsync method to sign a user in w/their credentials. 
            //isPersistent set to true mean if not log out, it'll stay log in even if the browser is closed
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Error");
            }
        }
        //Add code let the user successfully logs in to Index page

        //Add error page
        public IActionResult Error()
        {
            return View();
        }
        //Create Error view Page 

        //Create Log off action (doesn't need it's own view)
        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            //SignInManager has the asynchronouse method SignOutAsync() 
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        //next update Index to show log out btn

        public IActionResult MailingList()
        {
            return View(_db.Subscribers.ToList());
        }
        
        //[Authorize]
        public IActionResult Marketing()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Marketing(Promotion promotion)
        {
            //var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            //var currentUser = await _userManager.FindByIdAsync(userId);
            //promotion.User = currentUser;
            _db.Promotions.Add(promotion);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditMarketing(int id)
        {
            var thisPromo = db.Promotions.FirstOrDefault(promos => promos.PromotionId == id);
            return View(thisPromo);
        }

        [HttpPost]
        public IActionResult EditMarketing(Promotion promotion)
        {
            _db.Entry(promotion).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Marketing");
        }



    }
}
