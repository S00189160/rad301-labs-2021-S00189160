namespace Week2Lab1ConsoleApp2020.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Week2Lab1ConsoleApp2020.DbBusinessContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Week2Lab1ConsoleApp2020.DbBusinessContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Suppliers.AddOrUpdate(new Supplier[]
            {
                new Supplier{ SupplierID = 1, SupplierName="Joe Bloggs", SupplierAddressLine1="The Coop", SupplierAddressLine2="Coopersville" },
                new Supplier{ SupplierID = 2, SupplierName="Mary Quant", SupplierAddressLine1="Priory Road", SupplierAddressLine2="Paris" }
            });
            context.SaveChanges();

            context.Catergories.AddOrUpdate(new Category[]
            {
                new Category{ CategoryID = 1, Description="Hardware"},
                new Category{ CategoryID = 2, Description="Electrical Appliances"}
            });
            context.SaveChanges();

            DateTime baseDate = DateTime.Parse("02/12/2019");
            Random r = new Random();

            context.Products.AddOrUpdate(new Product[]
            {
                new Product{ ProductID = 1, DateFirstIssued=baseDate.AddDays(r.Next(5, 15)), Description="9 inch nails", UnitPrice= .1F, QuantityInStock=200, CategoryID=1},
                new Product{ ProductID = 2, DateFirstIssued=baseDate.AddDays(r.Next(5, 15)), Description="9 inch bolts", UnitPrice= .2F, QuantityInStock=120, CategoryID=1},
                new Product{ ProductID = 3, DateFirstIssued=baseDate.AddDays(r.Next(5, 15)), Description="Chimney Hoover", UnitPrice= 100.5F, QuantityInStock=10, CategoryID=2},
                new Product{ ProductID = 4, DateFirstIssued=baseDate.AddDays(r.Next(5, 15)), Description="Washing Machine", UnitPrice= 399.99F, QuantityInStock=7, CategoryID=2}
            });
            context.SaveChanges();

            context.SupplierProducts.AddOrUpdate(new SupplierProduct[]
            {
                new SupplierProduct{ SupplierID = 1, ProductID = 1, DateFirstSupplied=baseDate.AddDays(r.Next(5, 15)) },
                new SupplierProduct{ SupplierID = 1, ProductID = 2, DateFirstSupplied=baseDate.AddDays(r.Next(5, 15)) },
                new SupplierProduct{ SupplierID = 2, ProductID = 3, DateFirstSupplied=baseDate.AddDays(r.Next(5, 15)) },
                new SupplierProduct{ SupplierID = 2, ProductID = 4, DateFirstSupplied=baseDate.AddDays(r.Next(5, 15)) }
            });
            context.SaveChanges();


        }
    }
}
