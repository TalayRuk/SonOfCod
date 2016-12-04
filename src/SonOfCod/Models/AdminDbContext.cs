using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCod.Models
{
    public class AdminDbContext   : IdentityDbContext<AdminUser> 
    {
        public AdminDbContext(DbContextOptions options)   :base(options)
        {
            //need to have this open constructor part to not have error 
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Subscriber> Subscribers { get; set; }
    }
}

//next setup database in appsettings.json, next configure the application to use Identity w/Entity Framework & MVC in Startup.cs