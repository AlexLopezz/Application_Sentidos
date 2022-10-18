using Application_Sentidos.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Sentidos.Resources.Mitre
{
    public partial class CreateReserva : Form
    {
        UI_RESERVA reserva = new UI_RESERVA();
        public CreateReserva()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            string URLBase = "http://localhost:8000/api/reservation/";
            HttpClient client = new HttpClient();

            var post = new HttpPostReserva()
            {
                user_id = Int32.Parse(txtUser.Text),
                phone = txtPhone.Text,
                schedule = txtSchedule.Text,
                date = txtDate.Text,
                selected_tables = txtSelected_tables.Text
            };

            var requestJSON = JsonSerializer.Serialize<HttpPostReserva>(post, options);
            HttpContent body = new StringContent(requestJSON, Encoding.UTF8, "application/json");
            var Response = await client.PostAsync(URLBase, body);

            if (Response.IsSuccessStatusCode)
            {
                MessageBox.Show("Reserva Realizada con exito!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error, reintente de nuevo");
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
