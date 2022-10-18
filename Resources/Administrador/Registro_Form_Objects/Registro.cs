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
using Application_Sentidos.Resources.Administrador.Registro_Form_Objects;
using Application_Sentidos.Resources.Administrador;

namespace Application_Sentidos.Resources.Administrador
{
    public partial class Registro : Form
    {
        string urlBase = "http://localhost:8000/api/register/";
        public Registro()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        public int select_role(string txtRole)
        {
            int fk_role = 0;
            switch (txtRole)
            {
                case "Administrador":
                    fk_role = 1;
                    break;
                case "Mitre":
                    fk_role=2;
                    break;
                case "Mozo":
                    fk_role = 3;
                    break;
                case "Caja":
                    fk_role = 4;
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
                    var Post = new PostRegister()
                    {
                        username = txtUsername.Text,
                        email = txtEmail.Text,
                        fullname = txtFullname.Text,
                        dni = Int32.Parse(txtDNI.Text),
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
                    else { MessageBox.Show("Hubo un error. Verifique sus datos"); }
                }
                else
                {
                    MessageBox.Show("Contraseñas no coinciden.");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}