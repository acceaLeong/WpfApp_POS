using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPOS1.Models
{
    public class MyDbContext : DbContext
    {
        // create dbset
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        //public readonly string _path = @"C:\Users\kl_sys001\Desktop\ZTest\WPF-POS-System-master\WPF-POS-System-master\WpfAppPOS1\DB\MyDatabase5.1.db";
        public readonly string _path = @"DB\MyDatabase5.1.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string currentDir = Path.GetFullPath(@"..\..\..\");
            string absoluteDir = Path.Combine(currentDir, _path);

            //optionsBuilder.UseSqlite($"Data Source={_path}");
            optionsBuilder.UseSqlite($"Data Source={absoluteDir}");  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // create default admin user
            var adminUser = new User
            {
                Username = "admin",
                IsAdmin = true,
                FirstName = "Default",
                LastName = "Admin",
                Phone = 123456789
            };
            adminUser.GeneratePasswordHash("password");
            modelBuilder.Entity<User>().HasData(adminUser);
        }
    }
}
