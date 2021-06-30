using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class InvoiceForm : Form
    {
        int invoiceID;

        public InvoiceForm(int invoiceID)
        {
            InitializeComponent();
            this.invoiceID = invoiceID;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            DatabaseConnector.connectDatabase();
            MySqlCommand cmd = DatabaseConnector.getConnetion().CreateCommand();
            MySqlDataReader reader;
            try
            {                
                cmd.CommandText = String.Format("SELECT sender, receiver, totalDeliveryCost, detail " +
                                                "FROM ede.invoice, ede.shipment " +
                                                "WHERE invoice.invoiceID = shipment.invoiceID AND invoice.invoiceID = {0};", invoiceID);
                reader = cmd.ExecuteReader();
                reader.Read();
                String senderID = reader.GetString("sender"), receiverID = reader.GetString("receiver");
                lblTotal.Text = "Total Invoice Value: " + reader.GetFloat("totalDeliveryCost").ToString("0.00");
                try
                {
                    tbxDescription.Text = reader.GetString("detail");
                }
                catch (Exception exception)
                {
                    tbxDescription.Text = "No Description";
                }
                tbxInvoiceID.Text = invoiceID.ToString();
                reader.Close();

                cmd.CommandText = String.Format("SELECT customerName, customerAddress, customerPhone, customerFax " +
                                                "FROM ede.customer " +
                                                "WHERE customerID='{0}'", senderID);
                reader = cmd.ExecuteReader();
                reader.Read();
                tbxSender.Text = reader.GetString("customerName");
                tbxSenderAddress.Text = reader.GetString("customerAddress");
                tbxSenderPhone.Text = reader.GetString("customerPhone") + (reader.IsDBNull(3) ? "" : " / " + reader.GetString("customerFax"));
                reader.Close();

                cmd.CommandText = String.Format("SELECT customerName, customerAddress, customerPhone, customerFax, customerPostCode " +
                                                "FROM ede.customer " +
                                                "WHERE customerID='{0}'", receiverID);
                reader = cmd.ExecuteReader();
                reader.Read();
                tbxReceiver.Text = reader.GetString("customerName");
                tbxReceiverAddress.Text = reader.GetString("customerAddress");
                tbxReceiverPhone.Text = reader.GetString("customerPhone") + (reader.IsDBNull(3) ? "" : " / " + reader.GetString("customerFax"));
                tbxPostCode.Text = reader.GetString("customerPostCode");
                reader.Close();

                cmd.CommandText = String.Format("SELECT weight, quantity FROM ede.invoice, ede.shipment, ede.documentfreight, ede.freight WHERE invoice.invoiceID = shipment.invoiceID AND shipment.shipmentNo = documentfreight.shipmentNo AND invoice.invoiceID = {0} AND freight.itemID = documentfreight.itemID; ", invoiceID);
                reader = cmd.ExecuteReader();
                reader.Read();
                tbxPieces.Text = reader.GetInt32("quantity").ToString();
                tbxWeight.Text = reader.GetFloat("weight").ToString();



                reader.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Something wrong. Please Contact our staff.");
            }
            finally { DatabaseConnector.closeDatabase(); }
               
            

        }
    }
}
