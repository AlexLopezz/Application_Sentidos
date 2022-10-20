using Application_Sentidos.Resources.Objects;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Application_Sentidos.Resources
{
    public partial class MisDatos : Form
    {
        HttpUser userLogged;
        HttpClient client = new HttpClient();
        public MisDatos(HttpUser user)
        {
            InitializeComponent();
            userLogged = user;
            LoadDateUser();
        }

        private async void LoadDateUser()
        {
            string urlDateUser = "https://binarysystem.pythonanywhere.com/api/myUser/?id="+userLogged.id;
            var httpResponse = await client.GetAsync(urlDateUser);
            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                var user = JsonSerializer.Deserialize<HttpUser>(content);
                lblFullname.Text = user.fullname;
                lblUser.Text = user.username;
                lblUsername.Text = lblUser.Text;
                lblEmail.Text = user.email;
                lblDni.Text = user.dni;
                lblRole.Text = user.role.name;
            }
           
        }
    }
}
