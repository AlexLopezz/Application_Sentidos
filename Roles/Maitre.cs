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
    public partial class Maitre : Form
    {
        User userLogged;
        public Maitre(User user)
        {
            InitializeComponent();
            userLogged = user;
        }
    }
}
