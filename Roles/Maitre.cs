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

namespace Application_Sentidos.Roles
{
    public partial class Maitre : Form
    {
        
        User userLogged;
        public Maitre(User user)
        {
            InitializeComponent();
            userLogged = user;
            lblUser.Text = user.username.ToUpper();
        }

        private void realizarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        private void bttReservas_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new UI_RESERVA());
        }
    }
}
