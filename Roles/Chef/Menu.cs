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
    public partial class Menu : Form
    {
        HttpClient client = new HttpClient();
        public Menu()
        {
            InitializeComponent();
            dgvDetalleMenu.ColumnHeadersVisible = false;
            loadNameMenu();
        }
        private void emptyDgv(DataGridView dgv) { dgv.Rows.Clear();  }
        private async Task loadDgvDetalleProducts(MenuGet menu)
        {
            emptyDgv(dgvDetalleMenu);
            foreach (var p in menu.products)
            {
                var imgBytes = await client.GetByteArrayAsync("https://binarysystem.pythonanywhere.com" + p.img);

                MemoryStream ms = new MemoryStream(imgBytes);
                dgvDetalleMenu.Rows.Add(Image.FromStream(ms), p.description, $"${p.price}", p.name);
            }
        }
        private async void loadNameMenu()
        {
            emptyDgv(dgvMenuName);
            emptyDgv(dgvDetalleMenu);
            string URL = "https://binarysystem.pythonanywhere.com/api/menuAdmin/";
            var httpResponse = await client.GetAsync(URL);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                var menus = JsonSerializer.Deserialize<List<MenuGet>>(content);

                foreach (var m in menus) {
                    dgvMenuName.Rows.Add(m.name); 
                }
                
            }
        }

        private async void dgvMenuName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string text = dgvMenuName.CurrentCell.Value.ToString();
            lblDetalleMenu.Text = text+": Contenido";
            string URL = "https://binarysystem.pythonanywhere.com/api/filterMenu/?name="+ text;
            var response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var detalleProducto = JsonSerializer.Deserialize<MenuGet>(content);
                loadDgvDetalleProducts(detalleProducto);
            }

        }
        private async void filterNameMenuAndDelete(string text)
        {
            var httpResponse = await client.GetAsync("https://binarysystem.pythonanywhere.com/api/findAndDeleteMenu/?name=" + text);

            if (httpResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Menu eliminado con exito.");
            }
            else
            {
                MessageBox.Show("Ocurrio un error.");
            }
        }


        private async void bttEliminarMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar?", "Eliminar menu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string text = dgvMenuName.CurrentCell.Value.ToString();
                filterNameMenuAndDelete(text);
                loadNameMenu();
            }
        }

        private async void dgvMenuName_Click(object sender, EventArgs e)
        {
            string text = dgvMenuName.CurrentCell.Value.ToString();
            lblDetalleMenu.Text = text + ": Contenido";
            string URL = "https://binarysystem.pythonanywhere.com/api/filterMenu/?name=" + text;
            var response = await client.GetAsync(URL);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var detalleProducto = JsonSerializer.Deserialize<MenuGet>(content);
                loadDgvDetalleProducts(detalleProducto);
            }
        }
    }
}
