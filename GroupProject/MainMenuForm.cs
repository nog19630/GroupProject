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
using Microsoft.Reporting.WinForms;


namespace GroupProject
{
    public partial class MainMenuForm : Form
    {
        MySqlDataAdapter da;
        DataTable dt;
        public static char userType;
        private static bool logout = false;
        float[] charge;
        String[] shipmentNo;
        public MainMenuForm()
        {
           
            InitializeComponent();
            //var x;
            clbPayment_Initialize();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_AccountID.Text += LoginForm.userId;
            if (userType == 'u')
            {
                lbl_UserType.Text += "User";
                lbl_CustomerID.Text += LoginForm.customerId;
                //Monthly Invoice 
                try
                {
                    rv_monthlyInv.RefreshReport();
                    DatabaseConnector.connectDatabase();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT shipment.shipmentNo,date,shipmentType,charge FROM shipment,documentfreight WHERE sender = '" + LoginForm.customerId + "' AND MONTH(date) = " + 6 + " AND shipment.shipmentNo = documentfreight.shipmentNo;", DatabaseConnector.getConnetion());
                    DataSet1 ds = new DataSet1();
                    adapter.Fill(ds.Tables[0]);
                    rv_monthlyInv.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    rv_monthlyInv.LocalReport.ReportPath = System.Environment.CurrentDirectory + "\\..\\..\\Report1.rdlc";

                    rv_monthlyInv.LocalReport.DataSources.Clear();
                    rv_monthlyInv.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables[0]));
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DatabaseConnector.closeDatabase();
                }

                //Load 
                toolStripStatusLabel1.Text = "Time: " + DateTime.Now.ToString("h:mm:ss tt");
                DatabaseConnector.GridFill(dgv_shipments, "SELECT * FROM Shipment WHERE sender = @user AND status = 'wait_bill';");

                //Airway bill submit
                tbp_submitbill.Show();

                //Pay delivery Service
                tbp_payservice.Show();

                // book pickup form
                BookPickupForm bookPickupForm = new BookPickupForm();
                bookPickupForm.TopLevel = false;
                bookPickupForm.Visible = true;
                tbp_BookPickup.Controls.Add(bookPickupForm);
                tbp_BookPickup.Show();

                //Invoice 
                ImportInvoice importinvoice = new ImportInvoice();
                importinvoice.TopLevel = false;
                importinvoice.Visible = true;
                tbp_ImportInv.Controls.Add(importinvoice);

                // check shipment status form
                CheckShipmentStatusForm checkShipmentStatusForm = new CheckShipmentStatusForm();
                checkShipmentStatusForm.TopLevel = false;
                checkShipmentStatusForm.Visible = true;
                tbp_CheckShipmentStatus.Controls.Add(checkShipmentStatusForm);

                // Message box form
                MessageBoxForm messageBoxForm = new MessageBoxForm();
                messageBoxForm.TopLevel = false;
                messageBoxForm.Visible = true;
                tbp_MessageBox.Controls.Add(messageBoxForm);

                // dispose
                tbp_EditPickupOrder.Dispose();
                tbp_ManageMessage.Dispose();
                tbp_datamain.Dispose();
            } 
            else if (userType == 'a')
            {

                lbl_UserType.Text += "Admin";
                lbl_CustomerID.Visible = false;

                // edit pickup order form
                EditShipmentForm editPickupForm = new EditShipmentForm();
                editPickupForm.TopLevel = false;
                editPickupForm.Visible = true;
                tbp_EditPickupOrder.Controls.Add(editPickupForm);
                tbp_EditPickupOrder.Show();

                //
                ManageMessageForm manageMessageForm = new ManageMessageForm();
                manageMessageForm.TopLevel = false;
                manageMessageForm.Visible = true;
                tbp_ManageMessage.Controls.Add(manageMessageForm);
                tbp_ManageMessage.Show();

                // dispose
                tbp_BookPickup.Dispose();
                tbp_CheckShipmentStatus.Dispose();
                tbp_MessageBox.Dispose();
                tbp_payservice.Dispose();
                tbp_submitbill.Dispose();
                tbp_ImportInv.Dispose();
                tbp_MonthInv.Dispose();
            }


            
        }

        private void tbc_Function_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userType == 'u')
            {
                switch ((sender as TabControl).SelectedIndex)
                {
                    case 0:
                        tbp_BookPickup.Show();
                        break;
                    case 1:
                        tbp_CheckShipmentStatus.Show();
                        break;
                    case 2:
                        tbp_MessageBox.Show();
                        break;
                }
            }
            else
            {
                switch ((sender as TabControl).SelectedIndex)
                {
                    case 0:
                        tbp_EditPickupOrder.Show();
                        break;
                    case 1:
                        tbp_ManageMessage.Show();
                        break;

                }
            }
            
        }


        private void btn_Logout_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Dispose();
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == true)
            {
                logout = false;
            }
            else
            {
                Application.Exit();
            }

        }

        private void btn_fillbill_Click(object sender, EventArgs e)
        {
            AirwayBillForm airwayfrm = new AirwayBillForm(LoginForm.customerId);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Time: " + DateTime.Now.ToString("h:mm:ss tt");
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
                    cmd.CommandText = String.Format("UPDATE ede.customer SET customerCreditInfo='{0}' WHERE customerID={1}", tbxPayServiceCardNo.Text.Substring(0,8), LoginForm.customerId);
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = String.Format("UPDATE ede.edeaccount SET customerCreditInfo='{0}' WHERE customerID={1}",encryptString(tbxPayServiceCardNo.Text.Substring(8)), LoginForm.customerId);
                    cmd.ExecuteNonQuery();
                }

                foreach (int i in clbPayment.CheckedIndices.Cast<int>().ToArray())
                {
                    cmd.CommandText = String.Format("UPDATE ede.shipment SET status='wait_trans' WHERE shipmentNo='{0}'", shipmentNo[i]);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Payment Sucess..");

            }
            catch (Exception exception)
            {
                MessageBox.Show("Something Wrong..");
            }
            clbPayment_Initialize();
        }

        private void llblLastCreditCard_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
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
                res.Append((char) (('9' * (i+1) * (i+2) - strArray[i])%10 + '0'));
            
            return res.ToString();
        }

        private void cbo_table_SelectedIndexChanged(object sender, EventArgs e)
        {

                try
                {
                
                    DatabaseConnector.connectDatabase();
                    string sql = "SELECT * FROM " + cbo_table.Text + ";";
                    MySqlCommand cmd = DatabaseConnector.getConnetion().CreateCommand();
                    dt = new DataTable();
                    cmd.CommandText = String.Format(sql);
                    da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    cmd.ExecuteNonQuery();
                    da.Fill(dt);
                    dgv_maintenance.DataSource = dt;
                    MySqlCommandBuilder cbuilder = new MySqlCommandBuilder(da);

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DatabaseConnector.closeDatabase();
                }


            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try {
                dgv_maintenance.EndEdit();
                da.Update(dt);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DatabaseConnector.closeDatabase();
            }

        }

        private void btnPayServiceCal_Click(object sender, EventArgs e)
        {
            lblPayServiceTotal.Text = "Total: $" + calPayServiceTotal().ToString("0.00");
        }
    }
}
