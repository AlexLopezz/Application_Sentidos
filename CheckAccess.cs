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
namespace Application_Sentidos
{
    public partial class CheckAccess : Form
    {
        private string CodeAccess()
        {
            return "BinarySystem2022";
        }
        public CheckAccess()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private bool checkField()
        {
            return string.IsNullOrEmpty(txtCodeAccess.Text);
        }
        private void bttCodeAccess_Click(object sender, EventArgs e)
        {
            if (checkField())
            {
                MessageBox.Show("Por favor, debe ingresar el codigo de seguridad.");
            }
            
            if (txtCodeAccess.Text.Equals(CodeAccess()))
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
            }
            else { MessageBox.Show("Codigo de seguridad incorrecto."); }

        }

    }
}
