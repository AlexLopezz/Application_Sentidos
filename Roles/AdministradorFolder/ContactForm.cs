using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Application_Sentidos.Roles.AdministradorFolder
{
    public partial class ContactForm : Form
    {
        List<Button> bttAttention = new List<Button>();
        List<Button> bttPlace = new List<Button>();
        List<Button> bttFood = new List<Button>();
        List<Button> bttPrice = new List<Button>();


        HttpClient httpClient = new HttpClient();
        public ContactForm()
        {
            InitializeComponent();
            loadDgvContact();
            loadStars();
            loadAverage();
        }
        private void loadStars() {
            bttAttention.Add(Star1_Attention);
            bttAttention.Add(Star2_Attention);
            bttAttention.Add(Star3_Attention);
            bttAttention.Add(Star4_Attention);
            bttAttention.Add(Star5_Attention);

            bttPlace.Add(Star1_Place);
            bttPlace.Add(Star2_Place);
            bttPlace.Add(Star3_Place);
            bttPlace.Add(Star4_Place);
            bttPlace.Add(Star5_Place);

            bttFood.Add(Star1_Food);
            bttFood.Add(Star2_Food);
            bttFood.Add(Star3_Food);
            bttFood.Add(Star4_Food);
            bttFood.Add(Star5_Food);

            bttPrice.Add(Star1_Price);
            bttPrice.Add(Star2_Price);
            bttPrice.Add(Star3_Price);
            bttPrice.Add(Star4_Price);
            bttPrice.Add(Star5_Price);
            
        }
        private async void loadAverage() {
            string URLBase = "https://binarysystem.pythonanywhere.com/api/getAverage/";
            var httpResponse = await httpClient.GetAsync(URLBase);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                var average = JsonSerializer.Deserialize<HttpGetAverage>(content);

                fillStars(bttAttention, average.atenttion);
                fillStars(bttPlace, average.place);
                fillStars(bttFood, average.food);
                fillStars(bttPrice, average.price);
            }
        }

        private void fillStars(List<Button> stars, int avg)
        {
            int i = 0;
            foreach (var a in stars)
            {
                if (i < avg)
                {
                    a.BackColor = Color.DeepSkyBlue;
                    i++;
                }
            }
        }

        private void emptyDgv() { dgvContact.Rows.Clear(); }
        private async void loadDgvContact()
        {
            string URLBase = "https://binarysystem.pythonanywhere.com/api/listContact/";
            var httpResponse = await httpClient.GetAsync(URLBase);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                var contacts = JsonSerializer.Deserialize<List<HttpGetContact>>(content);

                if (contacts.Count > 0)
                {
                    fillDgv(dgvContact, contacts);
                }else
                {
                    MessageBox.Show("No hay consultas de clientes/personas.");
                }
            }
        }
        
        private void fillDgv(DataGridView dgv, List<HttpGetContact> contats)
        {
            emptyDgv();
            foreach(var c in contats)
            {
                dgv.Rows.Add(c.fullname, c.message, c.email, c.phone);
            }
        }


        private async void bttDeleteAll_Click(object sender, EventArgs e)
        {
            if (dgvContact.Rows.Count > 0)
            {
                string URLBase = "https://binarysystem.pythonanywhere.com/api/deleteAllContacts/";
                var httpResponse = await httpClient.GetAsync(URLBase);
                if (httpResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Se eliminaron todas las consultas.");
                    loadDgvContact();
                }
                else { MessageBox.Show("Ocurrio un error"); }
            }
            else { MessageBox.Show("No se puede eliminar, debido a que no hay consultas."); }
        }

        private async void bttDelete_Click(object sender, EventArgs e)
        {
            if(dgvContact.Rows.Count > 0)
            {
                string fullname = dgvContact.CurrentRow.Cells[0].Value.ToString();
                string URLBase = "https://binarysystem.pythonanywhere.com/api/deleteContact?fullname=" + fullname;
                var httpResponse = await httpClient.GetAsync(URLBase);
                if (httpResponse.IsSuccessStatusCode) {
                    MessageBox.Show("Consulta eliminada correctamente.");
                    loadDgvContact();
                }
            }
            else { MessageBox.Show("No se puede eliminar, debido a que no hay consultas."); }
        }

        private void button2_Click(object sender, EventArgs e) => loadDgvContact();
    }
}
