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
using Application_Sentidos.Authentication;
using Application_Sentidos.Resources;

namespace Application_Sentidos.Roles
{
    public partial class Maitre : Form
    {
        Utilidades utilidades = new Utilidades();
        private Form activeForm = null;
        HttpUser userLogged;
        public Maitre(HttpUser user)
        {
            InitializeComponent();
            userLogged = user;
            lblUser.Text = user.username.ToUpper();
        }
        private void bttReservas_Click(object sender, EventArgs e)
        {
            utilidades.openChildForm(new GeneralReserva(), panelContenedor);
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
            
        }
<<<<<<< HEAD:Roles/Mitre/Maitre.cs
        private void Maitre_Load(object sender, EventArgs e) => this.CenterToScreen();
=======
        
        private void openChildForm(Form formHijo)
        {
            if (activeForm != null)
                activeForm.Close();
            
            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
>>>>>>> 7557749be28cac5659656df135fab99b3c7df4da:Roles/Maitre/Maitre.cs

        private void bttMisDatos_Click(object sender, EventArgs e)
        {
            utilidades.openChildForm(new MisDatos(userLogged), panelContenedor);
        }
        private void Maitre_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(closeApp);
        }
        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
       
    
