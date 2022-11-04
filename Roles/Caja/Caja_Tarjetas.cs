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
    public partial class Caja_Tarjetas : Form
    {
        double totalFactura = 0;
        public int numeroOrden { get; set; }
        public int numeroMesa { get; set; }
        public Caja_Tarjetas(int numero)
        {
            numeroOrden = numero;
            numeroMesa = numero;
            InitializeComponent();
            DetailOrder(numero);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //Imprimir ticket o factura
            //metodo put => enviar id order + pay = true
            //para la factura
            //string urlFactura = "https://binarysystem.pythonanywhere.com/api/checking_invoice/";
            ModifyOrder(numeroOrden);
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
                    dgvDetalleCajaTarjeta.Rows.Add(item.product, item.quantity, item.price);
                }
                foreach (var item in orden.products)
                {
                    totalFactura += item.price;
                }
            }
            txtBoxTotal.Text = "$"+totalFactura.ToString();
        }
        private async Task ModifyOrder(int order)
        {
            string url = "https://binarysystem.pythonanywhere.com/api/updateOrder/?id=" + order + "&pay=True";
            var client = new HttpClient();

            Ordenes ordenActualizada = new Ordenes()
            {
                id = order,
                pay = "True",
            };

            var data = JsonSerializer.Serialize<Ordenes>(ordenActualizada);
            HttpContent httpContent = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await client.PutAsync(url, httpContent);

            if (httpResponse.IsSuccessStatusCode)
            {
                //var result = await httpResponse.Content.ReadAsStringAsync();
                Facturas crearFactura = new Facturas(numeroMesa);
                crearFactura.Show();
                this.Close();
            }
        }
        public class Ordenes
        {
            public int id { get; set; }
            public int table { get; set; }
            public List<Products> products { get; set; }
            public string pay { get; set; }
        }
        public class Products
        {
            public string product { get; set; }
            public int quantity { get; set; }
            public double price { get; set; }
        }
    }
}
