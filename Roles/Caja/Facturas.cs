using System.Text.Json;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;


namespace Application_Sentidos.Roles
{
    public partial class Facturas : Form
    {
        public double totalFactura = 0;
        public int numFactura = 0;
        public DateTime date = DateTime.Now;
        public int numOrden { get; set; }
        public int typePayment { get; set; }
        public int numeroMesa { get; set; }
        public string tipoDeFactura { get; set; }
        public Facturas(int numero, int method_payment, int mesa, string typeFactura)
        {
            tipoDeFactura = typeFactura;
            numeroMesa = mesa;
            numOrden = numero;
            InitializeComponent();
            txtBoxNumeroMeza.Text = mesa.ToString();
            typePayment = method_payment;
            actualizarDatosFactura();
        }
        private void actualizarDatosFactura()
        {
            numFactura++;
            lblFecha.Text = date.ToString();
            lblNumFactura.Text = numFactura.ToString();
        }
        public class Ordenes
        {
            public int id { get; set; }
            public int table { get; set; }
            public List<Products>? products { get; set; }
            public string? pay { get; set; }
        }
        public class Products
        {
            public string? product { get; set; }
            public int quantity { get; set; }
            public double price { get; set; }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (txtBoxNombreCliente.Text == "" || txtBoxDniCliente.Text == "")
            {
                MessageBox.Show("Todos los campos son requeridos", "Faltan completar los campos");
            }
            else
            {
                GenerarFactura(typePayment);
            }
        }
        public async void GenerarFactura(int payment)
        {
            string url = "https://binarysystem.pythonanywhere.com/api/checking_invoice/";
            var client = new HttpClient();
            //orden - tipo de pago - total factura
            Facturacion factura = new Facturacion()
            {
                order = numOrden,
                method_pay = payment,
                totalPrice = double.Parse(txtBoxTotal.Text),
            };
            var data = JsonSerializer.Serialize<Facturacion>(factura);
            HttpContent httpContent = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await client.PostAsync(url, httpContent);

            if (httpResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Factura creada con exito, ¡Gracias por su compra!", "Sentidos Restaurant & Casa de Té");
                ModifyOrder(numOrden);
                var content = await httpResponse.Content.ReadAsStringAsync();

                var facturaGET = JsonSerializer.Deserialize<FacturacionGET>(content);

                SaveFileDialog guardarPDF = new SaveFileDialog();
                guardarPDF.FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";

                //string bodyHTML = "{% load static %}\r\n<html>\r\n  <head>\r\n    <title>FACTURA</title>\r\n    <style>\r\n      /* Selector de clase */\r\n      * {\r\n        margin: 0;\r\n        padding: 0;\r\n      }\r\n      .factura {\r\n        width: 400px;\r\n        margin: auto;\r\n        text-align: center; /* Sirve para poner los elementos en el centro */\r\n        border: 2px solid black; /* es el borde, en este caso remarcamos los bordes con un grueso de 2px.  */\r\n      }\r\n      img {\r\n        width: 120px;\r\n      }\r\n      .factura > .factura__header {\r\n        border-bottom: 2px dotted black;\r\n      }\r\n      .factura__header__parrafo {\r\n        text-align: left;\r\n        margin-left: 10px;\r\n        margin-bottom: 3px;\r\n      }\r\n      .listFood {\r\n        list-style: none;\r\n        display: flex;\r\n      }\r\n\r\n      .prueba {\r\n        display: flex;\r\n      }\r\n      .prueba__method_pay {\r\n        margin-top: 20px;\r\n        margin-left: 10px;\r\n        text-align: left;\r\n      }\r\n      .prueba__totalPrice {\r\n        margin-top: 20px;\r\n        margin-left: 90px;\r\n        text-align: right;\r\n        border: 2px solid black;\r\n      }\r\n      .factura__body {\r\n        display: flex;\r\n        flex-direction: column;\r\n        text-align: left;\r\n        align-items: flex-start;\r\n        margin: 5px auto;\r\n      }\r\n\r\n      .factura__body ul {\r\n        display: flex;\r\n        flex-direction: column;\r\n        margin: 5px 0 5px 10px;\r\n        width: 100%;\r\n        text-align: left;\r\n        align-items: flex-start;\r\n      }\r\n\r\n      .factura__body ul li {\r\n        display: flex;\r\n        flex-direction: row;\r\n        text-decoration: none;\r\n        list-style: none;\r\n        width: 100%;\r\n        justify-content: space-around;\r\n        text-align: left;\r\n        align-items: flex-start;\r\n      }\r\n\r\n      .factura__type {\r\n        font-size: 24px;\r\n        margin: 10px;\r\n      }\r\n      .tabla_roductos {\r\n        margin-left: 30px;\r\n      }\r\n    </style>\r\n\r\n  </head>\r\n  <body>\r\n    <div class=\"factura\">\r\n      <div class=\"factura__header\">\r\n        <img src=\"{% static 'home/LogoSentidos.png' %}\" alt=\"LogoSentidos.\">\r\n        <h1>Sentidos Restaurante & Casa de Té</h1>\r\n\r\n        <p class=\"factura__header__parrafo\">Direccion: French 440.</p>\r\n        <p class=\"factura__header__parrafo\">Inicio de actividad: 01/01/2022</p>\r\n        <p class=\"factura__header__parrafo\">CUIT: 20-98765765-2</p>\r\n        <p class=\"factura__header__parrafo\">IVA RESPONSABLE INSCRIPTO</p>\r\n\r\n        <h1 class=\"factura__type\">FACTURA B</h1>\r\n        <p class=\"factura__header__parrafo\">\r\n          Factura N°: {{ invoice.number_invoice }}\r\n        </p>\r\n        <p class=\"factura__header__parrafo\">Fecha: {{ invoice.date}}</p>\r\n        <p class=\"factura__header__parrafo\">{{ invoice.order.table }}</p>\r\n        <p class=\"factura__header__parrafo\">Cliente: Consumidor Final</p>\r\n        <p class=\"factura__header__parrafo\">Concepto: Productos</p>\r\n      </div>\r\n\r\n      <table class=\"tabla_roductos\" border=\"1\">\r\n        <thead>\r\n          <th>Producto</th>\r\n          <th>Precio unitario</th>\r\n          <th>Cantidad</th>\r\n          <th>Precio total</th>\r\n        </thead>\r\n        <tbody>\r\n          {%for p in invoice.order.productorder_set.all %}\r\n          <tr>\r\n            <td>{{ p.product.name }}</td>\r\n            <td>${{ p.getUnitPrice }}</td>\r\n            <td>x{{ p.quantity }}</td>\r\n            <td>${{ p.price }}</td>\r\n          </tr>\r\n          {%endfor%}\r\n        </tbody>\r\n      </table>\r\n\r\n      <div class=\"prueba\">\r\n        <p class=\"prueba__method_pay\">\r\n          Metodo de pago: {{ invoice.method_pay.name }}\r\n        </p>\r\n        <p class=\"prueba__totalPrice\">\r\n          Precio total: ${{ invoice.totalPrice }}\r\n        </p>\r\n      </div>\r\n      <img src=\"{% static 'home/QRFactura.png' %}\" alt=\"QR\" />\r\n    </div>\r\n  </body>\r\n</html>\r\n";

                if(guardarPDF.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(guardarPDF.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25,25,25,25);

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase("Hola a todos"));

                        pdfDoc.Close();

                        stream.Close();
                    }
                }

            }
        }
        public async Task ModifyOrder(int order)
        {
            string url = "https://binarysystem.pythonanywhere.com/api/updateOrder/?id=" + order + "&pay=True";
            var client = new HttpClient();

            Ordenes ordenActualizada = new Ordenes()
            {
                id = order,
                pay = "True",
            };

            var data = JsonSerializer.Serialize<Ordenes>(ordenActualizada);
            HttpContent httpContent = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
            var httpResponse = await client.PutAsync(url, httpContent);

            if (httpResponse.IsSuccessStatusCode)
            {
                //var result = await httpResponse.Content.ReadAsStringAsync();
                this.Close();
            }
        }
        public async Task DetailOrder(int order)
        {
            string detailOrder = "https://binarysystem.pythonanywhere.com/api/detailOrder/?id=" + order;
            HttpClient client = new HttpClient();
            var httpResponse = await client.GetAsync(detailOrder);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                var orden = JsonSerializer.Deserialize<Ordenes>(content);

                foreach (var item in orden.products)
                {
                    dgvDetallesFactura.Rows.Add(item.product, item.quantity, item.price);
                }
                foreach (var item in orden.products)
                {
                    totalFactura += item.price;
                }
            }
            txtBoxTotal.Text = totalFactura.ToString();
        }
        private void Facturas_Load(object sender, EventArgs e)
        {
            DetailOrder(numOrden);
            lblTipoFactura.Text = tipoDeFactura.ToString();
        }
    }
    public class Facturacion
    {
        public int order { get; set; }
        public int method_pay { get; set; }
        public double totalPrice { get; set; }
    } public class FacturacionGET
    {
        public int number_invoice { get; set; }
        public int order { get; set; }
        public int method_pay { get; set; }
        public double totalPrice { get; set; }
    }
}
