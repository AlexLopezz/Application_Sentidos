using System.Text.Json;

namespace Application_Sentidos.Roles.Chef
{
    public partial class Menu : Form
    {
        CrearMenuNuevo m = new CrearMenuNuevo();
        HttpClient client = new HttpClient();
        public Menu()
        {
            InitializeComponent();
            dgvDetalleMenu.ColumnHeadersVisible = false;
            dgvMenuName.ColumnHeadersVisible = false;
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
            lblDetalleMenu.Text = "";
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

        private async void filterNameMenuAndDelete(string text)
        {
            var httpResponse = await client.DeleteAsync("https://binarysystem.pythonanywhere.com/api/menuAdmin/?nameMenu=" + text);

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
                string text = dgvMenuName.Rows[dgvMenuName.CurrentRow.Index].Cells[0].Value.ToString();
                filterNameMenuAndDelete(text);
                loadNameMenu();
            }
        }

        private void bttNuevoMenu_Click(object sender, EventArgs e)
        {
            m.ShowDialog();
            loadNameMenu();
        }

        private void bttModificarMenu_Click(object sender, EventArgs e)
        {
            Modificar modificarMenu = new Modificar(dgvMenuName.Rows[dgvMenuName.CurrentRow.Index].Cells[0].Value.ToString());
            modificarMenu.ShowDialog();
        }

        private async void dgvMenuName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                string text = dgvMenuName.Rows[dgvMenuName.CurrentRow.Index].Cells[0].Value.ToString();
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

        private void bttRefrescar_Click(object sender, EventArgs e)
        {
            loadNameMenu();
            emptyDgv(dgvDetalleMenu);
        }
    }
}
