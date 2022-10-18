using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Sentidos.Resources.Mitre
{
    public partial class UI_RESERVA : Form
    {
        public UI_RESERVA()
        {
            InitializeComponent();
            this.CenterToScreen();
            cargarDgvReservation();

        }
        public async void cargarDgvReservation()
        {
            string urlBase = "http://localhost:8000/api/allReservation/";
            HttpClient client = new HttpClient();
            var httpResponse = await client.GetAsync(urlBase);
            if (httpResponse.IsSuccessStatusCode)
            {
                var body = await httpResponse.Content.ReadAsStringAsync();
                var reservas = JsonSerializer.Deserialize<List<HttpGetReserva>>(body);
                if(reservas.Count == 0)
                {
                    MessageBox.Show("No hay reservaciones realizadas.");
                }
                else { dgvReserva.DataSource = reservas; }
                                                                                                     
            }
            else
            {
                MessageBox.Show("No hay ningun usuario en este Rol.");
                emptyDgv();
            }
        }
        private void emptyDgv() { dgvReserva.DataSource = null; }

        private void bttCreate_Reserva_Click(object sender, EventArgs e)
        {
            CreateReserva createReserva = new CreateReserva();
            createReserva.ShowDialog();
            cargarDgvReservation();
        }
    }
}
