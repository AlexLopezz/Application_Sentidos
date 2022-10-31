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
using Application_Sentidos.Resources.Administrador;
using Application_Sentidos.Roles.AdministradorFolder;

namespace Application_Sentidos.Resources.Administrador
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
       
        private async void bttRegistrar_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
           JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }; //The options ignore case sensitive values.
            
            if (validateFields())
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {

                if (txtPassword.Text.Equals(txtVerifyPassword.Text))
                {
                    string urlBase = "https://binarysystem.pythonanywhere.com/api/register/";
                    PostRegister Post = new PostRegister()
                    {
                        username = txtUsername.Text,
                        email = txtEmail.Text,
                        fullname = txtFullname.Text,
                        dni = txtDNI.Text,
                        password = txtPassword.Text,
                        role = select_role(cboRoles.Text)
                    };

                    var requestJSON = JsonSerializer.Serialize<PostRegister>(Post, options);
                    HttpContent content = new StringContent(requestJSON, Encoding.UTF8, "application/json");

                    var httpResponse = await httpClient.PostAsync(urlBase, content);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("¡Usuario registrado con exito!");
                        this.Close();
                    }
                    else { MessageBox.Show("Hubo un error, verifique sus datos."); }
                }
                else
                {
                    MessageBox.Show("Contraseñas no coinciden.");
                }
            }
        }

        //Utilidades:
        public int select_role(string txtRole)
        {
            int fk_role = 0;
            switch (txtRole)
            {
                case "Administrador":
                    fk_role = 1;
                    break;
                case "Maitre":
                    fk_role = 2;
                    break;
                case "Mozo":
                    fk_role = 3;
                    break;
                case "Caja":
                    fk_role = 4;
                    break;
                case "Usuario":
                    fk_role= 5;
                    break;
                default:
                    break;
            }
            return fk_role;
        }
        public bool validateFields()
        {
            return string.IsNullOrEmpty(txtFullname.Text) && string.IsNullOrEmpty(txtDNI.Text)
                && string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text) &&
                string.IsNullOrEmpty(txtVerifyPassword.Text) && string.IsNullOrEmpty(cboRoles.Text);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
