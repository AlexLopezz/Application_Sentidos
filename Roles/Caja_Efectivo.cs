using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Sentidos.Roles
{
    public partial class Caja_Efectivo : Form
    {
        public Caja_Efectivo()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //Imprimir ticket o factura
            MessageBox.Show("Gracias por su compra", "EFECTIVO");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
