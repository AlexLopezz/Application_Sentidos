using Application_Sentidos.Resources.Objects;
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
        GetUserFilter userSelected = new GetUserFilter();
        DateTime date = DateTime.Now;
        HttpClient httpClient = new HttpClient();
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
        
        public CreateReserva()
        {
            InitializeComponent();
            this.CenterToScreen();
            setDateFecha(dateFecha);
        }
        private async void bttBuscarMesas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboSchedule.Text))
            {
                MessageBox.Show("Para buscar una mesa disponible, usted debe ingresar un horario.");
            }
            else
            {
                var httpResponse = await httpClient.GetAsync("https://binarysystem.pythonanywhere.com/api/getReservation/?schedule=" + cboSchedule.Text + "&date=" + dateFecha.Text);
                if (httpResponse.IsSuccessStatusCode)
                {
                    load_ButtonsLime(buttonsTables());
                    var body = await httpResponse.Content.ReadAsStringAsync();
                    try
                    {
                        var list_TableSelected = JsonSerializer.Deserialize<List<GetSelectedTable>>(body);

                        loadTables(list_TableSelected, buttonsTables());
                    }
                    catch (Exception)
                    {
                        load_ButtonsLime(buttonsTables());
                        lblResultadoDisponibles.Text = buttonsTables().Count.ToString();
                    }
                }
            }
        }
        private bool validateFields()
        {
            return string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(txtPhone.Text) &&
                string.IsNullOrEmpty(cboSchedule.Text)  && string.IsNullOrEmpty(txtSelected_tables.Text);
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                MessageBox.Show("Debe completar los campos para realizar una reserva.");
            }
            else
            {
                string[] table_selected = txtSelected_tables.Text.Split(',');


                List<int> table = new List<int>();

                for (int i = 0; i < table_selected.Length - 1; i++)
                {
                    table.Add(Int32.Parse(table_selected[i]));
                }
                JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
                string URLBase = "https://binarysystem.pythonanywhere.com/api/reservation/";
                HttpClient client = new HttpClient();

                var post = new HttpPostReserva()
                {
                    user_id = userSelected.id,
                    phone = txtPhone.Text,
                    schedule = cboSchedule.Text,
                    date = dateFecha.Text,
                    selected_tables = table
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
        }
       
        public void setDateFecha(DateTimePicker dateFecha)
        {
            dateFecha.MinDate = date;
            dateFecha.MaxDate = date.AddDays(30);
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
                    try
                    {
                        var userFilter = JsonSerializer.Deserialize<List<GetUserFilter>>(body);
                        loadListFilter(userFilter);
                    }
                    catch (Exception) { listUserFilter.Items.Add("No se encontro usuario.");  }
                }
                else { MessageBox.Show("Ocurrio un error");  }
            }
        }
        
        private void loadListFilter(List<GetUserFilter> listUser)
        {
            foreach(var user in listUser) { listUserFilter.Items.Add(user); }
        }
        
        
        private void emptyListFilter() { listUserFilter.Items.Clear(); }

        private void bttSelectUser_Click(object sender, EventArgs e)
        {
            if (listUserFilter.Items.Count != 0)
            {
               var id = listUserFilter.SelectedItem.ToString().Substring(0,1);

               userSelected.id = Convert.ToInt32(id);
                
               txtUser.Text = listUserFilter.SelectedItem.ToString().Substring(1);
               emptyListFilter();
               txtBusquedaUser.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("No selecciono ningun usuario.");
            }
            
        }



        private void loadLblResultados(List<Button> botones, int mesas)
        {
            lblResultadoReservadas.Text = mesas.ToString();
            lblResultadoDisponibles.Text = (botones.Count - mesas).ToString();

        }


        public void load_ButtonsLime(List<Button> buttonsTables) { foreach (var b in buttonsTables) { b.BackColor = Color.Lime; } }

        public void loadTables(List<GetSelectedTable> list_TableSelected, List<Button> list_button)
        {
            int mesasReservadas = 0;

            foreach (var tables in list_TableSelected) 
            {
                foreach (var t in tables.selected_tables)
                {
                    
                    foreach (var b in list_button) 
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

        private void bttMesa1_Click(object sender, EventArgs e)=> loadTxtTableSelected(bttMesa1);

        private void loadTxtTableSelected(Button bttTable)
        {
            if (bttTable.BackColor == Color.Red)
            {
                MessageBox.Show("No se puede elegir esta mesa, debido a que esta reservada.");
            }
            else if (bttTable.BackColor == Color.Lime)
            {
                txtSelected_tables.Text += bttTable.Text + ",";
            }
            else
            {
                MessageBox.Show("Para seleccionar una mesa, ustede debe darle al boton 'Buscar Mesas', para ver las disponibles.");
            }
        }

        private void bttLimpiar_Click(object sender, EventArgs e)  => txtSelected_tables.Text = String.Empty;

        private void bttMesa2_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa2);

        private void bttMesa3_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa3);

        private void bttMesa4_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa4);

        private void bttMesa5_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa5);

        private void bttMesa6_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa6);

        private void bttMesa7_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa7);

        private void bttMesa8_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa8);

        private void bttMesa9_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa9);

        private void bttMesa10_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa10);

        private void bttMesa11_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa11);

        private void bttMesa12_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa12);

        private void bttMesa13_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa13);

        private void bttMesa14_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa14);

        private void bttMesa15_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa15);

        private void bttMesa16_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa16);
        private void bttMesa17_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa17);

        private void bttMesa18_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa18);

        private void bttMesa19_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa19);

        private void bttMesa20_Click(object sender, EventArgs e) => loadTxtTableSelected(bttMesa20);

        private void CreateReserva_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
