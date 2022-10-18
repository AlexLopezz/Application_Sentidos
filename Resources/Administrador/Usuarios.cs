﻿using System;
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
        string urlEliminar = "http://localhost:8000/api/deleteUser/?id=";

        HttpClient httpClient = new HttpClient();
        public Usuarios()
        {
            InitializeComponent();
        }

        public async void cargarDgvUsuario(string urlBase)
        {
            var httpResponse = await httpClient.GetAsync(urlBase);
            if (httpResponse.IsSuccessStatusCode)
            {
                var body = await httpResponse.Content.ReadAsStringAsync();
                var user = JsonSerializer.Deserialize<List<User>>(body);
                dgvUsuarios.DataSource = user;
            }
            else
            {
                MessageBox.Show("No hay ningun usuario en este Rol.");
                emptyDgv();
            }

        }

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

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Eliminar usuario
        private async void bttEliminar_Click(object sender, EventArgs e)
        {
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

        }

        private void bttModificar_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar(new Registro(), dgvUsuarios);
            modificar.ShowDialog();
        }

        private void checkRB_URL()
        {
            if (rb_allUser.Checked == true)
            {
                cargarDgvUsuario("http://localhost:8000/api/allUser/");
            }
            else if (rb_Mitre.Checked == true)
            {
                cargarDgvUsuario("http://localhost:8000/api/allUser/");
            }
            else if (rb_Caja.Checked==true)
            {
                cargarDgvUsuario("http://localhost:8000/api/allCaja/");
            }
            else if (rb_Mozo.Checked==true)
            {
                cargarDgvUsuario("http://localhost:8000/api/allMozo/");
            }
            else emptyDgv();
        }

        private void rb_allUser_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_allUser.Checked == true) { cargarDgvUsuario("http://localhost:8000/api/allUser/"); }
        }

        private void rb_Mozo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Mozo.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allMozo/"); }
        }

        private void rb_Mitre_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Mitre.Checked == true) { cargarDgvUsuario("http://localhost:8000/api/allMitre/"); }
        }

        private void rb_Caja_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Caja.Checked == true) { cargarDgvUsuario("http://localhost:8000/api/allCaja/"); }
        }

        private void rb_None_CheckedChanged(object sender, EventArgs e) => emptyDgv();
        private void emptyDgv() { dgvUsuarios.DataSource = null; }
    }
}
