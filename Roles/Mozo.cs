using Application_Sentidos.Resources.Objects;

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

        private void button3_Click(object sender, EventArgs e)
        {
            Caja_Cobrar mozo_Cobrar = new Caja_Cobrar();
            mozo_Cobrar.Show();
        }

        private void btnActualizarPedidos_Click(object sender, EventArgs e)
        {
            //getApi.get(parametros de todos los pedidos)
        }

        private void btnConfirmarPedido_Click(object sender, EventArgs e)
        {
            //deletear el pedido de la bd con el id o lo que sea, jeje
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            //enviar el pedido del mozo a la bd para generar la factura por caja
        }
    }
}
