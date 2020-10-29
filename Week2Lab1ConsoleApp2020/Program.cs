using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab1ConsoleApp2020
{
    class Program
    {
        static void Main(string[] args)
        {

            ActivityTracker.Activity.Track("Lab Finished");
            list_Categories();
            list_Products();
            list_Products(180);
            list_Product_value();
            list_Category_products("Hardware");
            list_Suppliers();
            //list_Supplier_parts();
            addSupplier();
            list_Suppliers();
            

        }

        public static void list_Categories()
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Category> Query = db.Catergories.ToList();

                Console.WriteLine("Query Category List");
                foreach (var item in Query)
                {
                    Console.WriteLine("{0} {1}", item.CategoryID, item.Description);
                }
                Console.ReadLine();
            }
        }

        public static void list_Products()
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Product> Query = db.Products.ToList();

                Console.WriteLine("Query Product List");
                foreach (var item in Query)
                {
                    Console.WriteLine("{0} {1}", item.ProductID, item.Description);

                }
                Console.WriteLine("");
                Console.ReadLine();
            }
        }

        public static void list_Products(int UpperLimit)
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Product> Query = db.Products.ToList();

                Console.WriteLine("Query Product Quantity List");
                foreach (var item in Query.Where(n => n.QuantityInStock <= UpperLimit))
                {

                    Console.WriteLine("{0} {1} {2}", item.ProductID, item.Description, item.QuantityInStock);
                    
                }
                Console.WriteLine("");
                Console.ReadKey();
            }
        }

        public static void list_Product_value()
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Product> Query = db.Products.ToList();
                float total;

                Console.WriteLine("Query Product Value List");
                foreach (var item in Query)
                {
                    total = item.UnitPrice * item.QuantityInStock;
                    Console.WriteLine("{0} {1} {2} {3} {4}", item.ProductID, item.Description, item.UnitPrice, item.QuantityInStock, total);

                }
                Console.WriteLine("");
                Console.ReadKey();
            }
        }

        public static void list_Category_products(string Category)
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Product> Query = db.Products.ToList();

                Console.WriteLine("Query Product catergory List");

                switch (Category)
                {
                    case "Hardware":
                        foreach (var item in Query.Where(n => n.CategoryID == 1))
                        {
                            Console.WriteLine("{0} {1}", item.ProductID, item.Description);
                        }
                        break;
                    case "Electrical Appliances":
                        foreach (var item in Query.Where(n => n.CategoryID == 2))
                        {
                            Console.WriteLine("{0} {1}", item.ProductID, item.Description);
                        }
                        break;
                }

                Console.WriteLine("");
                Console.ReadKey();
            }
        }

        public static void list_Supplier_parts()
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Supplier> Query = db.Suppliers.ToList();
                List<Product> Query2 = db.Products.ToList();

                Console.WriteLine("Query Supplier & parts List");
                foreach (var item in Query)
                {

                    Console.WriteLine("{0} {1}", item.SupplierID, item.SupplierName);

                }
                Console.WriteLine("");
                Console.ReadKey();
            }
        }

        public static void list_Suppliers()
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Supplier> Query = db.Suppliers.ToList();

                Console.WriteLine("Query Supplier List");
                foreach (var item in Query)
                {

                    Console.WriteLine("{0} {1}", item.SupplierID, item.SupplierName);

                }
                Console.WriteLine("");
                Console.ReadKey();
            }
        }

        public static void addSupplier()
        {
            using (DbBusinessContext db = new DbBusinessContext())
            {
                List<Supplier> Query = db.Suppliers.ToList();

                Console.WriteLine("Query add Supplier");

                Console.WriteLine("Enter Supplier ID");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                Console.WriteLine("Enter Supplier Name");
                string name = Console.ReadLine();
                Console.WriteLine("");


                Console.WriteLine("Enter Supplier Address1");
                string Address1 = Console.ReadLine();
                Console.WriteLine("");


                Console.WriteLine("Enter Supplier Address2");
                string Address2 = Console.ReadLine();
                Console.WriteLine("");

                Supplier s = new Supplier { SupplierID = id, SupplierName = name, SupplierAddressLine1 = Address1, SupplierAddressLine2 = Address2 };
                
                db.Suppliers.Add(s);
                db.SaveChanges();
                Console.WriteLine("");
                Console.ReadKey();
            }
        }
    }
}
