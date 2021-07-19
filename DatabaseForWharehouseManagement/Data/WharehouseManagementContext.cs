using DatabaseForWharehouseManagement.Entities;
using DatabaseForWharehouseManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseForWharehouseManagement.Data
{
    public class WharehouseManagementContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderedProducts> OrderedProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB");
        }
    }
}
