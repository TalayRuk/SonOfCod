using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;
using SonOfCod.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        private readonly AdminDbContext _db;
        private readonly UserManager<AdminUser> _userManager;
        private readonly SignInManager<AdminUser> _signInManager;

        public AccountController (UserManager<AdminUser> userManger, SignInManager<AdminUser> signInManager, AdminDbContext db)
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
                return View();
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
                return View();
            }
        }
        //Add code let the user successfully logs in to Index page

        //Create Log off action (doesn't need it's own view)
        [HttpPost]
        public async Task<IActionResult> LogOff()
        {
            //SignInManager has the asynchronouse method SignOutAsync() 
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
        //next update Index to show log out btn

    }
}
