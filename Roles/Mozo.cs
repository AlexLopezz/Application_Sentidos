﻿using Application_Sentidos.Resources.Objects;

namespace Application_Sentidos.Roles
{
    public partial class Mozo : Form
    {
        HttpUser userLogged;
        public Mozo(HttpUser user)
        {
            InitializeComponent();
            userLogged = user;
        }
        private void btnModificarPedido_Click(object sender, EventArgs e)
        {
            //Modifica el pedido seleccionado de la mesa x
        }
        private void btnCerrarMesa_Click(object sender, EventArgs e)
        {
            int numMesa = cboBoxMesas.SelectedIndex + 1;
            //generar el post de la mesa para que pase a caja para ser abonado
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //agregar elemento seleccionado de la lista de items del menu
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //deletear el pedido de la bd con el id o lo que sea, jeje
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            //enviar el pedido del mozo a la bd para generar la factura por caja
        }
    }
}
