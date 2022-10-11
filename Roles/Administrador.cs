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
    public partial class Administrador : Form
    {
        User userLogged;
        public Administrador(User user)
        {
            InitializeComponent();
            userLogged = user;
        }
    }
}
