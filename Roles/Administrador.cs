using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Sentidos.Authentication;
using Application_Sentidos.Resources.Objects;
using Application_Sentidos.Resources.Administrador;
using Application_Sentidos.Resources;

namespace Application_Sentidos.Roles
{
    public partial class Administrador : Form
    {
        User userLogged;
        public Administrador(User user)
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

        private void picMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuLateral.Width == 266)
                panelMenuLateral.Width = 74;
            else
                panelMenuLateral.Width = 266;
        }

        private void AbrirFormPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            var fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void bttUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Usuarios());
        }

        private void bttReservas_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Reserva());
        }
    }
}
