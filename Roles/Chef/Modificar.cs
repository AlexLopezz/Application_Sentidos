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

namespace Application_Sentidos.Roles.Chef
{
    public partial class Modificar : Form
    {
        HttpClient client = new HttpClient();
        public Modificar(string menu)
        {
            InitializeComponent();
            this.CenterToScreen();
            loadMenu(menu);
        }
        private async void loadMenu(string menu)
        {
            string URL = "https://binarysystem.pythonanywhere.com/api/filterMenu/?name="+menu;

            var response = await client.GetAsync(URL);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var menuGET = JsonSerializer.Deserialize<MenuGet>(content);

                lblMenuNombre.Text = menuGET.name;

                foreach(var m in menuGET.products)
                {
                    var imgBytes = await client.GetByteArrayAsync("https://binarysystem.pythonanywhere.com" + m.img);
                    MemoryStream ms = new MemoryStream(imgBytes);
                    dgvProductoMenu.Rows.Add(Image.FromStream(ms), m.description, $"${m.price}", m.name);
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }

}
