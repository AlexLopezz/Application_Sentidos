using System.Text.Json;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;
using System.Diagnostics;


namespace Application_Sentidos.Roles
{
    public partial class Facturas : Form
    {
        public double totalFactura = 0;
        public int numFactura = 0;
        public DateTime date = DateTime.Now;
        public int numOrden { get; set; }
        public int typePayment { get; set; }
        public int numeroMesa { get; set; }
        public string tipoDeFactura { get; set; }
        public Facturas(int numero, int method_payment, int mesa, string typeFactura)
        {
            tipoDeFactura = typeFactura;
            numeroMesa = mesa;
            numOrden = numero;
            InitializeComponent();
            txtBoxNumeroMeza.Text = mesa.ToString();
            typePayment = method_payment;
            actualizarDatosFactura();
        }
        private void actualizarDatosFactura()
        {
            numFactura++;
            lblFecha.Text = date.ToString();
            lblNumFactura.Text = numFactura.ToString();
        }
        public class Ordenes
        {
            public int id { get; set; }
            public int table { get; set; }
            public List<Products>? products { get; set; }
            public string? pay { get; set; }
        }
        public class Products
        {
            public string? product { get; set; }
            public int quantity { get; set; }
            public double price { get; set; }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtBoxNombreCliente.Text == "" || txtBoxDniCliente.Text == "")
            {
                MessageBox.Show("Todos los campos son requeridos", "Faltan completar los campos");
            }
            else
            {
                GenerarFactura(typePayment);
            }
        }
        public async void GenerarFactura(int payment)
        {
            string url = "https://binarysystem.pythonanywhere.com/api/checking_invoice/";
            var client = new HttpClient();
            //orden - tipo de pago - total factura
            Facturacion factura = new Facturacion()
            {
                order = numOrden,
                method_pay = payment,
                totalPrice = double.Parse(txtBoxTotal.Text),
            };
            var data = JsonSerializer.Serialize<Facturacion>(factura);
            HttpContent httpContent = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await client.PostAsync(url, httpContent);

            if (httpResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Factura creada con exito, ¡Gracias por su compra!", "Sentidos Restaurant & Casa de Té");
                ModifyOrder(numOrden);
                var content = await httpResponse.Content.ReadAsStringAsync();

                var facturaGET = JsonSerializer.Deserialize<FacturacionGET>(content);
                Process.Start(new ProcessStartInfo { FileName = @"https://binarysystem.pythonanywhere.com/api/PDFInvoice/?id="+ facturaGET.number_invoice, UseShellExecute = true }); 
            }
        }
        public async Task ModifyOrder(int order)
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
                    dgvDetallesFactura.Rows.Add(item.product, item.quantity, item.price);
                }
                foreach (var item in orden.products)
                {
                    totalFactura += item.price;
                }
            }
            txtBoxTotal.Text = totalFactura.ToString();
        }
        private void Facturas_Load(object sender, EventArgs e)
        {
            DetailOrder(numOrden);
            lblTipoFactura.Text = tipoDeFactura.ToString();
        }
    }
    public class Facturacion
    {
        public int order { get; set; }
        public int method_pay { get; set; }
        public double totalPrice { get; set; }
    } public class FacturacionGET
    {
        public int number_invoice { get; set; }
        public int order { get; set; }
        public int method_pay { get; set; }
        public double totalPrice { get; set; }
    }
}
