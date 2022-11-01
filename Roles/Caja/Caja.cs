using Application_Sentidos.Resources.Objects;
using System.Text.Json;

namespace Application_Sentidos.Roles
{

    public partial class Caja : Form
    {
        HttpUser userLogged;
        public Caja(HttpUser user)
        {
            InitializeComponent();
            userLogged = user;
        }

        private void TarjCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numberOrder = (int)dgvDetallesPedidos.CurrentRow.Cells[0].Value;
            Caja_Tarjetas caja_Credito = new Caja_Tarjetas(numberOrder);
            caja_Credito.numeroOrden = numberOrder;
            caja_Credito.ShowDialog();
        }

        private void TarjDebitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numberOrder = (int)dgvDetallesPedidos.CurrentRow.Cells[0].Value;
            Caja_Tarjetas caja_Debito = new Caja_Tarjetas(numberOrder);
            caja_Debito.numeroOrden = numberOrder;
            caja_Debito.ShowDialog();
        }

        private void EfectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int numberOrder = (int)dgvDetallesPedidos.CurrentRow.Cells[0].Value;
            Caja_Efectivo caja_Efectivo = new Caja_Efectivo(numberOrder);
            caja_Efectivo.numeroOrden = numberOrder;
            caja_Efectivo.numeroMesa = numberOrder;
            caja_Efectivo.ShowDialog();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            //Actualizar el dataGV para ver las nuevas mesas cerradas           
            //order = numero de orden de pedido
            //method_pay es = al id del metodo de pago            
            cargarPedidos();
        }
        public async Task cargarPedidos()
        {
            dgvDetallesPedidos.Rows.Clear();
            string urlGetPedidos = "https://binarysystem.pythonanywhere.com/api/allOrder/";
            HttpClient client = new HttpClient();
            var httpResponse = await client.GetAsync(urlGetPedidos);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                List<Ordenes> pedidos = JsonSerializer.Deserialize<List<Ordenes>>(content);

                foreach (var item in pedidos)
                {
                    dgvDetallesPedidos.Rows.Add(item.id, item.table);
                }
            }
        }
        private void Caja_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CloseApp);
        }
        private void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public class Products
        {
            public string product { get; set; }
            public int quantity { get; set; }
            public double price { get; set; }
        }
        public class Ordenes
        {
            public int id { get; set; }
            public int table { get; set; }
            public List<Products> products { get; set; }
        }
    }
}
