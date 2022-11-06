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
using static System.Net.Mime.MediaTypeNames;

namespace Application_Sentidos.Roles.Chef
{
    public partial class CrearModificarProducto : Form
    {
        string auxNameProduct = "";
        HttpClient client = new HttpClient();
        string imgBase64 = "";
        ProductsGET producto = new ProductsGET();
        List<int> categoryList = new List<int>();
        public CrearModificarProducto(string bttCategoria)
        {
            InitializeComponent();
            this.CenterToScreen();
            bttCrearProducto.Text = bttCategoria;
            loadCategoria();
        }
        public CrearModificarProducto(string bttCategoria, string nameProduct)
        {
            InitializeComponent();
            this.CenterToScreen();
            bttCrearProducto.Text = bttCategoria;
            bttCrearProducto.BackColor = Color.LightSalmon;
            auxNameProduct = nameProduct;
            loadCategoria();
            loadFields(auxNameProduct);
        }

        private async void loadFields(string nameProduct)
        {
            string URL = "https://binarysystem.pythonanywhere.com/api/filterName/?nameProduct=" + nameProduct;
            var response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var product = JsonSerializer.Deserialize<ProductsGET>(content);
                producto = product;
                txtNombre.Text = product.name;
                txtDescripcion.Text = product.description;
                txtPrecio.Text = product.price.ToString();
                txtImagen.Text = "Imagen obtenida de BinarySystem API.";
                txtImagen.ReadOnly = true;

                foreach(var c in product.category)
                {
                    listCategorias.Items.Add("Categoria: " + c.name + " | Cod.Categoria: " + c.id);
                }
            }
        }

        private void bttOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImagen.ReadOnly= true;
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

        private void rellenarListaCategoria(List<int> category)
        {
            string numAx = string.Empty;
            foreach (var c in listCategorias.Items)
            {
                foreach (var a in c.ToString())
                {
                    if (Char.IsDigit(a))
                    {
                        numAx+= (a.ToString());
                    }
                }
                if (numAx != string.Empty)
                {
                    categoryList.Add(Int32.Parse(numAx));
                    numAx = string.Empty;
                }
            }

        }
        private async void bttCrearProducto_Click(object sender, EventArgs e)
        {
            switch (bttCrearProducto.Text)
            {
                case "Crear producto":

                    
                    if (!(string.IsNullOrEmpty(txtNombre.Text)) && !(string.IsNullOrEmpty(txtDescripcion.Text)) && !(string.IsNullOrEmpty(txtImagen.Text)) &&
                        !(string.IsNullOrEmpty(txtPrecio.Text)) && listCategorias.Items.Count != 0)
                    {
                        string URL = "https://binarysystem.pythonanywhere.com/imgJson/";

                        rellenarListaCategoria(categoryList);


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
                    break;
                
                case "Modificar producto":

                    if (!(string.IsNullOrEmpty(txtNombre.Text)) && !(string.IsNullOrEmpty(txtDescripcion.Text)) && !(string.IsNullOrEmpty(txtImagen.Text)) &&
                        !(string.IsNullOrEmpty(txtPrecio.Text)) && listCategorias.Items.Count != 0)
                    {
                        rellenarListaCategoria(categoryList);
                        string URLModificar = "https://binarysystem.pythonanywhere.com/imgJson/?id="+producto.id;

                        if (txtImagen.Text == "Imagen obtenida de BinarySystem API.")
                        {
                            ProductPUT putProductoSINIMG = new ProductPUT();
                            
                            putProductoSINIMG.name = txtNombre.Text;
                            putProductoSINIMG.description = txtDescripcion.Text;
                            putProductoSINIMG.price = double.Parse(txtPrecio.Text);
                            putProductoSINIMG.category = categoryList;

                            var requestJSON = JsonSerializer.Serialize<ProductPUT>(putProductoSINIMG);
                            HttpContent content = new StringContent(requestJSON, Encoding.UTF8, "application/json");

                            var httpResponse = await client.PutAsync(URLModificar, content);

                            if (httpResponse.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Producto modificado con exito.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error banda :/");
                            }
                        }
                        else
                        {
                            ProductPOST putProducto = new ProductPOST();
                            putProducto.name = txtNombre.Text;
                            putProducto.description = txtDescripcion.Text;
                            putProducto.price = double.Parse(txtPrecio.Text);
                            putProducto.img = imgBase64;
                            putProducto.category = categoryList;

                            var requestJSON = JsonSerializer.Serialize<ProductPOST>(putProducto);
                            HttpContent content = new StringContent(requestJSON, Encoding.UTF8, "application/json");

                            var httpResponse = await client.PutAsync(URLModificar, content);

                            if (httpResponse.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Producto modificado con exito.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error banda :/");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Verifique los campos, puede que no esteen vacios.");
                    }
                    break;
            }
            
        }
    }
}
