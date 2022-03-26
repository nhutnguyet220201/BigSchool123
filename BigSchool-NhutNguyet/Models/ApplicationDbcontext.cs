using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BigSchool_NhutNguyet.Models
{
    public class ApplicationDbcontext:IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbcontext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbcontext Create()
        {
            return new ApplicationDbcontext();
        }
    }
}