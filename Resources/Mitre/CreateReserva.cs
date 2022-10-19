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
        DateTime date = DateTime.Now;
        HttpClient httpClient = new HttpClient();



        UI_RESERVA reserva = new UI_RESERVA();
        public CreateReserva()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            string URLBase = "https://binarysystem.pythonanywhere.com/api/reservation/";
            HttpClient client = new HttpClient();

            var post = new HttpPostReserva()
            {
                user_id = Int32.Parse(txtBusquedaUser.Text),
                phone = txtPhone.Text,
                schedule = cboSchedule.Text,
                date = dateFecha.Text,
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
        private void setDateFecha()
        {
            dateFecha.MinDate = date;
            dateFecha.MaxDate = date.AddDays(30);
        }
        private void CreateReserva_Load(object sender, EventArgs e)
        {
            setDateFecha();
        }

        private async void bttBusquedaUser_Click(object sender, EventArgs e)
        {
            
            var URLBuscarUser = "https://binarysystem.pythonanywhere.com/api/filterForUser/?username=";
            if (string.IsNullOrEmpty(txtBusquedaUser.Text))
            {
                MessageBox.Show("Debe ingresar en la barra de busqueda el nombre de usuario.");
            }
            else
            {
                var httpResponse = await httpClient.GetAsync(URLBuscarUser+txtBusquedaUser.Text);
                if (httpResponse.IsSuccessStatusCode)
                {
                    emptyListFilter();
                    var body = await httpResponse.Content.ReadAsStringAsync();
                    var userFilter = JsonSerializer.Deserialize<List<GetUserFilter>>(body);
                    loadListFilter(userFilter);
                }
                else { MessageBox.Show("Ocurrio un error");  }
            }
        }
        private void loadListFilter(List<GetUserFilter> listUser)
        {
            foreach(var user in listUser) { listUserFilter.Items.Add(user.username); }
        }
        private void emptyListFilter() { listUserFilter.Items.Clear(); }

        private void bttSelectUser_Click(object sender, EventArgs e)
        {
            if (listUserFilter.Items.Count != 0)
            {
               txtUser.Text = listUserFilter.SelectedItem.ToString();
               emptyListFilter();
               txtBusquedaUser.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("No selecciono ningun usuario.");
            }
            
        }
    }
}
