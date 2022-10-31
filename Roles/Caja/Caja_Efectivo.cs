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
    public partial class Caja_Efectivo : Form
    {
        
        public Caja_Efectivo(int numero)
        {
            InitializeComponent();
            DetailOrder(numero);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //Imprimir ticket o factura
            string urlFactura = "https://binarysystem.pythonanywhere.com/api/checking_invoice/";//para la factura
            MessageBox.Show("Gracias por su compra", "EFECTIVO");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async Task DetailOrder(int order)
        {
            string detailOrder = "https://binarysystem.pythonanywhere.com/api/detailOrder/?id="+order;
            HttpClient client = new HttpClient();
            var httpResponse = await client.GetAsync(detailOrder);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                var orden = JsonSerializer.Deserialize<Ordenes>(content);

                foreach (var item in orden.products)
                {
                    dgvDetallesPedidoIndividual.Rows.Add(item.product, item.quantity, item.price);
                }
            }
        }
        public class Ordenes
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
}
