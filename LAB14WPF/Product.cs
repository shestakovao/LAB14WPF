using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB14WPF
{
    public enum ProductCategorys
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }    
        public string ProductImage { get; set; }
        public ProductCategorys ProductCategory { get; set; }
    }
}
