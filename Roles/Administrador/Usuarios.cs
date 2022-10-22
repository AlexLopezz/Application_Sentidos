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

namespace Application_Sentidos.Resources.Administrador
{
    public partial class Usuarios : Form
    {
        HttpClient httpClient = new HttpClient();
        public Usuarios()
        {
            InitializeComponent();
        }

        private async void bttEliminar_Click(object sender, EventArgs e)
        {

            string urlEliminar = "https://binarysystem.pythonanywhere.com/api/deleteUser/?id=";
            var user_username = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();

            DialogResult decision = MessageBox.Show($"¿Seguro que desea borrar al usuario {user_username} ?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (decision == DialogResult.Yes)
            {
                int id = (int)dgvUsuarios.CurrentRow.Cells[0].Value;
                var httpResponse = await httpClient.DeleteAsync(urlEliminar + id);
                if (httpResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                    checkRB_URL();
                }
                else { MessageBox.Show("Hubo un error, verifique ID."); }
            }
        }
        
        private void bttRegistrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
            checkRB_URL();
        }

        private void bttModificar_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar(new Registro(), dgvUsuarios);
            modificar.ShowDialog();
            checkRB_URL();
        }

        private void checkRB_URL()
        {
            if (rb_allUser.Checked == true)
            {
                cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allUser/");
            }
            else if (rb_Mitre.Checked == true)
            {
                cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allMitre/");
            }
            else if (rb_Caja.Checked==true)
            {
                cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allCaja/");
            }
            else if (rb_Mozo.Checked==true)
            {
                cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allMozo/");
            }
            else emptyDgv();
        }

        private void rb_allUser_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_allUser.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allUser/"); }
        }

        private void rb_Mozo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Mozo.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allMozo/"); }
        }

        private void rb_Mitre_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Mitre.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allMitre/"); }
        }

        private void rb_Caja_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Caja.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allCaja/"); }
        }
        private void rb_None_CheckedChanged(object sender, EventArgs e) => emptyDgv();
       
        
        //Utilidades:
        private void emptyDgv() { dgvUsuarios.DataSource = null; }
        private string rol_Select(int rol)
        {
            string str_rol = "";

            switch (rol)
            {
                case 1:
                    str_rol = "Administrador";
                    break;
                case 2:
                    str_rol = "Mitre";
                    break;
                case 3:
                    str_rol = "Mozo";
                    break;
                case 4:
                    str_rol = "Caja";
                    break;
                default:
                    str_rol = "Usuario";
                    break;
            }
            return str_rol;
        }
        public async void cargarDgvUsuario(string urlBase)
        {
            var httpResponse = await httpClient.GetAsync(urlBase);
            if (httpResponse.IsSuccessStatusCode)
            {
                var body = await httpResponse.Content.ReadAsStringAsync();
                var user = JsonSerializer.Deserialize<List<HttpUser>>(body);
                dgvUsuarios.DataSource = user;
            }
            else
            {
                MessageBox.Show("No hay ningun usuario en este Rol.");
                emptyDgv();
            }

        }
    }

}
