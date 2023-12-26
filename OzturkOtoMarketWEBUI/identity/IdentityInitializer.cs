using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OzturkOtoMarketWEBUI.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OzturkOtoMarketWEBUI.identity
{
    public class IdentityInitializer: CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            if(!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name= "admin", Description="admin rolü"};
                manager.Create(role);

            }


            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "user", Description = "user rolü" }; ;
                manager.Create(role);

            }

            if (!context.Users.Any(i => i.Name == "kristian"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Can", Surname = "Bektaş", UserName="kristian", Email="mahmutcr039@gmail.com"};
                manager.Create(user,"616161");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");

            }

            if (!context.Users.Any(i => i.Name == "kristian1"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser() { Name = "Furkan", Surname = "Bektaş", UserName = "kristian1", Email = "furkanbektas61@gmail.com" };
                manager.Create(user, "555555");
                manager.AddToRole(user.Id, "user");

            }




            base.Seed(context);
        }
    }
}