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
    public partial class Caja_Tarjetas : Form
    {
        public Caja_Tarjetas(int numero)
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //generar factura y confirmacion de pago
            string urlFactura = "https://binarysystem.pythonanywhere.com/api/checking_invoice/";//para la factura
            MessageBox.Show("El pago ha sido exitoso", "Confirmacion de Pago");
        }

        private void txtBoxDireccion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
