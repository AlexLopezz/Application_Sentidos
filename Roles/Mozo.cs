using Application_Sentidos.Resources.Objects;
using Newtonsoft.Json.Linq;

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
        public void cargarCategorias(string categoria)
        {
            using (var client = new HttpClient())
            {
                var urlRequest = "https://binarysystem.pythonanywhere.com/api/filterCategory/?nameCategory=" + categoria;
                var response = client.GetAsync(urlRequest).Result;
                var data = response.Content.ReadAsStringAsync().Result;
                dynamic dataSource = JObject.Parse(data);
            }
        }
        private void cboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = cboBoxCategorias.Text;

            switch (choice)
            {
                case "Bebidas sin alcohol": { cargarCategorias(choice); break; }
                case "Bebidas con alcohol": { cargarCategorias(choice); break; }
                case "Hamburguesas": { cargarCategorias(choice); break; }
                case "Lomitos": { cargarCategorias(choice); break; }
                case "Pastas": { cargarCategorias(choice); break; }
                case "Pescados": { cargarCategorias(choice); break; }
                case "Pizzas": { cargarCategorias(choice); break; }
                case "Snacks": { cargarCategorias(choice); break; }
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
}
