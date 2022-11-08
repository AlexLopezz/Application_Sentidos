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
using static System.Net.WebRequestMethods;

namespace Application_Sentidos.Roles.Chef
{
    public partial class CategoriaAgregar_Modificar : Form
    {
        ErrorProvider err = new ErrorProvider();
        HttpClient client = new HttpClient();
        string auxNameCategory = "";
        public CategoriaAgregar_Modificar(string txtCategoria)
        {
            InitializeComponent();
            this.CenterToScreen();
            bttCategoria.Text = txtCategoria;
        }
        public CategoriaAgregar_Modificar(string txtCategoria, string nameCategory)
        {
            InitializeComponent();
            this.CenterToScreen();
            bttCategoria.Text = txtCategoria;
            auxNameCategory = nameCategory;
            textBox1.Text = nameCategory;
        }

        private async void bttCategoria_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != string.Empty && textBox1.Text.Length > 3)
            {
                switch (bttCategoria.Text)
                {
                    case "Crear categoria":
                        string URLCrear = "https://binarysystem.pythonanywhere.com/api/postCategory/";

                        CategoriesPOST category = new CategoriesPOST()
                        {
                            name = textBox1.Text
                        };

                        var requestJSON = JsonSerializer.Serialize<CategoriesPOST>(category); //I Serialized to JSON the Object post.
                        HttpContent content = new StringContent(requestJSON, Encoding.UTF8, "application/json"); //Serialized the content.

                        var httpResponse = await client.PostAsync(URLCrear, content);

                        if (httpResponse.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Categoria creada con exito.");
                            this.Close();
                        }
                        else { MessageBox.Show("Hubo un error, verifique su conexion.");  }
                        break;

                    case "Modificar categoria":
                        //GET: Para obtener el objeto categoria y su ID.
                        string URLFiltroCategoria = "https://binarysystem.pythonanywhere.com/api/filterForCategoryName/?nameCategory=" + auxNameCategory;

                        var response = await client.GetAsync(URLFiltroCategoria);
                        if (response.IsSuccessStatusCode)
                        {
                            var contentModificar = await response.Content.ReadAsStringAsync();
                            //Una vez que tenemos el objeto, pasamos a realizar el PUT.
                            var categoriaModificar = JsonSerializer.Deserialize<Categories>(contentModificar);
                            //PUT: 
                            string URLModificar = "https://binarysystem.pythonanywhere.com/api/modifyCategory/?id=" + categoriaModificar.id; //Con esta URL trabajaremos.
                            
                            CategoriesPOST categories = new CategoriesPOST()
                            {
                                name = textBox1.Text
                            };

                            requestJSON = JsonSerializer.Serialize<CategoriesPOST>(categories); //I Serialized to JSON the Object post.
                            content = new StringContent(requestJSON, Encoding.UTF8, "application/json"); //Serialized the content.

                            httpResponse = await client.PutAsync(URLModificar, content);

                            if (httpResponse.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Categoria modificada con exito.");
                                this.Close();
                            }
                            else { MessageBox.Show("Hubo un error de conexion."); }

                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Ocurrio un error, verifique lo siguiente:\n*El campo no debe estar vacio.\n*El campo debe ser tener almenos 4 caracteres.");
            }
        }
    }
}
