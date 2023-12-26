using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using OzturkOtoMarketWEBUI.identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OzturkOtoMarketWEBUI.Entity
{
    public class DataInitializer: DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var Kategoriler = new List<Category>()
            {
                new Category() { Name ="Anakart", Description="Anakart Ürünleri"},
                new Category() { Name ="Ekran", Description="Ekran Ürünleri"}, 
                new Category() { Name ="Batarya ", Description="Batarya Ürünleri"},
                new Category() { Name ="Kamera", Description="Kamera Ürünleri"},
                new Category() { Name ="Arka Ekran", Description="Arka Ekran Ürünleri"},
                new Category() { Name ="Çip", Description="Çip Ürünleri"},
                new Category() { Name ="Apple Watch", Description="Apple Watch"}
               
            };

            foreach (var kategori in Kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() { Name ="İphone 11 anakart", Description = "Orijinal iphone 11 anakartı", Price =400, Stock = 10, IsApproved =true, CategoryId =1, Image="10.jpg" },
                new Product() { Name ="İphone 12", Description = "Orijinal iphone 12 anakartı", Price =300, Stock = 10, IsApproved =false, CategoryId =1,Image="20.png"},
                new Product() { Name ="İphone 13 anakart ", Description = "Orijinal iphone 13 anakartı", Price =450, Stock = 10, IsApproved =true, CategoryId =1,Image="reno.png"},

                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =700, Stock = 8, IsApproved =true, CategoryId =2,Image="40.jpg",},
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =600, Stock = 4, IsApproved =true, CategoryId =2,Image="50.jpg"},
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartış", Price =500, Stock = 3, IsApproved =true, CategoryId =2,Image="60.jpg"},

                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =300, Stock = 5, IsApproved =true, CategoryId =3,Image="70.jpg" },
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =350, Stock = 40, IsApproved =true, CategoryId =3,Image="80.jpg"},
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =400, Stock = 50, IsApproved =false, CategoryId =3,Image="90.jpg" },

                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =200, Stock = 10, IsApproved =true, CategoryId =4,Image="tofas.jpg" },
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =300, Stock = 10, IsApproved =true, CategoryId =4,Image="110.jpg" },
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =500, Stock = 10, IsApproved =true, CategoryId =4,Image="120.jpg" },

                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price= 200, Stock = 10, IsApproved =true, CategoryId =5,Image="aa.png" },
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =300, Stock = 10, IsApproved =true, CategoryId =5,Image="bb.jpg" },
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =800, Stock = 10, IsApproved =true, CategoryId =5,Image="cc.jpg" },

                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =400, Stock = 8, IsApproved =true, CategoryId =6,Image="130.jpg"},
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =30, Stock = 3, IsApproved =false, CategoryId =6,Image="140.jpg"},
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =600, Stock = 5, IsApproved =true, CategoryId =6,Image="150.jpg"},

                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =700, Stock = 10, IsApproved =true, CategoryId =7,Image="160.jpg" },
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =800, Stock = 30, IsApproved =true, CategoryId =7 ,Image="170.jpg" },
                new Product() { Name ="İphone 8 ekran", Description = "Orijinal iphone 13 anakartı", Price =900, Stock = 20, IsApproved =false, CategoryId =7, Image="180.jpg"}



            };

            foreach(var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();



            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);

                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
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

                var user = new ApplicationUser() { Name = "Can", Surname = "Bektaş", UserName = "kristian", Email = "mahmutcr039@gmail.com" };
                manager.Create(user, "616161");
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