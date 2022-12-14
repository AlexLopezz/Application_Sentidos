using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Roles.Chef
{
    public class MenuGet
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Products> products { get; set; }
    }
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string img { get; set; }
    }   
    public class ProductsGET
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string img { get; set; }
        public List<Categories> category { get; set; }
    }
    public class ProductPOST
    {
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string img { get; set; }
        public List<int> category { get; set; }
    }
    public class ProductPUT
    {
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public List<int> category { get; set; }
    }
}
