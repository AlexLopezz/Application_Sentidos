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

namespace Application_Sentidos.Roles.Chef
{
    public partial class ProductosCategorias : Form
    {
       
        HttpClient client = new HttpClient();

        public ProductosCategorias()
        {
            InitializeComponent();
            loadDgvProductos();
            loadDgvCategoria();
        }
        private async void loadDgvCategoria()
        {
            emptyDgv(dgvCategoria);
            string URL = "https://binarysystem.pythonanywhere.com/api/allCategories/";
            var response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var categorias = JsonSerializer.Deserialize<List<Categories>>(content);

                foreach(var c in categorias)
                {
                    dgvCategoria.Rows.Add(c.name);
                }
            }
            else { MessageBox.Show("Actualmente no existen categorias."); }
        }
        private async void loadDgvProductos()
        {
            emptyDgv(dgvProductos);
            string URL = "https://binarysystem.pythonanywhere.com/api/products/";
            var response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var allProducts = JsonSerializer.Deserialize<List<Products>>(content);
                foreach (var p in allProducts)
                {
                    var imgBytes = await client.GetByteArrayAsync("https://binarysystem.pythonanywhere.com" + p.img);
                    MemoryStream ms = new MemoryStream(imgBytes);
                    try
                    {
                        dgvProductos.Rows.Add(p.id, p.name, Image.FromStream(ms));
                    }
                    catch (Exception) { MessageBox.Show("Intentelo de nuevo."); }
                }
            }
        }
        private void emptyDgv(DataGridView dgv) { dgv.Rows.Clear(); }
        private async void bttBuscarNombreProducto_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtProductoNombre.Text))){
                emptyDgv(dgvProductos);
                string URL = "https://binarysystem.pythonanywhere.com/api/filterName/?nameProduct=" + txtProductoNombre.Text;
                txtProductoNombre.Text = "";
                var response = await client.GetAsync(URL);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var products = JsonSerializer.Deserialize<List<Productos>>(content);

                    foreach (var p in products)
                    {
                        var imgBytes = await client.GetByteArrayAsync("https://binarysystem.pythonanywhere.com" + p.img);
                        MemoryStream ms = new MemoryStream(imgBytes);

                        dgvProductos.Rows.Add(p.id, p.name, Image.FromStream(ms));
                    }
                }
            }
        }

        private void bttAgregarProducto_Click(object sender, EventArgs e)
        {
            CrearModificarProducto producto = new CrearModificarProducto("Crear producto");
            producto.ShowDialog();
            loadDgvCategoria();
            loadDgvProductos();
        }

        private async void bttEliminarProducto_Click(object sender, EventArgs e)
        {
            if(dgvProductos.Rows.Count != 0)
            {
                string text = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value.ToString();
                string URL = "https://binarysystem.pythonanywhere.com/imgJson/?nameProduct=" + text;

                var response = await client.DeleteAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto eliminado con exito.");
                    loadDgvCategoria();
                    loadDgvProductos();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error.");
                }
            }
            else
            {
                MessageBox.Show("No se puede eliminar, debido a que no hay productos elegidos.");
            }
           
        }

        private void bttAgregarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaAgregar_Modificar categoria = new CategoriaAgregar_Modificar("Crear categoria");
            categoria.ShowDialog();
            loadDgvCategoria();
        }

        private void bttModificarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaAgregar_Modificar categoria = new CategoriaAgregar_Modificar("Modificar categoria", dgvCategoria.CurrentCell.Value.ToString());
            categoria.ShowDialog();
            loadDgvCategoria();
        }

        private async void bttEliminarCategoria_Click(object sender, EventArgs e)
        {
            string URL = "https://binarysystem.pythonanywhere.com/api/deleteCategory/?nameCategory=" + dgvCategoria.CurrentCell.Value.ToString();

            var response = await client.DeleteAsync(URL);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Categoria eliminada correctamente.");
                loadDgvCategoria();
            }
            else
            {
                MessageBox.Show("Hubo un error de conexion.");
            }
        }

        private void bttModificarProducto_Click(object sender, EventArgs e)
        {
            CrearModificarProducto crearModificar = new CrearModificarProducto("Modificar producto", dgvProductos.CurrentRow.Cells[1].Value.ToString());
            crearModificar.ShowDialog();
        }

        private void bttRefresh_Click(object sender, EventArgs e)
        {
            loadDgvProductos();
        }
    }
}
