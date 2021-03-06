﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;
using SonOfCod.ViewModels;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult Register()
        {
            return View();
        }
        // next add view/admin/index

        //create register view

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

        [Authorize]
        public IActionResult MailingList()
        {
            return View(_db.Subscribers.ToList());
        }
        
        [Authorize]
        public IActionResult Marketing()
        {
            //using async task<This will return only the promotion that the current log-in AdminUser has added the promotion but will not see all the promotions other login AdminUsers have added! 
            //var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            //var currentUser = await _userManager.FindByIdAsync(userId);
            //return View(_db.Promotions.Where(x => x.User.Id == currentUser.Id));

            //This type of return let all Loged in Admin to view all the promotion any login Admin has added 
            return View(_db.Promotions.ToList());
        }

        [Authorize]
        public IActionResult CreateMarketing()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMarketing(Promotion promotion)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            promotion.User = currentUser;
            _db.Promotions.Add(promotion);
            _db.SaveChanges();
            return RedirectToAction("Marketing");
        }

        [Authorize] 
        public IActionResult EditMarketing(int id)
        {
            var thisPromo = _db.Promotions.FirstOrDefault(promos => promos.Id == id);
            return View(thisPromo);
        }

        [HttpPost]
        public IActionResult EditMarketing(Promotion promotion)
        {
            _db.Entry(promotion).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Marketing");
        }

        [Authorize]
        public IActionResult DeleteMarketing(int id)
        {
            var thisPromo = _db.Promotions.FirstOrDefault(promos => promos.Id == id);
            return View(thisPromo);
        }

        [HttpPost, ActionName("DeleteMarketing")]
        public IActionResult DeleteMarketingConfirmed(int id)
        {
            var thisPromo = _db.Promotions.FirstOrDefault(promos => promos.Id == id);
            _db.Promotions.Remove(thisPromo);
            _db.SaveChanges();
            return RedirectToAction("Marketing");
        }



    }
}
