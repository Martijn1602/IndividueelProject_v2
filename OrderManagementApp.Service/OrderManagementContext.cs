using Microsoft.EntityFrameworkCore;
using OrderManagementApp.Service.Models;
using System.Data.SqlClient;

namespace OrderManagementApp.Service
{
    public class OrderManagementContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=order_management.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
               new User { UserId = 1, Username = "Admin", Password = "Admin", Role="Admin" },
               new User { UserId = 2, Username = "Magazijnier", Password = "Magazijnier", Role = "Warehouse" },
               new User { UserId = 3, Username = "Verkoper", Password = "Verkoper", Role = "Sales" }
           );
        }
    }
}
