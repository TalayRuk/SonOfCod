using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SonOfCod.Controllers
{
    public class PromoPageController : Controller
    {
        private AdminDbContext _db;

        public PromoPageController(AdminDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_db.Promotions.ToList());
        }
    }
}
