using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab1ConsoleApp2020
{
    class Product
    {
        [Key]
        public int ProductID { get; set; }
        public DateTime DateFirstIssued { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public int QuantityInStock { get; set; }

        [ForeignKey("category")]
        public int CategoryID { get; set; }

        public virtual  Category category { get; set; }
    }
}
