using Application_Sentidos.Resources.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Application_Sentidos.Roles.Chef
{
    public partial class CrearMenuNuevo : Form
    {
        HttpClient client = new HttpClient();
        public CrearMenuNuevo()
        {
            InitializeComponent();
            dgvProductosMenu.ColumnHeadersVisible = false;
            this.CenterToScreen();
            loadCboCategoria();
        }


        private async void loadCboCategoria() {

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

        private void txtNombreMenu_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreMenu.TextLength != 0)
            {
                if (txtNombreMenu.TextLength > 20)
                {
                    MessageBox.Show("El nombre del menu no debe ser mayor a 20 caracteres.");
                    txtNombreMenu.Text = txtNombreMenu.Text.Remove(txtNombreMenu.Text.Length - 1);
                }
            }
        }
        private void emptyDgv() { dgvProductos.Rows.Clear(); }
        private bool seEncuentra(string name)
        {
            if (dgvProductosMenu.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dgvProductosMenu.Rows)
                {
                    if (row.Cells[1].Value.ToString() == name) { return true; }
                }
            }
            return false;
        }

        private async void bttAgregar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.Rows.Count != 0)
            {
                var product = dgvProductos.Rows[dgvProductos.CurrentRow.Index].Cells[1].Value.ToString();
                if (!seEncuentra(product))
                {
                    string URL = "https://binarysystem.pythonanywhere.com/api/filterName/?nameProduct=" + product;

                    var httpResponse = await client.GetAsync(URL);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        string content = await httpResponse.Content.ReadAsStringAsync();
                        var selectedProduct = JsonSerializer.Deserialize<Products>(content);
                        var imgBytes = await client.GetByteArrayAsync("https://binarysystem.pythonanywhere.com" + selectedProduct.img);
                        MemoryStream ms = new MemoryStream(imgBytes);

                        dgvProductosMenu.Rows.Add(selectedProduct.id, selectedProduct.name, selectedProduct.price, Image.FromStream(ms));
                    }
                }
                else
                {
                    MessageBox.Show("El producto ya se encuentra en el menu.");
                }
            }
            else
            {
                MessageBox.Show("No hay ningun producto seleccionado.");
            }
        }

        private void bttEliminarMenu_Click(object sender, EventArgs e)
        {
            if (dgvProductosMenu.Rows.Count != 0)
            {
                dgvProductosMenu.Rows.Remove(dgvProductosMenu.CurrentRow);
            }else { MessageBox.Show("No existen productos en el menu, por lo que debera agregar uno, para eliminar."); }
        }

        private async void bttCrearMenu_Click(object sender, EventArgs e)
        {
            if(dgvProductosMenu.Rows.Count != 0 && !(string.IsNullOrEmpty(txtNombreMenu.Text))){
                List<int> p = new List<int>();
                string URL = "https://binarysystem.pythonanywhere.com/api/menuAdmin/";
                foreach (DataGridViewRow i in dgvProductosMenu.Rows) { p.Add(Int32.Parse(i.Cells[0].Value.ToString())); }


                MenuPost menuPost = new MenuPost()
                {
                    name = txtNombreMenu.Text,
                    products = p
                };

                var requestJSON = JsonSerializer.Serialize<MenuPost>(menuPost); //I Serialized to JSON the Object post.
                HttpContent content = new StringContent(requestJSON, Encoding.UTF8, "application/json"); //Serialized the content.

                var httpResponse = await client.PostAsync(URL, content);

                if (httpResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Menu creado correctamente.");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al crear el menu, verifique sus datos.");
                }
            }
            else { MessageBox.Show("Ocurrio un error. Puede ser debido a lo siguiente:\nLa lista de productos del menu nuevo, no contiene productos.\nNo especifico un nombre para el nuevo menu.","Verifique los campos"); }
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

            } else if (!(string.IsNullOrEmpty(cboCategories.Text))) { //Buscamos por categoria
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
            }else if (!(string.IsNullOrEmpty(txtNombreProducto.Text))) //Buscamos por nombre de producto.
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

        private void bttLimpiar_Click(object sender, EventArgs e)
        {
            emptyDgv();
            txtNombreProducto.Text = string.Empty;
            cboCategories.Text = "";
        }
    }
}
