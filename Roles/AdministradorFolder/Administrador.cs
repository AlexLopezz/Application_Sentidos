using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Sentidos.Roles.AdministradorFolder;
using Application_Sentidos.Authentication;
using Application_Sentidos.Resources.Objects;
using Application_Sentidos.Resources.Administrador;
using Application_Sentidos.Resources;

namespace Application_Sentidos.Roles
{
    public partial class Administrador : Form
    {
        Utilidades utilidades = new Utilidades();
        HttpUser userLogged;
        public Administrador(HttpUser user)
        {
            InitializeComponent();
            this.CenterToScreen();
            userLogged = user;
            lblUser.Text = "@"+userLogged.username;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new Login();
            this.Hide();
            login.ShowDialog();
        }
        private void bttUsuarios_Click(object sender, EventArgs e)=> utilidades.openChildForm(new Usuarios(), panelContenedor);

        private void bttReservas_Click(object sender, EventArgs e) => utilidades.openChildForm(new Reserva(), panelContenedor);

        private void bttSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(closeApp);
        }
        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttConsultas_Click(object sender, EventArgs e) => utilidades.openChildForm(new ContactForm(), panelContenedor);

        private void bttFacturas_Click(object sender, EventArgs e) => utilidades.openChildForm(new Factura(), panelContenedor);

    }
}
