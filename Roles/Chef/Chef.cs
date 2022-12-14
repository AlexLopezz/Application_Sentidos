using Application_Sentidos.Authentication;
using Application_Sentidos.Resources.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Sentidos.Roles.Chef
{
    public partial class Chef : Form
    {
        Utilidades utilidades = new Utilidades();
        public Chef(HttpUser user)
        {
            InitializeComponent();
            this.CenterToScreen();
            lblUser.Text = user.username;
        }


        private void bttMenu_Click(object sender, EventArgs e) => utilidades.openChildForm(new Menu(), panelContenedor);

        private void bttProductos_Click(object sender, EventArgs e) => utilidades.openChildForm(new ProductosCategorias(), panelContenedor);

        private void bttSalir_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
