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
    public partial class ManageMessageForm : Form
    {
        private string staffID = LoginForm.userId;
        public static string messageID;
        public static string messageContent;
        public static string messageStatus;

        public ManageMessageForm()
        {
            InitializeComponent();
        }

        private void ManageMessageForm_Load(object sender, EventArgs e)
        {
            cmb_KeywordType.Items.Add("Message ID");
            cmb_KeywordType.Items.Add("Receiver");
            cmb_KeywordType.Items.Add("Send Time");
            cmb_KeywordType.Items.Add("Status");
            cmb_KeywordType.Items.Add("Message Type");
            cmb_KeywordType.SelectedIndex = 0;

            lvw_MessageList.Columns.Add("Message ID", 120);
            lvw_MessageList.Columns.Add("Receiver", 120);
            lvw_MessageList.Columns.Add("Send Time", 150);
            lvw_MessageList.Columns.Add("Status", 100);
            lvw_MessageList.Columns.Add("Message Type", 100);

            fullList();
        }

        private void fullList(DataSet ds = null)
        {
            btn_EditSelectedMessage.Enabled = false;
            btn_DeleteSelectedMessage.Enabled = false;
            btn_EditSelectedStatus.Enabled = false;

            lvw_MessageList.Items.Clear();
            rtx_MessageContent.Text = "";
            messageContent = "";
            messageStatus = "";
            messageID = "";
            if (ds == null)
            { 
                string sql = $"SELECT * FROM ede.message WHERE sender = '{staffID}' ORDER BY sendTime DESC;";
                ds = DatabaseConnector.getDataSet(sql, "message");
                
            }
            if (ds.Tables["message"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["message"].Rows.Count; i++)
                {
                    string messageID = ds.Tables["message"].Rows[i]["messageID"].ToString();
                    string receiver = ds.Tables["message"].Rows[i]["receiver"].ToString();
                    string sendTime = ds.Tables["message"].Rows[i]["sendTime"].ToString();
                    string status = ds.Tables["message"].Rows[i]["status"].ToString();
                    string type = ds.Tables["message"].Rows[i]["messageType"].ToString();
                    

                    ListViewItem lvi = new ListViewItem(messageID);
                    lvi.SubItems.Add(receiver);
                    lvi.SubItems.Add(sendTime);
                    lvi.SubItems.Add(status);
                    lvi.SubItems.Add(type);
                    lvw_MessageList.Items.Add(lvi);
                }
            }
            else
            {
                if (ds != null)
                {
                    MessageBox.Show("Not Match Record");
                }
            }
            
        }

               

        private void lvw_MessageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_MessageList.SelectedItems.Count > 0)
            {
                btn_EditSelectedMessage.Enabled = true;
                btn_DeleteSelectedMessage.Enabled = true;
                btn_EditSelectedStatus.Enabled = true;
                string sql = $"SELECT * FROM ede.message WHERE messageID = '{lvw_MessageList.SelectedItems[0].Text}';";
                DataRow dr = DatabaseConnector.getDataRow(sql);
                rtx_MessageContent.Text = dr["message"].ToString();
                messageContent = rtx_MessageContent.Text;
                messageStatus = lvw_MessageList.SelectedItems[0].SubItems[3].Text;
                messageID = lvw_MessageList.SelectedItems[0].Text;
            }
        }

        private void cmb_KeywordType_SelectedIndexChanged(object sender, EventArgs e)
        {
            fullList();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            string keyword = txt_Keyword.Text;
            int keywordType = cmb_KeywordType.SelectedIndex;
            string sql = "";

            switch (keywordType)
            {
                case 0:
                    sql = $"SELECT * FROM ede.message WHERE messageID LIKE '{keyword}%' ORDER BY sendTime DESC;";
                    break;
                case 1:
                    sql = $"SELECT * FROM ede.message WHERE receiver LIKE '{keyword}%' ORDER BY sendTime DESC;";
                    break;
                case 2:
                    sql = $"SELECT * FROM ede.message WHERE sendTime LIKE '{keyword}%' ORDER BY sendTime DESC;";
                    break;
                case 3:
                    sql = $"SELECT * FROM ede.message WHERE status LIKE '{keyword}%' ORDER BY sendTime DESC;";
                    break;
                case 4:
                    sql = $"SELECT * FROM ede.message WHERE messageType LIKE '{keyword}%' ORDER BY sendTime DESC;";
                    break;
            }

            DataSet dsMessage = DatabaseConnector.getDataSet(sql, "message");
            fullList(dsMessage);
        }


        private void btn_SendNewMessage_Click(object sender, EventArgs e)
        {
            messageContent = rtx_MessageContent.Text;
            SendNewMessageForm sendNewMessageForm = new SendNewMessageForm();
            sendNewMessageForm.ShowDialog();
            fullList();
        }

        private void btn_EditSelectedMessage_Click(object sender, EventArgs e)
        {

            messageContent = rtx_MessageContent.Text;
            string sql = $"UPDATE ede.message SET message = '{messageContent}' WHERE messageID = '{messageID}';";
            DialogResult result = MessageBox.Show("Determine edit the messsage?", "Edit Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (DatabaseConnector.executeQuery(sql))
                {
                    MessageBox.Show("Edit Uploaded Successfully");
                }
                else
                {
                    MessageBox.Show("Edit Uploaded Failed");
                }
                fullList();
            }
            
        }

        private void btn_ResetContent_Click(object sender, EventArgs e)
        {
            rtx_MessageContent.Text = "";
        }

        private void btn_DeleteSelectedMessage_Click(object sender, EventArgs e)
        {
            
            string sql = $"DELETE FROM ede.message WHERE messageID = '{messageID}';";
            DialogResult result = MessageBox.Show("Determine delete the messsage?", "Delete Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (DatabaseConnector.executeQuery(sql))
                {
                    MessageBox.Show("Delete Message Successfully");
                }
                else
                {
                    MessageBox.Show("Delete Message Failed");
                }
                fullList();
            }
        }

        private void btn_EditSelectedStatus_Click(object sender, EventArgs e)
        {
            UpdateMessageStatusForm updateMessageStatusForm = new UpdateMessageStatusForm();
            updateMessageStatusForm.ShowDialog();
            fullList();
        }
    }
}
