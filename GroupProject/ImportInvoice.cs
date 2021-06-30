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
    public partial class ImportInvoice : Form
    {
        public ImportInvoice()
        {
            InitializeComponent();
        }

        private void ImportInvoice_Load(object sender, EventArgs e)
        {
            lvw_InvoiceList.Columns.Add("invoiceID", 120);
            lvw_InvoiceList.Columns.Add("customerID", 120);
            lvw_InvoiceList.Columns.Add("totalDeliveryCost", 120);
            lvw_InvoiceList.Columns.Add("detail", 120);
            lvw_InvoiceList.Columns.Add("verification", 120);
            lvw_InvoiceList.Columns.Add("paymentMethod", 120);
            fullList();
        }
        private void fullList(bool showMessage = false)
        {
            string sql = $"SELECT * FROM ede.invoice WHERE invoiceID LIKE '{txt_SearchShipmentNo.Text.ToString()}%' AND customerID = '{LoginForm.customerId}'";
            DataSet ds = DatabaseConnector.getDataSet(sql, "invoice");
            if (lvw_InvoiceList.Items.Count > 0)
            {
                lvw_InvoiceList.Items.Clear();
            }

            if (ds.Tables["invoice"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["invoice"].Rows.Count; i++)
                {
                    string shipmentNo = ds.Tables["invoice"].Rows[i]["invoiceID"].ToString();
                    string customerID = ds.Tables["invoice"].Rows[i]["customerID"].ToString();
                    string totalDeliveryCost = ds.Tables["invoice"].Rows[i]["totalDeliveryCost"].ToString();
                    string detail = ds.Tables["invoice"].Rows[i]["detail"].ToString();
                    string verification = ds.Tables["invoice"].Rows[i]["verification"].ToString();
                    string paymentMethod = ds.Tables["invoice"].Rows[i]["paymentMethod"].ToString();

                    ListViewItem lvi = new ListViewItem(shipmentNo);
                    lvi.SubItems.Add(customerID);
                    lvi.SubItems.Add(totalDeliveryCost);
                    lvi.SubItems.Add(detail);
                    lvi.SubItems.Add(verification);
                    lvi.SubItems.Add(paymentMethod);
                    lvw_InvoiceList.Items.Add(lvi);
                }
            }
            else
            {
                if (showMessage)
                {
                    MessageBox.Show("Not Match Invoice ID");
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            fullList(true);
        }

        private void btn_selectInvoice_Click(object sender, EventArgs e)
        {
            if (lvw_InvoiceList.SelectedItems.Count > 0)
            {
                int invoiceID = 0;
                
                invoiceID = int.Parse(lvw_InvoiceList.SelectedItems[0].Text);
        

                try
                {
                    InvoiceForm invfrm = new InvoiceForm(invoiceID);
                    invfrm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot find invoice\n" + ex.Message);
                }
                finally
                {

                }
            }
            else {
                MessageBox.Show("Please select an invoice");
            }



        }
    }
}
