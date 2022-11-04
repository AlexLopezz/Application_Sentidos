using Application_Sentidos.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Sentidos.Roles
{
    public partial class Facturas : Form
    {
        double totalFactura = 0;
        public Facturas(int numero)
        {
            InitializeComponent();
            txtBoxNumeroMeza.Text = numero.ToString();
        }
        public async Task DetailOrder(int order)
        {
            string detailOrder = "https://binarysystem.pythonanywhere.com/api/detailOrder/?id=" + order;
            HttpClient client = new HttpClient();
            var httpResponse = await client.GetAsync(detailOrder);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                var orden = JsonSerializer.Deserialize<Ordenes>(content);

                foreach (var item in orden.products)
                {
                    dgvDetallesFactura.Rows.Add(item.product, item.quantity, item.price);
                }
                foreach (var item in orden.products)
                {
                    totalFactura += item.price;
                }
            }
            txtBoxTotal.Text = "$" + totalFactura.ToString();
        }
        public class Ordenes
        {
            public int id { get; set; }
            public int table { get; set; }
            public List<Products> products { get; set; }
            public string? pay { get; set; }
        }
        public class Products
        {
            public string product { get; set; }
            public int quantity { get; set; }
            public double price { get; set; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
