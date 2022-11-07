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
using Application_Sentidos.Resources.Objects;
using Application_Sentidos.Roles.AdministradorFolder;

namespace Application_Sentidos.Resources.Administrador
{
    public partial class Registro : Form
    {
        bool errProviderFullname = false, errProviderEmail = false, errProviderDni = false,
           errProviderUsername = false, errProviderCheckPass = false, errProviderCboRol = false;
        ErrorProvider err = new ErrorProvider();
        HttpClient httpClient = new HttpClient();
        JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }; //The options ignore case sensitive values.
        Utilidades utilidades = new Utilidades();
        
        public Registro()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
                
        private async void bttRegistrar_Click(object sender, EventArgs e)
        {
            if (errProviderFullname || errProviderDni || errProviderCheckPass || errProviderCboRol ||
                errProviderUsername || errProviderEmail)
            {
                MessageBox.Show("Debe completar todos los campos. Verifique las validaciones.");
            }
            else
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
                case "Chef":
                    fk_role = 6;
                    break;
                default:
                    break;
            }
            return fk_role;
        }

        //Validaciones de campos:
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validate = utilidades.onlyNumbers(e);
            if (!validate)
            {
                err.SetError(txtDNI, "Debe ingresar solo numeros.");
                errProviderDni = true;
            }
            else if (txtDNI.Text.Length == 7)
            {
                errProviderDni = false;
                err.Clear();
            }
            else {
                err.SetError(txtDNI, "El DNI, como usted sabe, debe contener 8 digitos.");
                errProviderDni = true; 
         
            }
        }
        private void txtFullname_Leave(object sender, EventArgs e)
        {
            if (utilidades.nullField(txtFullname))
            {
                err.SetError(txtFullname, "*El campo no debe estar vacio.");
                errProviderFullname = true;
            }
            else { 
                err.Clear();
                errProviderFullname = false;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!utilidades.validarEmail(txtEmail.Text) || utilidades.nullField(txtEmail))
            {
                err.SetError(txtEmail, "Verifique lo siguiente:\n*Formato de correo no valido.\n*El campo no debe estar vacio.");
                errProviderEmail = true;
            }
            else
            {
                err.Clear();
                errProviderEmail = false;
            }
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (utilidades.max_length(txtFullname, 4) || utilidades.nullField(txtFullname))
            {
                err.SetError(txtFullname, "Verifique lo siguiente:\n*El nombre de usuario debe tener almenos 4 caracteres.\n*El campo no debe estar vacio.");
                errProviderUsername = true;
              
            }
            else { 
                err.Clear();
                errProviderUsername = false ;

            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(!utilidades.validatePassword(txtPassword.Text, 8))
            {
                err.SetError(txtPassword, "*La contraseña debe tener al menos:\n*Una mayuscula\n*Una minuscula\n*Un numero\n*Un caracter especial.\n*Debe contener almenos 8 caracteres.\n*Por supuesto, no debe estar vacio.");
                errProviderCheckPass = false;
            }
            else { 
                err.Clear();
                errProviderCheckPass = true;
            
            }
        }
        private void txtVerifyPassword_Leave(object sender, EventArgs e)
        {
            if (!utilidades.validatePassword2(txtPassword.Text, txtPassword2.Text))
            {
                err.SetError(txtPassword2, "Verifique lo siguiente:*\nLas contraseñas no coinciden.\n*El campo esta vacio.");
                errProviderCheckPass = true;
            }
            else
            {
                err.Clear();
                errProviderCheckPass = false;
            }
        }
        private void cboRoles_Leave(object sender, EventArgs e)
        {
            if (cboRoles.Text == "")
            {
                err.SetError(cboRoles, "Debe elegir el rol del usuario a registrar.");
                errProviderCboRol = true;
            }
            else
            {
                err.Clear();
                errProviderCboRol = false;
            }
        }
    }
}
