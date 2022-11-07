using Application_Sentidos.Resources.Objects;
using Application_Sentidos.Roles.AdministradorFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Application_Sentidos.Resources.Administrador
{

    public partial class Modificar : Form
    {
        ErrorProvider err = new ErrorProvider();
        Utilidades utilidades = new Utilidades();
        bool errProviderFullname = false, errProviderUsername = false, errProviderEmail = false, errProviderDni = false, errProviderCboRol = false;
        Registro utilidades_Registro;
        DataGridView dgvFormParent;
        public Modificar(Registro registro, DataGridView dgv)
        {
            InitializeComponent();
            utilidades_Registro = registro;
            cargarCampos(dgvFormParent = dgv);
            this.CenterToScreen();
        }

     

        private void cargarCampos(DataGridView dgvForm)
        {
            txtFullname.Text = dgvForm.CurrentRow.Cells[1].Value.ToString();
            txtUsername.Text = dgvForm.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvForm.CurrentRow.Cells[3].Value.ToString();
            txtDNI.Text = dgvForm.CurrentRow.Cells[4].Value.ToString();
            cboRoles.Text = dgvForm.CurrentRow.Cells[5].Value.ToString();
        }

        private async void bttModificar_Click(object sender, EventArgs e)
        {
            string urlBase = "https://binarysystem.pythonanywhere.com/api/modifyUser/";
            HttpClient httpClient = new HttpClient();
            JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }; //The options ignore case sensitive values.
            
            if (errProviderFullname || errProviderEmail || errProviderCboRol || errProviderDni || errProviderUsername)
            {
                MessageBox.Show("Debe completar todos los campos. Verifique las validaciones.");
            }
            else
            {
                PutModify Put = new PutModify()
                {
                    id = Int32.Parse(dgvFormParent.CurrentRow.Cells[0].Value.ToString()),
                    username = txtUsername.Text,
                    email = txtEmail.Text,
                    fullname = txtFullname.Text,
                    dni =txtDNI.Text,
                    role = utilidades_Registro.select_role(cboRoles.Text)
                };

                    var requestJSON = JsonSerializer.Serialize<PutModify>(Put, options);
                    HttpContent content = new StringContent(requestJSON, Encoding.UTF8, "application/json");

                    var httpResponse = await httpClient.PutAsync(urlBase, content);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("¡Usuario modificado con exito!");
                        this.Close();
                    }
                    else { MessageBox.Show("Hubo un error. Verifique sus datos"); };
            }
        }

        //Validaciones de campos: 
        private void txtFullname_Leave(object sender, EventArgs e)
        {
            if (utilidades.nullField(txtFullname))
            {
                err.SetError(txtFullname, "*El campo no debe estar vacio.");
                errProviderFullname = true;
            }
            else
            {
                err.Clear();
                errProviderFullname = false;
            }
        }
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
            else
            {
                err.SetError(txtDNI, "El DNI, como usted sabe, debe contener 8 digitos.");
                errProviderDni = true;
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
            else
            {
                err.Clear();
                errProviderUsername = false;

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
