using Application_Sentidos.Resources.Administrador.Modificar_Form_Objects;
using Application_Sentidos.Resources.Administrador.Registro_Form_Objects;
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


namespace Application_Sentidos.Resources.Administrador
{
    public partial class Modificar : Form
    {
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
            txtPassword.Text = dgvForm.CurrentRow.Cells[6].Value.ToString();
            cboRoles.Text = dgvForm.CurrentRow.Cells[5].Value.ToString();
        }
        private bool validateFields()
        {
        return string.IsNullOrEmpty(txtFullname.Text) && string.IsNullOrEmpty(txtDNI.Text) && string.IsNullOrEmpty(txtEmail.Text)
            && string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text) && string.IsNullOrEmpty(cboRoles.Text);
        }
        private async void bttModificar_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true }; //The options ignore case sensitive values.
            string urlBase = "http://localhost:8000/api/modifyUser/";
            if (validateFields())
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                var Post = new PostModify()
                {
                    id = Int32.Parse(dgvFormParent.CurrentRow.Cells[0].Value.ToString()),
                    username = txtUsername.Text,
                    email = txtEmail.Text,
                    fullname = txtFullname.Text,
                    dni = Int32.Parse(txtDNI.Text),
                    password = txtPassword.Text,
                    role = utilidades_Registro.select_role(cboRoles.Text)
                };

                    var requestJSON = JsonSerializer.Serialize<PostModify>(Post, options);
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
    }
}
