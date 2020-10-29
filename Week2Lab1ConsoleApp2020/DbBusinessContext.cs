using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab1ConsoleApp2020
{
    class DbBusinessContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Catergories { get; set; }
        public DbSet<SupplierProduct> SupplierProducts { get; set; }
        public DbBusinessContext() : base("ProductDbConnection")
        {

        }

    }
}
