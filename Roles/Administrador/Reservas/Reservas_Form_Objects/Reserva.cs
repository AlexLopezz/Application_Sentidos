using Application_Sentidos.Resources.Mitre;
using Application_Sentidos.Resources.Objects;
using Application_Sentidos.Resources.Reservas.Reservas_Form_Objects;
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


namespace Application_Sentidos.Resources
{
    public partial class Reserva : Form
    {
        CreateReserva reservasUtilidades = new CreateReserva();
        HttpClient httpClient = new HttpClient();
        public Reserva()
        {
            InitializeComponent();
            cargarDgvReservation();
            reservasUtilidades.setDateFecha(DateFecha);
        }

        public List<Button> buttonsTables()
        {
            List<Button> buttonList = new List<Button>();
            buttonList.Add(bttMesa1);
            buttonList.Add(bttMesa2);
            buttonList.Add(bttMesa3);
            buttonList.Add(bttMesa4);
            buttonList.Add(bttMesa5);
            buttonList.Add(bttMesa6);
            buttonList.Add(bttMesa7);
            buttonList.Add(bttMesa8);
            buttonList.Add(bttMesa9);
            buttonList.Add(bttMesa10);
            buttonList.Add(bttMesa11);
            buttonList.Add(bttMesa12);
            buttonList.Add(bttMesa13);
            buttonList.Add(bttMesa14);
            buttonList.Add(bttMesa15);
            buttonList.Add(bttMesa16);
            buttonList.Add(bttMesa17);
            buttonList.Add(bttMesa18);
            buttonList.Add(bttMesa19);
            buttonList.Add(bttMesa20);
            return buttonList;
        }

        private bool validateSchedule()
        {
            return string.IsNullOrEmpty(cboSchedule.Text);
        }

       

        private void loadTables(List<GetSelectedTable> list_TableSelected, List<Button> buttons)
        {
            int mesasReservadas = 0;

            foreach (var tables in list_TableSelected)
            {
                foreach (var t in tables.selected_tables)
                {

                    foreach (var b in buttons)
                    {
                        if (t.number_mesa.ToString() == b.Text)
                        {
                            b.BackColor = Color.Red;
                            mesasReservadas++;
                        }
                    }
                }
            }
            loadLblResultados(buttonsTables(), mesasReservadas);
        }

        private async void bttShowReserva_Click(object sender, EventArgs e)
        {
            if (validateSchedule())
            {
                MessageBox.Show("Debe ingresar un horario para poder ver las mesas reservadas.");
            }
            else
            {
                var httpResponse = await httpClient.GetAsync("https://binarysystem.pythonanywhere.com/api/getReservation/?schedule=" + cboSchedule.Text + "&date=" + DateFecha.Text);
                if (httpResponse.IsSuccessStatusCode)
                {
                    reservasUtilidades.load_ButtonsLime(buttonsTables());
                    var body = await httpResponse.Content.ReadAsStringAsync();
                    try
                    {
                        var list_TableSelected = JsonSerializer.Deserialize<List<GetSelectedTable>>(body);

                        loadTables(list_TableSelected, buttonsTables());
                    }
                    catch (Exception)
                    {
                        reservasUtilidades.load_ButtonsLime(buttonsTables());
                    }
                }
                
            }
            
        }
        private void loadLblResultados(List<Button> botones, int mesas)
        {
            lblResultadoReservadas.Text = mesas.ToString();
            lblResultadoDisponibles.Text = (botones.Count - mesas).ToString();
        }
        public async void cargarDgvReservation()
        {
            
            emptyDgv();
            string urlBase = "https://binarysystem.pythonanywhere.com/api/allReservation/";
            var httpResponse = await httpClient.GetAsync(urlBase);
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
                        dgvReserva.Rows.Add(r.id, mesas, r.date, r.schedule, r.user_id);
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
        private void emptyDgv() { dgvReserva.Rows.Clear(); }
        private void emptyFieldsTXT() 
        {
            cboSchedule.Text = String.Empty;
            reservasUtilidades.load_ButtonsLime(buttonsTables());
        }
        private void bttRefresh_Click(object sender, EventArgs e)
        {
            emptyFieldsTXT();
            reservasUtilidades.load_ButtonsStandard(buttonsTables());
            cargarDgvReservation();
        }

        private void bttAddReserva_Click(object sender, EventArgs e)
        {
            CreateReserva createReserva = new CreateReserva();
            createReserva.ShowDialog();
            cargarDgvReservation();
        }

        private async void bttDeleteReserva_Click(object sender, EventArgs e)
        {
            string urlEliminar = "https://binarysystem.pythonanywhere.com/api/deleteReservation/?id=";

            DialogResult decision = MessageBox.Show($"¿Seguro que desea borrar esta reservacion ?", "Salir",
                MessageBoxButtons.YesNoCancel);
            if (decision == DialogResult.Yes)
            {
                int id = (int)dgvReserva.CurrentRow.Cells[0].Value;
                var httpResponse = await httpClient.DeleteAsync(urlEliminar + id);
                if (httpResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario eliminado correctamente.");
                    cargarDgvReservation();
                }
                else { MessageBox.Show("Hubo un error, verifique ID."); }
            }
        }
    }
}
