using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Sentidos.Roles.Chef
{
    public partial class CrearProducto : Form
    {
        HttpClient client = new HttpClient();
        string imgBase64 = "";
        List<int> categoryList = new List<int>();
        public CrearProducto()
        {
            InitializeComponent();
            this.CenterToScreen();
            loadCategoria();
        }

        private void bttOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = openFileDialog.FileName;
                picImagenProducto.ImageLocation = openFileDialog.FileName;

                byte[] archivo = System.IO.File.ReadAllBytes(txtImagen.Text);
                imgBase64 = Convert.ToBase64String(archivo);
               
            }
        }
        private async void loadCategoria()
        {
            string URL = "https://binarysystem.pythonanywhere.com/api/allCategories/";
            var response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var categorias = JsonSerializer.Deserialize<List<Categories>>(content);

                foreach (var c in categorias)
                {
                    dgvCategoria.Rows.Add(c.name);
                }
            }
            else { MessageBox.Show("Actualmente no existen categorias."); }
        }

        private async void bttAgregar_Click(object sender, EventArgs e)
        {
            string URL = "https://binarysystem.pythonanywhere.com/api/filterForCategoryName/?nameCategory=" + dgvCategoria.CurrentCell.Value.ToString();
            var response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var categoria = JsonSerializer.Deserialize<Categories>(content);

                listCategorias.Items.Add("Categoria: " + categoria.name + " | Cod.Categoria: " + categoria.id);
            }
            else { MessageBox.Show("Error."); }
        }
        private void bttEliminar_Click(object sender, EventArgs e)
        {
            if (listCategorias.Items.Count != 0 || listCategorias.SelectedItem != null)
            {
                string categoria = listCategorias.SelectedItem.ToString();
                int index = listCategorias.FindString(categoria);
                listCategorias.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Debe escoger una categoria, antes de eliminar.");
            }
        }

        private async void bttCrearProducto_Click(object sender, EventArgs e)
        {
            int numAux = 0;
            if(!(string.IsNullOrEmpty(txtNombre.Text)) && !(string.IsNullOrEmpty(txtDescripcion.Text)) && !(string.IsNullOrEmpty(txtImagen.Text)) &&
                !(string.IsNullOrEmpty(txtPrecio.Text)) && listCategorias.Items.Count != 0){
                string URL = "https://binarysystem.pythonanywhere.com/imgJson/";
                foreach(var c in listCategorias.Items)
                {
                    foreach(var a in c.ToString())
                    {
                        if (Char.IsDigit(a))
                        {
                            numAux += Int32.Parse(a.ToString());
                        }
                    }
                    categoryList.Add(numAux);
                }


                ProductPOST postProducto = new ProductPOST()
                {
                    name = txtNombre.Text,
                    description = txtDescripcion.Text,
                    price = double.Parse(txtPrecio.Text),
                    img = imgBase64,
                    category = categoryList
                };

                var requestJSON = JsonSerializer.Serialize<ProductPOST>(postProducto); //I Serialized to JSON the Object post.
                HttpContent content = new StringContent(requestJSON, Encoding.UTF8, "application/json"); //Serialized the content.

                var httpResponse = await client.PostAsync(URL, content);

                if (httpResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto creado con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error de servidor.");
                }
            }
        }
    }
}
