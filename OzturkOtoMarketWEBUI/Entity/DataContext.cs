using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OzturkOtoMarketWEBUI.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using OzturkOtoMarketWEBUI.identity;

namespace OzturkOtoMarketWEBUI.Entity
{
    public class DataContext: IdentityDbContext<ApplicationUser>
    {
        public DataContext() : base("dataConnection")
        {
            

        }


        public DbSet <Product> Products { get; set; }
        public DbSet <Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set;}
        public DbSet<CartLine> CartLines { get; set; }
        public DbSet<Login> Logins { get; set; }    
        public DbSet<Register> Register { get; set; }
     
        




    }
}