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
    public partial class Modificar : Form
    {
        
        HttpClient client = new HttpClient();
        MenuGet menuAux;
        public Modificar(string menu)
        {
            InitializeComponent();
            this.CenterToScreen();
            loadMenu(menu);
            loadCboCategoria();
        }
        
        private async void loadMenu(string menu)
        {
            string URL = "https://binarysystem.pythonanywhere.com/api/filterMenu/?name=" + menu;

            var response = await client.GetAsync(URL);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var menuGET = JsonSerializer.Deserialize<MenuGet>(content);
                menuAux = menuGET;
                txtNombreMenu.Text = menuGET.name;
                dgvProductoMenu.ColumnHeadersVisible = false;
                foreach (var m in menuGET.products)
                {
                    var imgBytes = await client.GetByteArrayAsync("https://binarysystem.pythonanywhere.com" + m.img);
                    MemoryStream ms = new MemoryStream(imgBytes);
                    dgvProductoMenu.Rows.Add(Image.FromStream(ms), m.description, m.name, m.id);
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void bttEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductoMenu.Rows.Count != 0)
            {
                dgvProductoMenu.Rows.Remove(dgvProductoMenu.CurrentRow);
            }
            else { MessageBox.Show("No se puede eliminar, debido a que el menu no contiene productos."); }
        }
        private bool seEncuentra(string name)
        {
            if (dgvProductoMenu.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvProductoMenu.Rows)
                {
                    if (row.Cells[1].Value.ToString() == name) { return true; }
                }
            }
            return false;
        }
        private async void addDgvMenu(string producto)
        {
           
            if (!seEncuentra(producto))
            {
                string URL = "https://binarysystem.pythonanywhere.com/api/filterName/?nameProduct=" + producto;

                var httpResponse = await client.GetAsync(URL);
                if (httpResponse.IsSuccessStatusCode)
                {
                    string content = await httpResponse.Content.ReadAsStringAsync();
                    var selectedProduct = JsonSerializer.Deserialize<Products>(content);
                    var imgBytes = await client.GetByteArrayAsync("https://binarysystem.pythonanywhere.com" + selectedProduct.img);
                    MemoryStream ms = new MemoryStream(imgBytes);

                    dgvProductoMenu.Rows.Add(Image.FromStream(ms), selectedProduct.description, selectedProduct.name,selectedProduct.id );
                }
            }
        }

        private void bttAgregarProducto_Click(object sender, EventArgs e) => this.Size = new Size(895, 450);
        private void emptyDgv() { dgvProductos.Rows.Clear(); }

        private void bttLimpiar_Click(object sender, EventArgs e)
        {
            emptyDgv();
            txtNombreProducto.Text = string.Empty;
            cboCategories.Text = "";
            
        }

        private async void loadCboCategoria()
        {

            string URL = "https://binarysystem.pythonanywhere.com/api/allCategories/";
            var response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var allCategories = JsonSerializer.Deserialize<List<Categories>>(content);
                cboCategories.Items.Add("");
                foreach (var category in allCategories)
                {
                    cboCategories.Items.Add(category.name);
                }
            }
        }
        private async void bttBuscarNombreProducto_Click(object sender, EventArgs e)
        {
            emptyDgv();
            if (cboCategories.Text != "" && !(string.IsNullOrEmpty(txtNombreProducto.Text))) //Buscamos por ctaegoria y nombre de producto
            {
                string URLProductCategory = "https://binarysystem.pythonanywhere.com/api/filterProductAndCategory/?nameProduct=" + txtNombreProducto.Text + "&nameCategory=" + cboCategories.Text;

                var responseProductCategory = await client.GetAsync(URLProductCategory);
                if (responseProductCategory.IsSuccessStatusCode)
                {
                    var content = await responseProductCategory.Content.ReadAsStringAsync();
                    var productForName = JsonSerializer.Deserialize<List<Products>>(content);

                    foreach (var product in productForName)
                    {
                        dgvProductos.Rows.Add(product.id, product.name);
                    }
                }
                else { MessageBox.Show("No se encontraron resultados."); }

            }
            else if (!(string.IsNullOrEmpty(cboCategories.Text)))
            { //Buscamos por categoria
                string URLCategory = "https://binarysystem.pythonanywhere.com/api/filterCategory/?nameCategory=" + cboCategories.Text;
                var response = await client.GetAsync(URLCategory);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var productCategory = JsonSerializer.Deserialize<List<Products>>(content);

                    foreach (var product in productCategory)
                    {
                        dgvProductos.Rows.Add(product.id, product.name);
                    }
                }
            }
            else if (!(string.IsNullOrEmpty(txtNombreProducto.Text))) //Buscamos por nombre de producto.
            {
                string URL = "https://binarysystem.pythonanywhere.com/api/filterNameProduct/?nameProduct=" + txtNombreProducto.Text;

                var httpResponse = await client.GetAsync(URL);
                if (httpResponse.IsSuccessStatusCode)
                {
                    var content = await httpResponse.Content.ReadAsStringAsync();
                    var productForName = JsonSerializer.Deserialize<List<Products>>(content);

                    foreach (var product in productForName)
                    {
                        dgvProductos.Rows.Add(product.id, product.name);
                    }
                }
            }
            else { MessageBox.Show("Ocurrio un error, fijese los campos de busqueda.\nAl menos un campo debe estar completo para la busqueda de los productos.\nCampos de busqueda: Nombre Prducto, Categoria.", "Verifique campos."); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value.ToString();
            addDgvMenu(product);
            this.Size = new Size(530, 450);
        }

        private async void bttModificar_Click(object sender, EventArgs e)
        {
            if (dgvProductoMenu.Rows.Count != 0 && !(string.IsNullOrEmpty(txtNombreMenu.Text)))
            {
                List<int> products = new List<int>();

                string URL = "https://binarysystem.pythonanywhere.com/api/menuAdmin/?id=" + menuAux.id;
                foreach (DataGridViewRow p in dgvProductoMenu.Rows)
                {
                    products.Add(Int32.Parse(p.Cells[3].Value.ToString()));
                }

                MenuPost menuPUT = new MenuPost()
                {
                    name = txtNombreMenu.Text,
                    products = products
                };

                var requestJSON = JsonSerializer.Serialize<MenuPost>(menuPUT); //I Serialized to JSON the Object post.
                HttpContent content = new StringContent(requestJSON, Encoding.UTF8, "application/json"); //Serialized the content.

                var httpResponse = await client.PutAsync(URL, content);

                if (httpResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Modificado correctamente.");
                    this.Close();
                }
            }else 
            { 
                MessageBox.Show("Ocurrio un error, puede ser por lo siguiente: \n*Nombre de menu, vacio.\n*Lista de productos, vacio.", "Verifique los campos."); 
            }
        }

        private void txtNombreMenu_TextChanged(object sender, EventArgs e)
        {
            if(txtNombreMenu.Text.Length > 20)
            {
                MessageBox.Show("El nombre del menu, no debe superar los 20 caracteres.");
                txtNombreMenu.Text.Remove(txtNombreMenu.Text.Length - 1);
            }
        }
    }

}
