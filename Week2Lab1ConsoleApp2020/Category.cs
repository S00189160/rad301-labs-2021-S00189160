﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab1ConsoleApp2020
{
    class Category
    {

        [Key]
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public override string ToString()
        {
            return string.Concat("CategoryID:", CategoryID.ToString(), " Description: ", Description);
        }

    }
}
