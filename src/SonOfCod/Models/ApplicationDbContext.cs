using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCod.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> 
    {
        public ApplicationDbContext(DbContextOptions options) :base(options)
    }
}

//next setup database in appsettings.json, next configure the application to use Identity w/Entity Framework & MVC in Startup.cs