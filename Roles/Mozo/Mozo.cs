﻿using Application_Sentidos.Resources.Objects;
using System.Text.Json;

namespace Application_Sentidos.Roles
{
    public partial class Mozo : Form
    {

        List<Productos> listaProductos = new List<Productos>();

        HttpUser userLogged;
        public Mozo(HttpUser user)
        {
            InitializeComponent();
            userLogged = user;
            txtBoxCantidad.Text = "1";
        }
        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            //Modifica el pedido seleccionado de la mesa x
            if (dgvPedidosACerrar.Rows.Count == 0)
            {
                MessageBox.Show("Genere y cargue un pedido para moder modificar su seleccion", "Generar y cargar para Modificar");
            }
            else if (dgvPedidoMesa.Rows.Count != 0)
            {
                MessageBox.Show("Debe terminar de cargar su pedido para modificar otro", "Finalice su pedido");
            }
            else
            {
                cboBoxMesas.Text = dgvPedidosACerrar.CurrentRow.Cells[0].Value.ToString();
                int nmesa = int.Parse(cboBoxMesas.Text);
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    if (listaProductos[i].numMesa == nmesa)
                    {
                        dgvPedidoMesa.Rows.Add(listaProductos[i].name, listaProductos[i].cantidad,
                            listaProductos[i].price, listaProductos[i].totalProducto);
                    }
                }
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    if (listaProductos[i].numMesa == nmesa)
                    {
                        listaProductos.RemoveAt(i);
                    }
                }
                dgvPedidosACerrar.Rows.RemoveAt(dgvPedidosACerrar.CurrentRow.Index);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agrega el elemento seleccionado de la lista al pedido de la mesa
            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar una categoria para poder cargar un pedido", "Falta seleccionar Categoria");
            }
            else if (lblNumeroMesa.Text == "-")
            {
                MessageBox.Show("Debe seleccionar una mesa antes de agregar un item", "Seleccion de Mesa");
            }
            else if (txtBoxCantidad.Text == "")
            {
                MessageBox.Show("Ingrese una cantidad antes de agregar el item", "Cantidad Requerida");
            }
            else
            {
                double cantidad = double.Parse(txtBoxCantidad.Text);
                double prod = (double)dgvProductos.CurrentRow.Cells[1].Value;
                double totalProducto = prod * cantidad;
                dgvPedidoMesa.Rows.Add(dgvProductos.CurrentRow.Cells[0].Value, txtBoxCantidad.Text, dgvProductos.CurrentRow.Cells[1].Value, totalProducto);
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvPedidoMesa.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un item para elimiarlo", "Seleccion");
            }
            else
            {
                dgvPedidoMesa.Rows.RemoveAt(dgvPedidoMesa.CurrentRow.Index);
            }
        }
        public async Task cargarCategorias(string categoria)
        {
            var urlRequest = "https://binarysystem.pythonanywhere.com/api/filterCategory/?nameCategory=" + categoria;
            HttpClient client = new HttpClient();
            var httpResponse = await client.GetAsync(urlRequest);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                List<Productos> productos = JsonSerializer.Deserialize<List<Productos>>(content);

                foreach (var item in productos)
                {
                    dgvProductos.Rows.Add(item.name, item.price);
                }
            }
        }
        private void cboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboBoxCategorias.Text)
            {
                case "Bebidas sin alcohol":
                    {
                        dgvProductos.Rows.Clear();
                        cargarCategorias(cboBoxCategorias.Text);
                        break;
                    }
                case "Bebidas con alcohol":
                    {
                        dgvProductos.Rows.Clear();
                        cargarCategorias(cboBoxCategorias.Text);
                        break;
                    }
                case "Hamburguesas":
                    {
                        dgvProductos.Rows.Clear();
                        cargarCategorias(cboBoxCategorias.Text);
                        break;
                    }
                case "Lomitos":
                    {
                        dgvProductos.Rows.Clear();
                        cargarCategorias(cboBoxCategorias.Text);
                        break;
                    }
                case "Pastas":
                    {
                        dgvProductos.Rows.Clear();
                        cargarCategorias(cboBoxCategorias.Text);
                        break;
                    }
                case "Pescados":
                    {
                        dgvProductos.Rows.Clear();
                        cargarCategorias(cboBoxCategorias.Text);
                        break;
                    }
                case "Pizzas":
                    {
                        dgvProductos.Rows.Clear();
                        cargarCategorias(cboBoxCategorias.Text);
                        break;
                    }
                case "Snacks":
                    {
                        dgvProductos.Rows.Clear();
                        cargarCategorias(cboBoxCategorias.Text);
                        break;
                    }
            }
        }
        private void cboBoxMesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblNumeroMesa.Text = cboBoxMesas.Text;
        }
        private void btnCargarMesa_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (dgvPedidoMesa.Rows.Count == 0)
            {
                MessageBox.Show("Debe generar un pedido antes de cargarlo", "Carga de Pedido Requerida");
            }
            else
            {
                foreach (DataGridViewRow row in dgvPedidoMesa.Rows)
                {
                    total += (double)row.Cells[3].Value;
                }
                dgvPedidosACerrar.Rows.Add(cboBoxMesas.Text, total);


                foreach (DataGridViewRow row in dgvPedidoMesa.Rows)
                {
                    Productos prod = new Productos();
                    prod.numMesa = int.Parse(cboBoxMesas.Text);
                    prod.name = row.Cells[0].Value.ToString();
                    prod.cantidad = row.Cells[1].Value.ToString();
                    prod.price = (double)row.Cells[2].Value;
                    prod.totalProducto = (double)row.Cells[3].Value;
                    listaProductos.Add(prod);
                }
            }

        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Clear();
            dgvPedidoMesa.Rows.Clear();
            cboBoxCategorias.Text = "";
            cboBoxMesas.Text = "";
            txtBoxCantidad.Text = "1";
            lblNumeroMesa.Text = "";
        }

        private void btnCerrarMesa_Click_1(object sender, EventArgs e)
        {
            //post
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
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string img { get; set; }
        public string cantidad { get; set; }
        public double totalProducto { get; set; }
        public int numMesa { get; set; }
    }
}
