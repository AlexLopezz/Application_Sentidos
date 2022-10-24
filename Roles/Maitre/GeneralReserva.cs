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

namespace Application_Sentidos.Resources.Mitre
{
    public partial class GeneralReserva : Form
    {
        HttpClient client = new HttpClient();
        public GeneralReserva()
        {
            InitializeComponent();
            cargarDgvReservation();
            loadColumnsDgvReservation();
        }

        private void bttRefrescar_Click(object sender, EventArgs e) => cargarDgvReservation();
        

        private void bttCreate_Reserva_Click_1(object sender, EventArgs e)
        {
            CreateReserva createReserva = new CreateReserva();
            createReserva.ShowDialog();
            cargarDgvReservation();
        }

        private async void bttCancelReserva_Click(object sender, EventArgs e)
        {
            string urlEliminar = "https://binarysystem.pythonanywhere.com/api/deleteReservation/?id=";

            DialogResult decision = MessageBox.Show($"¿Seguro que desea borrar esta reservacion ?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (decision == DialogResult.Yes)
            {
                int id = (int)dgvReserva.CurrentRow.Cells[0].Value;
                var httpResponse = await client.DeleteAsync(urlEliminar + id);
                if (httpResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                    cargarDgvReservation();
                }
                else { MessageBox.Show("Hubo un error, verifique ID."); }
            }
        }



        //Funcionalidades:
        private void emptyDgv() { dgvReserva.Rows.Clear(); }
        private void loadColumnsDgvReservation()
        {
            DataGridViewTextBoxColumn ID_RESERVA = new DataGridViewTextBoxColumn();
            ID_RESERVA.HeaderText = "ID";
            ID_RESERVA.Width = 50;
            ID_RESERVA.ReadOnly = true;
            DataGridViewTextBoxColumn USUARIO = new DataGridViewTextBoxColumn();
            USUARIO.HeaderText = "Usuario";
            USUARIO.Width = 200;
            USUARIO.ReadOnly = true;
            DataGridViewTextBoxColumn HORARIO = new DataGridViewTextBoxColumn();
            HORARIO.HeaderText = "Horario";
            HORARIO.Width = 200;
            HORARIO.ReadOnly = true;
            DataGridViewTextBoxColumn FECHA = new DataGridViewTextBoxColumn();
            FECHA.HeaderText = "Fecha";
            FECHA.Width = 200;
            FECHA.ReadOnly = true;
            DataGridViewTextBoxColumn MESAS_SELECCIONADAS = new DataGridViewTextBoxColumn();
            MESAS_SELECCIONADAS.HeaderText = "Mesas Seleccionadas";
            MESAS_SELECCIONADAS.Width = 200;
            MESAS_SELECCIONADAS.ReadOnly = true;

            dgvReserva.Columns.Add(ID_RESERVA);
            dgvReserva.Columns.Add(USUARIO);
            dgvReserva.Columns.Add(HORARIO);
            dgvReserva.Columns.Add(FECHA);
            dgvReserva.Columns.Add(MESAS_SELECCIONADAS);
        }
        public async void cargarDgvReservation()
        {
            emptyDgv();
            string urlBase = "https://binarysystem.pythonanywhere.com/api/allReservation/";
            var httpResponse = await client.GetAsync(urlBase);
            if (httpResponse.IsSuccessStatusCode)
            {
                var body = await httpResponse.Content.ReadAsStringAsync();
                var reservas = JsonSerializer.Deserialize<List<HttpGetReserva>>(body);
                if (reservas.Count == 0)
                {
                    MessageBox.Show("No hay reservaciones realizadas.");
                }
                else
                {
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
            }
            else
            {
                MessageBox.Show("No existe reservaciones, por el momento.");
                emptyDgv();
            }
        }

    }
}
