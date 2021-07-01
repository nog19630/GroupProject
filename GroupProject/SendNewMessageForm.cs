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
    public partial class SendNewMessageForm : Form
    {
        public SendNewMessageForm()
        {
            InitializeComponent();
        }

        private void SendNewMessageForm_Load(object sender, EventArgs e)
        {
            lvw_ReceiverList.Columns.Add("Ede Account ID", 100);
            lvw_ReceiverList.Columns.Add("Customer ID", 100);
            lvw_ReceiverList.Columns.Add("Customer Name", 100);
            lvw_ReceiverList.Columns.Add("Email Address", 130);
            lvw_ReceiverList.Columns.Add("Customer Phone", 100);

            cmb_KeywordType.Items.Add("Ede Account ID");
            cmb_KeywordType.Items.Add("Customer ID");
            cmb_KeywordType.SelectedIndex = 0;

            fullList();

        }

        private void fullList(string orderBy = "edeID", DataSet dsEdeAccount = null)
        {
            lvw_ReceiverList.Items.Clear();
            btn_Send.Enabled = false;
            txt_EdeAccountID.Text = "";
            txt_CustomerID.Text = "";
            txt_CustomerName.Text = "";
            txt_EmailAddress.Text = "";
            string sql;
            if (dsEdeAccount == null)
            {
                lvw_ReceiverList.Text = "";
                sql = $"SELECT * FROM ede.edeaccount ORDER BY {orderBy} ASC;";
                dsEdeAccount = DatabaseConnector.getDataSet(sql, "edeaccount");

            }
            if (dsEdeAccount.Tables["edeaccount"].Rows.Count > 0)
            {
                for (int i = 0; i < dsEdeAccount.Tables["edeaccount"].Rows.Count; i++)
                {
                    string edeID = dsEdeAccount.Tables["edeaccount"].Rows[i]["edeID"].ToString();
                    string customerID = dsEdeAccount.Tables["edeaccount"].Rows[i]["customerID"].ToString();
                    string emailAddress = dsEdeAccount.Tables["edeaccount"].Rows[i]["emailAddress"].ToString();

                    sql = $"SELECT * FROM ede.customer WHERE customerID = '{customerID}';";
                    DataRow drCustomer = DatabaseConnector.getDataRow(sql);

                    string customerName = drCustomer["customerName"].ToString();
                    string customerPhone = drCustomer["customerPhone"].ToString();

                    ListViewItem lvi = new ListViewItem(edeID);
                    lvi.SubItems.Add(customerID);
                    lvi.SubItems.Add(customerName);
                    lvi.SubItems.Add(emailAddress);
                    lvi.SubItems.Add(customerPhone);
                    lvw_ReceiverList.Items.Add(lvi);
                }
            }
            else
            {
                if (dsEdeAccount != null)
                {
                    MessageBox.Show("Not Match Record");
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string keyword = txt_Keyword.Text;
            int keywordType = cmb_KeywordType.SelectedIndex;
            string sql = "";
            string orderBy = "";

            switch (keywordType)
            {
                case 0:
                    orderBy = "edeID";
                    sql = $"SELECT * FROM ede.edeaccount WHERE edeID LIKE '{keyword}%' ORDER BY {orderBy} ASC;";
                    break;
                case 1:
                    orderBy = "customerID";
                    sql = $"SELECT * FROM ede.edeaccount WHERE customerID LIKE '{keyword}%' ORDER BY {orderBy} ASC;";
                    break;
            }

            DataSet dsMessage = DatabaseConnector.getDataSet(sql, "edeaccount");
            fullList(orderBy, dsMessage);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_KeywordType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int keywordType = cmb_KeywordType.SelectedIndex;
            
            fullList((keywordType == 0) ? "edeID" : "customerID");
        }

        private void lvw_ReceiverList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_ReceiverList.SelectedItems.Count > 0)
            {
                btn_Send.Enabled = true;
                string customerID = lvw_ReceiverList.SelectedItems[0].SubItems[1].Text;
                string sql = $"SELECT * FROM ede.edeaccount WHERE customerID = '{customerID}';";
                DataRow drEdeAccount = DatabaseConnector.getDataRow(sql);
                sql = $"SELECT * FROM ede.customer WHERE customerID = '{customerID}';";
                DataRow drCustomer = DatabaseConnector.getDataRow(sql);

                txt_EdeAccountID.Text = drEdeAccount["edeID"].ToString();
                txt_CustomerID.Text = drCustomer["customerID"].ToString();
                txt_CustomerName.Text = drCustomer["customerName"].ToString();
                txt_EmailAddress.Text = drEdeAccount["emailAddress"].ToString();
            }
        }

        private void btn_Send_Click(object s, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Determine the send new messsage?", "Send New Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string messageContent = ManageMessageForm.messageContent;
                string sendTime = DateTime.Now.ToString("HH:mm:ss");
                string messageID = DateTime.Now.ToString("yyMMddhhmmss");
                string sender = LoginForm.userId;
                string receiver = txt_EdeAccountID.Text;
                string sql = $"INSERT INTO ede.message VALUES ({messageID}, '{receiver}', '{sender}', '{messageContent}', '{sendTime}', 'New', 'Custom');";
                if (DatabaseConnector.executeQuery(sql))
                {
                    MessageBox.Show("Send Message Success");

                }
                else
                {
                    MessageBox.Show("Send Message Failure");
                }
                this.Close();
            }
        }
    }
}
