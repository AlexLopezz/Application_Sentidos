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
using Application_Sentidos.Resources.Objects;
using System.Security.Policy;

namespace Application_Sentidos.Resources.Mitre
{
    public partial class GeneralReserva : Form
    {
        string URLBase = "https://binarysystem.pythonanywhere.com";
        HttpClient client = new HttpClient();
        public GeneralReserva()
        {
            InitializeComponent();
            load_dgv();
        }

        private void bttRefrescar_Click(object sender, EventArgs e) => load_dgv();


        private void bttCreate_Reserva_Click_1(object sender, EventArgs e)
        {
            CreateReserva createReserva = new CreateReserva();
            createReserva.ShowDialog();
            load_dgv();
        }

        private void load_dgv()
        {
            cargarDgvReservas(URLBase + "/api/reservationPay/");
            cargarDgvReservasEspera(URLBase + "/api/reservationWait/");
        }
        private async void bttCancelReserva_Click(object sender, EventArgs e)
        {
            string urlEliminar = URLBase + "/api/deleteReservation/?id=";
            if (dgvReserva.Rows.Count != 0 || dgvReserva.CurrentCell != null)
            {
                DialogResult decision = MessageBox.Show($"¿Seguro que desea borrar esta reservacion ?", "Salir",
                    MessageBoxButtons.YesNoCancel);
                if (decision == DialogResult.Yes)
                {
                    int id = (int)dgvReserva.CurrentRow.Cells[0].Value;
                    var httpResponse = await client.DeleteAsync(urlEliminar + id);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Reserva eliminada correctamente.");
                        load_dgv();
                    }
                    else { MessageBox.Show("Hubo un error, verifique ID."); }
                }
            }
            else { MessageBox.Show("Por el momento no hay reservas disponibles para eliminar."); }
        }

        //Funcionalidades:
        private void emptyDgv(DataGridView dgv) { dgv.Rows.Clear(); }

        public async void cargarDgvReservas(string URL)
        {
            emptyDgv(dgvReserva);
            var httpResponse = await client.GetAsync(URL);
            if (httpResponse.IsSuccessStatusCode)
            {
                var body = await httpResponse.Content.ReadAsStringAsync();
                var reservas = JsonSerializer.Deserialize<List<HttpGetReserva>>(body);
                
                foreach (var r in reservas)
                {
                    string mesas = "";
                    foreach (var mesa in r.selected_tables)
                    {
                        mesas += mesa.number_mesa.ToString() + ",";
                    }
                    mesas = mesas.Remove(mesas.Length - 1);
                    dgvReserva.Rows.Add(r.id, r.user_id, r.schedule, r.date, mesas);
                    mesas = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("No hay reservas disponibles en este momento.","Reservas disponibles.");
                emptyDgv(dgvReserva);
            }
        }

        public async void cargarDgvReservasEspera(string URL)
        {
            emptyDgv(dgvReservasEspera);
            var httpResponse = await client.GetAsync(URL);
            if (httpResponse.IsSuccessStatusCode)
            {
                var body = await httpResponse.Content.ReadAsStringAsync();
                var reservas = JsonSerializer.Deserialize<List<HttpGetReserva>>(body);

                foreach (var r in reservas)
                {
                    string mesas = "";
                    foreach (var mesa in r.selected_tables)
                    {
                        mesas += mesa.number_mesa.ToString() + ",";
                    }
                    mesas = mesas.Remove(mesas.Length - 1);
                    dgvReservasEspera.Rows.Add(r.id, mesas, r.date, r.schedule, r.user_id);
                    mesas = string.Empty;
                }
            }
        }

        private async void bttReservar_Click(object sender, EventArgs e)
        {
            if (dgvReservasEspera.CurrentCell != null)
            {
                int id = Int32.Parse(dgvReservasEspera.CurrentRow.Cells[0].Value.ToString());
                PutReservaPaid paid = new PutReservaPaid()
                {
                    paid = true
                };

                var data = JsonSerializer.Serialize<PutReservaPaid>(paid);
                HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");

                var httpResponse = await client.PutAsync(URLBase + "/api/paidReservation/?id="+id, content);
                if (httpResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Reserva agregada con exito.", "Success!");
                }
            }
            else { MessageBox.Show("Debe seleccionar una reserva.", "Seleccione la reserva");  }
        }

        private async void bttEliminar_Click(object sender, EventArgs e)
        {
            string urlEliminar = URLBase + "/api/deleteReservation/?id=";
            if (dgvReserva.Rows.Count != 0 || dgvReserva.CurrentCell != null)
            {
                DialogResult decision = MessageBox.Show($"¿Seguro que desea borrar esta reservacion ?", "Salir",
                    MessageBoxButtons.YesNoCancel);
                if (decision == DialogResult.Yes)
                {
                    int id = (int)dgvReservasEspera.CurrentRow.Cells[0].Value;
                    var httpResponse = await client.DeleteAsync(urlEliminar + id);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Reserva eliminada correctamente.");
                        load_dgv();
                    }
                    else { MessageBox.Show("Hubo un error, verifique ID."); }
                }
            }
            else { MessageBox.Show("Por el momento no hay reservas disponibles para eliminar."); }
        }
    }
}
