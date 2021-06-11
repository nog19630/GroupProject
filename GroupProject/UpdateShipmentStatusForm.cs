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
    public partial class UpdateShipmentStatusForm : Form
    {
        private string receiver;
        private string sender;
        private string currentStatus;
        private string changedStatus;
        private string customerEdeAcID;
        

        public UpdateShipmentStatusForm()
        {
            InitializeComponent();
        }

        private void UpdateStatusForm_Load(object s, EventArgs e)
        {
            string sql = $"SELECT * FROM ede.shipment WHERE shipmentNo = '{EditShipmentForm.ShipmentNo}'";
            DataRow drShipment = DatabaseConnector.getDataRow(sql);

            currentStatus = drShipment["status"].ToString();
            receiver = drShipment["receiver"].ToString();
            sender = LoginForm.loginAccount;
            changedStatus = EditShipmentForm.SelectedStatus;


            txt_CurrentStatus.Text = currentStatus;
            txt_ChangeStatus.Text = changedStatus;
            txt_ReceiverID.Text = receiver;

            sql = $"SELECT * FROM ede.edeaccount WHERE customerID = '{receiver}'";
            DataRow drEdeaccount = DatabaseConnector.getDataRow(sql);
            customerEdeAcID = drEdeaccount["edeID"].ToString();



        }

        private void btn_Confirm_Click(object s, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Determine the update status?", "Update Status Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string shipmentNo = EditShipmentForm.ShipmentNo;
                string sql = $"UPDATE ede.shipment SET status = '{EditShipmentForm.SelectedStatus}' WHERE shipmentNo = '{shipmentNo}';";
                if (DatabaseConnector.executeQuery(sql))
                {
                    if (chk_SendChangedMessage.Checked || chk_CustomMessage.Checked)
                    {
                        string sendMessage = "";
                        string sendTime = DateTime.Now.ToString();
                        
                        string messageID = DateTime.Now.ToString("yyMMddhhmmss");
                        if (chk_SendChangedMessage.Checked)
                        {
                            sendMessage += "System Message:\n";
                            sendMessage += $"Shipment No: {shipmentNo} state changed from {currentStatus} to {changedStatus}!\n";
                            sendMessage += "Message Date & Time: " + sendTime + "\n\n";
                        }
                        if (chk_CustomMessage.Checked)
                        {
                            sendMessage += "Memo Message:\n";
                            sendMessage += rtx_CustomMessage.Text;
                        }
                        sql = $"INSERT INTO ede.message VALUES ({messageID}, '{customerEdeAcID}', '{sender}', '{sendMessage}', '{sendTime}', 'New', 'System');";
                        if (DatabaseConnector.executeQuery(sql))
                        {
                            MessageBox.Show("Send Message & Update Success");
                        }
                        else
                        {
                            MessageBox.Show("Send Message Failure");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update Success");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Update Failure");
                }
                this.Close();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
