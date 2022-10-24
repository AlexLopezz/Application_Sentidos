using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Sentidos.Resources.Objects
{
    public class Utilidades
    {
        public Form activeForm;
        public void openChildForm(Form formHijo, Panel panelContenedor)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
    }
}
