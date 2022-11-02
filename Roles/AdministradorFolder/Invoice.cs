using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Roles.AdministradorFolder
{
    public class Invoice
    {
        public int number_invoice { get; set; }
        public string date { get; set; }
        public Order order { get; set; }
        public string method_pay { get; set; }
        public double totalPrice { get; set; }

        public int getLengthOrderProducts() { return order.products.Count; }
        

    }
public class Order
{
    public int id { get; set; }
    public int table { get; set; }
    public List<Products> products { get; set; }
}
public class Products
{
    public string product { get; set; }
    public int quantity { get; set; }
    public double price { get; set; }
}
}
