using Application_Sentidos.Resources.Objects;
using System.Text.Json;

namespace Application_Sentidos.Roles
{
    public partial class Mozo : Form
    {

        HttpUser userLogged;
        public Mozo(HttpUser user)
        {
            InitializeComponent();
            userLogged = user;
        }
        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            //Modifica el pedido seleccionado de la mesa x
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agregar elemento seleccionado de la lista de items del menu
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //deletear el pedido de la bd con el id o lo que sea, jeje
        }
        public async Task cargarCategorias(string categoria)
        {
            //var urlRequest = "https://jsonplaceholder.typicode.com/posts";
            var urlRequest = "https://binarysystem.pythonanywhere.com/api/filterCategory/?nameCategory=" + categoria;
            HttpClient client = new HttpClient();
            var httpResponse = await client.GetAsync(urlRequest);

            if (httpResponse.IsSuccessStatusCode)
            {
                MessageBox.Show(urlRequest);
                var content = await httpResponse.Content.ReadAsStringAsync();
                List<Productos> productos = JsonSerializer.Deserialize<List<Productos>>(content);
                MessageBox.Show("Join 2");
                foreach (var item in productos)
                {
                    listBoxProductos.Items.Add(item.name);
                }
                MessageBox.Show("Join 3");
            }

        }
        private void cboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboBoxCategorias.Text)
            {
                case "Bebidas sin alcohol": { cargarCategorias(cboBoxCategorias.Text); break; }
                case "Bebidas con alcohol": { cargarCategorias(cboBoxCategorias.Text); break; }
                case "Hamburguesas": { cargarCategorias(cboBoxCategorias.Text); break; }
                case "Lomitos": { cargarCategorias(cboBoxCategorias.Text); break; }
                case "Pastas": { cargarCategorias(cboBoxCategorias.Text); break; }
                case "Pescados": { cargarCategorias(cboBoxCategorias.Text); break; }
                case "Pizzas": { cargarCategorias(cboBoxCategorias.Text); break; }
                case "Snacks": { cargarCategorias(cboBoxCategorias.Text); break; }
            }
        }
        private void cboBoxMesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumeroMesa.Text = cboBoxMesas.Text;
        }
        private void Mozo_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(closeApp);
        }
        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Productos
    {
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public string img { get; set; }
    }
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
