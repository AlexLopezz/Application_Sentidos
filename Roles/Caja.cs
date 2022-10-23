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

namespace Application_Sentidos.Roles
{

    public partial class Caja : Form
    {
        HttpUser userLogged;
        public Caja(HttpUser user)
        {
            InitializeComponent();
            userLogged = user;
        }

        private void tarjCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja_Tarjetas caja_Cobrar = new Caja_Tarjetas();
            caja_Cobrar.Show();
        }

        private void tarjDebitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja_Tarjetas caja_Cobrar = new Caja_Tarjetas();
            caja_Cobrar.Show();
        }

        private void efectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja_Efectivo caja_Efectivo = new Caja_Efectivo();
            caja_Efectivo.Show();
        }
    }
}
