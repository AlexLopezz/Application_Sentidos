using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Sentidos.Resources.Objects;
using Application_Sentidos.Resources.Mitre;
using Application_Sentidos.Authentication;
using Application_Sentidos.Resources;

namespace Application_Sentidos.Roles
{
    public partial class Maitre : Form
    {
        private Form activeForm = null;
        HttpUser userLogged;
        public Maitre(HttpUser user)
        {
            InitializeComponent();
            userLogged = user;
            lblUser.Text = user.username.ToUpper();
        }
        private void bttReservas_Click(object sender, EventArgs e)
        {
            openChildForm(new GeneralReserva());
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
            
        }
        private void Maitre_Load(object sender, EventArgs e) => this.CenterToScreen();
        private void openChildForm(Form formHijo)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        private void bttMisDatos_Click(object sender, EventArgs e)
        {
            openChildForm(new MisDatos(userLogged));
        }
    }
}
       
    
