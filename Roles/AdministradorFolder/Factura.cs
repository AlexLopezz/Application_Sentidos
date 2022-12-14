using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Diagnostics;

namespace Application_Sentidos.Roles.AdministradorFolder
{
    public partial class Factura : Form
    {
        double totalPrice = 0;
        HttpClient httpClient = new HttpClient();
        public Factura()
        {
            InitializeComponent();
            loadDgvInvoice("https://binarysystem.pythonanywhere.com/api/checking_invoice/");
        }
        private void emptyDgv() => dgvFacturas.Rows.Clear();
        private async void loadDgvInvoice(string URLBase)
        {
            lblTotal.Text = "Total pagado: $";
            lblTotalCredito.Text = "$0";
            lblTotalDebito.Text = "$0";
            lblTotalEfectivo.Text = "$0";
            emptyDgv();
            double debito = 0, credito = 0, efectivo = 0;
            
            var httpResponse = await httpClient.GetAsync(URLBase);

            if (httpResponse.IsSuccessStatusCode)
            {
                var content = await httpResponse.Content.ReadAsStringAsync();
                var facturas = JsonSerializer.Deserialize<List<Invoice>>(content);

                foreach(var invoice in facturas)
                {
                    totalPrice += invoice.totalPrice;
                    dgvFacturas.Rows.Add(invoice.number_invoice, invoice.date, invoice.method_pay, $"${invoice.totalPrice}","Consumidor final");
                    switch (invoice.method_pay)
                    {
                        case "Efectivo":
                            efectivo += invoice.totalPrice;
                            break;
                        case "Debito":
                            debito+= invoice.totalPrice;
                            break;
                        case "Credito":
                            credito+= invoice.totalPrice;
                            break;
                    }
                }
                lblTotalEfectivo.Text ="$"+efectivo.ToString();
                lblTotalDebito.Text = "$"+debito.ToString();
                lblTotalCredito.Text = "$"+credito.ToString();
                lblTotal.Text += totalPrice.ToString();
            }
            else
            {
                MessageBox.Show("No existen facturas por el momento.");
                lblTotal.Text = "Total pagado: $";
            }
        }

        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("Click");
            }
        }

        private bool checkFieldsTxT()
        {
            if (dateStart.Value <= dateEnd.Value && !(string.IsNullOrEmpty(cboMethodPay.Text)))
            {
                return true;
            }
            else { return false; }
        }

        private async void bttShowInvoice_Click(object sender, EventArgs e)
        {
            if (checkFieldsTxT())
            {
                loadDgvInvoice("https://binarysystem.pythonanywhere.com/api/filterInvoice/?dateStart=" + dateStart.Text + "&dateEnd=" + dateEnd.Text + "&method_pay=" + cboMethodPay.Text);

            }
            else { MessageBox.Show("Ocurrio un error, verifique los campos.\nEste error puede ocurrir por que:\n*La fecha de inicio es mayor a la fecha de Fin.\n*El metodo de pago no fue seleccionado."); }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
