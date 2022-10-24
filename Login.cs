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
using Application_Sentidos.Resources.Objects;
using Application_Sentidos.Roles;
namespace Application_Sentidos.Authentication
{
    public partial class Login : Form
    {
        string urlBase = "https://binarysystem.pythonanywhere.com/api/login/"; //WARNING: Check the URL, generally i use localhost for testing app...
        JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }; //The options ignore case sensitive values.
        HttpClient httpClient = new HttpClient(); //We use for request post and get

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void bttLogin_Click(object sender, EventArgs e)
        {
            if (checkFieldLogin())
            {
                MessageBox.Show("Campos vacios, en Usuario y/o Contraseña");
            }
            else
            {
                PostLogin post = new PostLogin()
                {
                    username = txtUsername.Text,
                    password = txtPassword.Text
                };
                
                var requestJSON = JsonSerializer.Serialize<PostLogin>(post, options); //I Serialized to JSON the Object post.
                HttpContent content = new StringContent(requestJSON, Encoding.UTF8, "application/json"); //Serialized the content.

                var httpResponse = await httpClient.PostAsync(urlBase, content);
                cleanedFieldLogin();
                if (httpResponse.IsSuccessStatusCode)
                {
                    var contentResponse = await httpResponse.Content.ReadAsStringAsync();

                    var user = JsonSerializer.Deserialize<HttpUser>(contentResponse, options); //Deserialized JSON to Object

                    switch (user.role.name)
                    {
                        case "Administrador":
                            this.Hide();
                            Administrador myAdmin = new Administrador(user);
                            myAdmin.ShowDialog();
                            break;
                        case "Maitre":
                            this.Hide();
                            Maitre maitre = new Maitre(user);
                            maitre.ShowDialog();
                            break;
                        case "Mozo":
                            this.Hide();
                            Mozo mozo = new Mozo(user);
                            mozo.ShowDialog();
                            break;
                        case "Caja":
                            this.Hide();
                            Caja caja = new Caja(user);
                            caja.ShowDialog();
                            break;
                        default:
                            MessageBox.Show("No tiene autorizacion para entrar al sistema.");
                            break;
                    }

                }
                else
                {
                    var contentResponse = await httpResponse.Content.ReadAsStringAsync();
                    MessageBox.Show(contentResponse);
                }
            }
            
        }
        private bool checkFieldLogin()
        {
            return string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text);
        }
        private void cleanedFieldLogin()
        {
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
