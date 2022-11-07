using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public bool onlyNumbers(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if(char.IsControl(e.KeyChar)){
                e.Handled = false;
                return true;
            }else
            {
                e.Handled = true;
                return false;
            }
        }
        public bool max_length(TextBox txt, int length)
        {
            if(txt.Text.Length < length)
            {
                txt.Focus();
                return true;
            }
            else { return false; }
        }
        public bool nullField(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                txt.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool validarEmail(string txtCorreo)
        {
            return txtCorreo != null && Regex.IsMatch(txtCorreo,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public bool validatePassword(string password, int length)
        {
            bool mayus = false, minus = false, number = false, especial = false;

            if (password.Length >= length)
            {
                foreach (var p in password)
                {
                    if (char.IsUpper(p)) { mayus = true; }
                    if (char.IsLower(p)) { minus = true; }
                    if (char.IsDigit(p)) { number = true; }
                    else { especial = true; }
                }
                if (mayus && minus && number && especial)
                {
                    return true;
                }
                else { return false; }
            }else
            {
                return false;
            }
        }

        public bool validatePassword2(string password, string password2)
        {
            if (password2.Equals(password))
            {
                return true;
            }
            else { return false; }
        }
    }
}
