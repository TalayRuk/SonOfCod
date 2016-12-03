using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController (UserManager<ApplicationUser> userManger, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManger;
            _signInManager = signInManager;
            _db = db;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
