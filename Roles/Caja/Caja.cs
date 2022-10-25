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

        private void TarjCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja_Tarjetas caja_Cobrar = new Caja_Tarjetas();
            caja_Cobrar.ShowDialog();
        }

        private void TarjDebitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja_Tarjetas caja_Cobrar = new Caja_Tarjetas();
            caja_Cobrar.ShowDialog();
        }

        private void EfectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caja_Efectivo caja_Efectivo = new Caja_Efectivo();
            caja_Efectivo.ShowDialog();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            //Actualizar el dataGV para ver las nuevas mesas cerradas
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CloseApp);
        }
        private void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();            
        }
    }
}
