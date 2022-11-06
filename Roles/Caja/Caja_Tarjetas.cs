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
        public int tarjeta { get; set; }

        public Caja_Tarjetas(int numero, int method_payment, int mesa)
        {
            tarjeta = method_payment;
            numeroOrden = numero;
            numeroMesa = mesa;
            InitializeComponent();
            DetailOrder(numero);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {            
            if(cboBoxTipoFatura.Text == "" || txtBoxNombre.Text == "" || txtBoxApellido.Text == "" || 
                txtNumTarjeta.Text == "" || txtBoxCodTarjeta.Text == "" || txtBoxDireccion.Text == "" || 
                txtBoxTelefono.Text == "")
            {
                MessageBox.Show("Todos los campos son requeridos", "Complete todos los campos");
            }
            else
            {
                Facturas facturas = new Facturas(numeroOrden, tarjeta, numeroMesa, cboBoxTipoFatura.Text);
                facturas.Show();
                this.Close();
            }
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
            txtBoxTotal.Text = totalFactura.ToString();
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
