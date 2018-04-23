using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DxExample
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public BindingList<Product> Products { get; set; }
    }
}
