﻿using System.Text.Json;

namespace Application_Sentidos.Roles
{
    public partial class Caja_Efectivo : Form
    {
        double totalFactura = 0;
        public int numeroOrden { get; set; }
        public int numeroMesa { get; set; }
        public Caja_Efectivo(int numero)
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
            //
            ModifyOrder(numeroOrden);
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    dgvDetallesPedidoIndividual.Rows.Add(item.product, item.quantity, item.price);
                }
                foreach (var item in orden.products)
                {
                    totalFactura += item.price;
                }
            }
            txtBoxTotalItems.Text = "$" + totalFactura.ToString();
        }
        public class Ordenes
        {
            public int id { get; set; }
            public int table { get; set; }
            public List<Products> products { get; set; }
            public string? pay  { get; set; }
        }
        public class Products
        {
            public string product { get; set; }
            public int quantity { get; set; }
            public double price { get; set; }
        }

        private void txtBoxIngreso_TextChanged(object sender, EventArgs e)
        {
            txtBoxVuelto.Text = "$" + (double.Parse(txtBoxIngreso.Text) - totalFactura).ToString();
        }
    }
}
