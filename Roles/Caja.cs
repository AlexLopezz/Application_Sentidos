﻿using System;
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

    public partial class Caja : Form
    {
        User userLogged;
        public Caja(User user)
        {
            InitializeComponent();
            userLogged = user;
        }
    }
}
