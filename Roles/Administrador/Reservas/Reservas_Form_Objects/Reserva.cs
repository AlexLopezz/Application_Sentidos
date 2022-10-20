using Application_Sentidos.Resources.Reservas.Reservas_Form_Objects;
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


namespace Application_Sentidos.Resources
{
    public partial class Reserva : Form
    {
        
       
        
        string urlObtainAllReservation = "http://localhost:8000/api/allReservation/"; 
        public Reserva()
        {
            InitializeComponent();
            getReservationToday();
        }



        private async void getReservationToday()
        {
            var fechaActual = new DateTime(2022,10,15);
            string urlObtainReservationToday = "http://localhost:8000/api/filterForDate/?date=";
            HttpClient httpClient = new HttpClient();

            var Response = await httpClient.GetAsync(urlObtainReservationToday + fechaActual.ToString("yyyy-MM-dd"));

            if (Response.IsSuccessStatusCode)
            {
                var body = await Response.Content.ReadAsStringAsync(); //Leemos/Obtenemos el JSON
                var reservation = JsonSerializer.Deserialize<List<GetReserva>>(body); //Deserializo JSON a Objeto.
                lblCantidadReservas.Text = reservation.Count.ToString();
            }
            else
            {
                MessageBox.Show("Hubo un error al mostrar las reservas del dia de hoy.");
            }
            

        }
    }
}
