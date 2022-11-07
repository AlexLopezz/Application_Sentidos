using Application_Sentidos.Resources.Objects;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Application_Sentidos.Resources.Administrador
{
    public partial class Usuarios : Form
    {
        HttpClient httpClient = new HttpClient();
        public Usuarios()
        {
            InitializeComponent();
        }

        //Botones: REGISTRAR - MODIFICAR - ELIMINAR Usuarios - Sentidos:
        private void bttRegistrar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro(); 
            registro.ShowDialog();
            checkRB_URL();
        }
        private void bttModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentCell != null)
            {
                Modificar modificar = new Modificar(new Registro(), dgvUsuarios);
                modificar.ShowDialog();
                checkRB_URL();
            }
            else
            {
                MessageBox.Show("Debe especificar el usuario al que desea modificar.");
            }
        }
        private async void bttEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentCell != null)
            {
                string urlEliminar = "https://binarysystem.pythonanywhere.com/api/deleteUser/?id=";
                var user_username = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();

                DialogResult decision = MessageBox.Show($"¿Seguro que desea borrar al usuario {user_username} ?", "Salir",
                    MessageBoxButtons.YesNoCancel);
                if (decision == DialogResult.Yes)
                {
                    int id = (int)dgvUsuarios.CurrentRow.Cells[0].Value;
                    var httpResponse = await httpClient.DeleteAsync(urlEliminar + id);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.");
                        checkRB_URL();
                    }
                    else { MessageBox.Show("Hubo un error, verifique ID."); }
                }
            }
            else { MessageBox.Show("Debe especificar el usuario al que desea modificar."); }
        }



        //RadioButton: Filtrado por roles:
        private void rb_Chef_CheckedChanged(object sender, EventArgs e) //Filtro por Chef - Sentidos.
        {
            if (rb_Chef.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allChef/"); }
        }
        private void rb_Client_CheckedChanged(object sender, EventArgs e) //Filtro por Clientes - Sentidos.
        {
            if (rb_Client.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allClient/"); }
        }
        private void rb_Caja_CheckedChanged(object sender, EventArgs e) //Filtro por Caja - Sentidos.
        {
            if (rb_Caja.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allCaja/"); }
        }
        private void rb_Mozo_CheckedChanged(object sender, EventArgs e) //Filtro por Mozo - Sentidos.
        {
            if (rb_Mozo.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allMozo/"); }
        }
        private void rb_allUser_CheckedChanged(object sender, EventArgs e) //Filtrado de todos los usuarios registrados en la BD.
        {
            if (rb_allUser.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allUser/"); }
        }
        private void rb_Mitre_CheckedChanged(object sender, EventArgs e) //Filtro por Maitre - Sentidos.
        {
            if (rb_Mitre.Checked == true) { cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allMitre/"); }
        }



        //Utilidades:
        private void checkRB_URL()
        {
            if (rb_allUser.Checked == true)
            {
                cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allUser/");
            }
            else if (rb_Mitre.Checked == true)
            {
                cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allMitre/");
            }
            else if (rb_Caja.Checked == true)
            {
                cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allCaja/");
            }
            else if (rb_Mozo.Checked == true)
            {
                cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allMozo/");
            }
            else if (rb_Client.Checked == true)
            {
                cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allClient/");
            }
            else if (rb_Chef.Checked == true)
            {
                cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/allChef/");
            }
            else emptyDgv();
        }
        public async void cargarDgvUsuario(string urlBase)
        {
            emptyDgv();
            var httpResponse = await httpClient.GetAsync(urlBase);
            if (httpResponse.IsSuccessStatusCode)
            {
                var body = await httpResponse.Content.ReadAsStringAsync();
                var usuario = JsonSerializer.Deserialize<List<HttpUser>>(body);
                foreach (var user in usuario)
                {
                    dgvUsuarios.Rows.Add(user.id, user.username, user.fullname, user.email, user.dni, user.role);
                }
            }
            else
            {
                MessageBox.Show("No hay ningun usuario en este Rol.");
                emptyDgv();
            }

        }
        private void bttBuscar_Click(object sender, EventArgs e)
        {
            cargarDgvUsuario("https://binarysystem.pythonanywhere.com/api/filterForUsername/?username=" + txtSearchUser.Text);
        }
        private void emptyDgv() { dgvUsuarios.Rows.Clear(); }
        private void rb_None_CheckedChanged(object sender, EventArgs e) => emptyDgv(); //RadioButton por defecto en la vista Usuarios.
    }

}
