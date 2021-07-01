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
    public partial class PayServiceForm : Form
    {

        float[] charge;
        String[] shipmentNo;
        public PayServiceForm()
        {
            InitializeComponent();
        }

        private float calPayServiceTotal()
        {
            float total = 0;
            foreach (int i in clbPayment.CheckedIndices.Cast<int>().ToArray())
            {
                total += charge[i];
            }
            return total;
        }

        private void btnPayServicePay_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxPayServiceCardNo.Text.Length != 16 || tbxPayServiceSecureCode.Text.Length != 3)
                {
                    MessageBox.Show("Please Enter Credit Card Information");
                    return;
                }
                DatabaseConnector.connectDatabase();
                MySqlCommand cmd = DatabaseConnector.getConnetion().CreateCommand();
                if (checkbPayServiceSafeCreditInfo.Checked)
                {
                    cmd.CommandText = String.Format("UPDATE ede.customer SET customerCreditInfo='{0}' WHERE customerID={1}", tbxPayServiceCardNo.Text.Substring(0, 8), LoginForm.customerId);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = String.Format("UPDATE ede.edeaccount SET customerCreditInfo='{0}' WHERE customerID={1}", encryptString(tbxPayServiceCardNo.Text.Substring(8)), LoginForm.customerId);
                    cmd.ExecuteNonQuery();
                }

                foreach (int i in clbPayment.CheckedIndices.Cast<int>().ToArray())
                {
                    cmd.CommandText = String.Format("UPDATE ede.shipment SET status='wait_trans' WHERE shipmentNo='{0}'", shipmentNo[i]);
                    cmd.ExecuteNonQuery();

                    //Generate invoice
                    cmd.CommandText = String.Format("INSERT INTO ede.invoice VALUES ({0}, {1});", LoginForm.customerId, calPayServiceTotal());
                }

                MessageBox.Show("Payment Sucess..");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Something Wrong..");
            }
            clbPayment_Initialize();
        }

        private void llblLastCreditCard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DatabaseConnector.connectDatabase();
            MySqlCommand cmd = DatabaseConnector.getConnetion().CreateCommand();
            MySqlDataReader reader;
            cmd.CommandText = String.Format("SELECT customer.customerCreditInfo AS pre, edeaccount.customerCreditInfo AS lat FROM ede.customer, ede.edeaccount WHERE edeaccount.customerID={0} AND customer.customerID={0};", LoginForm.customerId);
            reader = cmd.ExecuteReader();
            reader.Read();
            try
            {
                tbxPayServiceCardNo.Text = reader.GetString("pre");
                tbxPayServiceCardNo.Text += encryptString(reader.GetString("lat"));
            }
            catch (Exception exception)
            {

            }
            reader.Close();
            DatabaseConnector.closeDatabase();
        }

        private String encryptString(String str)
        {
            char[] strArray = str.ToCharArray();
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < 8; i++)
                res.Append((char)(('9' * (i + 1) * (i + 2) - strArray[i]) % 10 + '0'));

            return res.ToString();
        }

        private void btnPayServiceCal_Click(object sender, EventArgs e)
        {
            lblPayServiceTotal.Text = "Total: $" + calPayServiceTotal().ToString("0.00");
        }

        private void PayServiceForm_Load(object sender, EventArgs e)
        {
            clbPayment_Initialize();
        }
        private void clbPayment_Initialize()
        {
            clbPayment.Items.Clear();
            DatabaseConnector.connectDatabase();
            MySqlCommand cmd = DatabaseConnector.getConnetion().CreateCommand();
            MySqlDataReader reader;
            cmd.CommandText = String.Format("SELECT name, charge, shipment.shipmentNo " +
                                            "FROM ede.documentfreight, ede.shipment " +
                                            "WHERE shipment.shipmentNo=documentfreight.shipmentNo AND (sender = {0} OR receiver = {0}) AND status = 'wait_pay';", LoginForm.customerId);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                charge = new float[reader.FieldCount + 1];
                shipmentNo = new String[reader.FieldCount + 1];
                int i = 0;
                while (reader.Read())
                {
                    clbPayment.Items.Add(reader.GetString("name") + ", shipment no: " + reader.GetString("shipmentNo"), false);
                    charge[i] = reader.GetFloat("charge");
                    shipmentNo[i++] = reader.GetString("shipmentNo");
                }
            }
            else
            {
                clbPayment.Items.Add("You have no payment in waiting order", false);
                clbPayment.Enabled = false;
                btnPayServiceCal.Visible = false;

            }
            reader.Close();
            DatabaseConnector.closeDatabase();
            lblPayServiceTotal.Text = "Total: $" + calPayServiceTotal().ToString("0.00");
        }
    }
}
