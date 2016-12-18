using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace LibraryBars.Models
{
    class AppDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var roleLibrarian = new IdentityRole { Name = "Librarian" };
            var roleCustomer = new IdentityRole { Name = "Customer" };

            roleManager.Create(roleLibrarian);
            roleManager.Create(roleCustomer);

            string password = "usere2322fFF+";
            var librarian = new ApplicationUser { Email = "librarian@gmail.com", UserName = "librarian@gmail.com" };
            var result = userManager.Create(librarian, password);

            if (result.Succeeded)
            {
                userManager.AddToRole(librarian.Id, roleLibrarian.Name);
            }

            base.Seed(context);
        }
    }
}
