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
    public partial class MessageBoxForm : Form
    {
        private string edeID = LoginForm.userId;
        

        public MessageBoxForm()
        {
            InitializeComponent();
        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {
           
            lvw_MessageList.Columns.Add("Message ID", 120);
            lvw_MessageList.Columns.Add("Sender", 120);
            lvw_MessageList.Columns.Add("Send Time", 150);
            lvw_MessageList.Columns.Add("Status", 100);
            lvw_MessageList.Columns.Add("Message Type", 100);

            fullList();

        }

        private void fullList()
        {
            lvw_MessageList.Items.Clear();
            rtx_MessageContent.Text = "";
            string sql = $"SELECT * FROM ede.message WHERE receiver = '{edeID}' AND status != 'Delete' ORDER BY sendTime ASC;";
            DataSet dsMessage = DatabaseConnector.getDataSet(sql, "message");

            if (dsMessage.Tables["message"].Rows.Count > 0)
            {
                for (int i = 0; i < dsMessage.Tables["message"].Rows.Count; i++)
                {
                    string messageID = dsMessage.Tables["message"].Rows[i]["messageID"].ToString();
                    string sender = dsMessage.Tables["message"].Rows[i]["sender"].ToString();
                    string sendTime = dsMessage.Tables["message"].Rows[i]["sendTime"].ToString();
                    string status = dsMessage.Tables["message"].Rows[i]["status"].ToString();
                    string type = dsMessage.Tables["message"].Rows[i]["messageType"].ToString();

                    ListViewItem lvi = new ListViewItem(messageID);
                    lvi.SubItems.Add(sender);
                    lvi.SubItems.Add(sendTime);
                    lvi.SubItems.Add(status);
                    lvi.SubItems.Add(type);
                    lvw_MessageList.Items.Add(lvi);
                }
            }    
        }

        private void lvw_MessageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_MessageList.SelectedItems.Count > 0)
            {
                string messageID = lvw_MessageList.SelectedItems[0].Text;  
                string sql = $"SELECT * FROM ede.message WHERE messageID = '{messageID}';";
                DataRow dsMessage = DatabaseConnector.getDataRow(sql);

                string message = dsMessage["message"].ToString();
                rtx_MessageContent.Text = message;

                if (dsMessage["status"].ToString() == "New")
                {
                    sql = $"UPDATE ede.message SET status = 'Read' WHERE messageID = '{messageID}';";
                    DatabaseConnector.executeQuery(sql);
                }
            }
        }

        private void btn_UpdateList_Click(object sender, EventArgs e)
        {
            fullList();
        }

        private void btn_DeleteMessage_Click(object sender, EventArgs e)
        {
            string messageID = lvw_MessageList.SelectedItems[0].Text;
            string sql = $"UPDATE ede.message SET status = 'Delete' WHERE messageID = '{messageID}';";
            if (DatabaseConnector.executeQuery(sql))
            {
                MessageBox.Show("Delete Message Success");
            }
            else
            {
                MessageBox.Show("Delete Message Failure");
            }
            fullList();
        }
    }
}
