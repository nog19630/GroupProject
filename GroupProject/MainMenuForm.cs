using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GroupProject
{
    public partial class MainMenuForm : Form
    {
        private string connection = "server=localhost;user id=root;database=ede;password=root";
        LoginForm lgnfrm = new LoginForm();
        private string cusID;
        float[] charge;
        String[] shipmentNo;
        public MainMenuForm(string cusID)
        {
            InitializeComponent();
            //var x;
            this.cusID = cusID;
            MessageBox.Show(cusID);
            this.Text = "Good Morning";
            clbPayment_Initialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Time: "+DateTime.Now.ToString("h:mm:ss tt");
            GridFill(dgv_shipments);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Time: " + DateTime.Now.ToString("h:mm:ss tt");
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lgnfrm.Show();
            this.Hide();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            
        }

        private void GridFill(DataGridView control)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Shipment WHERE sender = @user AND status = 'wait_bill';", mysqlcon);
                cmd.Parameters.AddWithValue("@user", cusID);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.SelectCommand.CommandType = CommandType.Text;

                DataTable dt = new DataTable();
                cmd.ExecuteNonQuery();
                da.Fill(dt);
                control.DataSource = dt;

                mysqlcon.Close();
            }
        }

        private void btn_fillbill_Click(object sender, EventArgs e)
        {
            airwaybill airwayfrm = new airwaybill(cusID);
            airwayfrm.Show();
        }

        private void clbPayment_Initialize()
        {
            clbPayment.Items.Clear();
            DatabaseConnector.connectDatabase();
            MySqlCommand cmd = DatabaseConnector.getConnetion().CreateCommand();
            MySqlDataReader reader;
            cmd.CommandText = String.Format("SELECT name, charge, shipment.shipmentNo " +
                                            "FROM ede.documentfreight, ede.shipment " +
                                            "WHERE shipment.shipmentNo=documentfreight.shipmentNo AND (sender = '{0}' OR receiver = '{0}') AND status = 'wait_pay';", cusID);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                charge = new float[reader.FieldCount + 1];
                shipmentNo = new String[reader.FieldCount + 1];
                int i=0;
                while (reader.Read())
                {
                    clbPayment.Items.Add(reader.GetString("name"), false);
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

        private void btnPayServiceCal_Click(object sender, EventArgs e)
        {
            lblPayServiceTotal.Text = "Total: $" + calPayServiceTotal().ToString("0.00");
        }

        private void llblLastCreditCard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DatabaseConnector.connectDatabase();
            MySqlCommand cmd = DatabaseConnector.getConnetion().CreateCommand();
            MySqlDataReader reader;
            cmd.CommandText = String.Format("SELECT * FROM ede.customer WHERE customerID='{0}';", cusID);
            reader = cmd.ExecuteReader();
            reader.Read();
            try
            {
                tbxPayServiceCardNo.Text = reader.GetString("customerCreditInfo");
            }
            catch (Exception exception)
            {

            }
            reader.Close();
            DatabaseConnector.closeDatabase();
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
                    cmd.CommandText = String.Format("UPDATE ede.customer SET customerCreditInfo='{0}' WHERE customerID='{1}'", tbxPayServiceCardNo.Text, cusID);
                    cmd.ExecuteNonQuery();
                }

                foreach (int i in clbPayment.CheckedIndices.Cast<int>().ToArray())
                {
                    cmd.CommandText = String.Format("UPDATE ede.shipment SET status='totransfer' WHERE shipmentNo='{0}'", shipmentNo[i]);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Payment Sucess..");

            }
            catch(Exception exception)
            {
                MessageBox.Show("Something Wrong..");
            }
            clbPayment_Initialize();
        }
    }
}
