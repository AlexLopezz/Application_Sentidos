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
    public partial class Mozo_Cobrar : Form
    {
        public Mozo_Cobrar()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //generar factura y confirmacion de pago
            MessageBox.Show("El pago ha sido exitoso", "Confirmacion de Pago");
        }
    }
}
