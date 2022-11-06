using System.Text.Json;

namespace Application_Sentidos.Roles
{
    public partial class Caja_Efectivo : Form
    {
        double totalFactura = 0;
        public int numeroOrden { get; set; }
        public int numeroMesa { get; set; }
        public int efectivo { get; set; }
        public Caja_Efectivo(int numero, int mesa)
        {
            efectivo = 1;
            numeroOrden = numero;
            numeroMesa = mesa;
            InitializeComponent();
            DetailOrder(numero);
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtBoxIngreso.Text == "" || cboTipoFactura.Text == "")
            {
                MessageBox.Show("Compruebe que todos los campos no esten vacios", "Faltan completar campos");
            }
            else
            {
                Facturas factura = new Facturas(numeroOrden, efectivo, numeroMesa, cboTipoFactura.Text);
                this.Close();
                factura.Show();
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
            txtBoxTotalItems.Text = totalFactura.ToString();
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
        private void txtBoxIngreso_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtBoxVuelto.Text = "$" + (double.Parse(txtBoxIngreso.Text) - totalFactura).ToString();
            }
            catch (Exception error)
            {
                txtBoxIngreso.Text = "";
                MessageBox.Show("El valor ingresado es incorrecto, solo se aceptan numeros", "Error de tipo de dato");
            }
        }
    }
}
