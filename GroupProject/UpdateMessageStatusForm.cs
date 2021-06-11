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
    public partial class UpdateMessageStatusForm : Form
    {
        public UpdateMessageStatusForm()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateMessageStatusForm_Load(object sender, EventArgs e)
        {
            cmb_ChangeStatus.Items.Add("New");
            cmb_ChangeStatus.Items.Add("Read");
            cmb_ChangeStatus.Items.Add("Delete");
            cmb_ChangeStatus.SelectedIndex = 0;

            
            txt_CurrentStatus.Text = ManageMessageForm.messageStatus;
            txt_MessageID.Text = ManageMessageForm.messageID;

        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string changeStatus = cmb_ChangeStatus.SelectedItem.ToString();
            string messageID = ManageMessageForm.messageID;
            string sql = $"UPDATE ede.message SET status = '{changeStatus}' WHERE messageID = '{messageID}';";
            DialogResult result = MessageBox.Show("Determine update the message status?", "Update Message Status", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (DatabaseConnector.executeQuery(sql))
                {
                    MessageBox.Show("Update Message Status Successfully");
                }
                else
                {
                    MessageBox.Show("Update Message Status Failed");
                }
                this.Close();
            }
        }
    }
}
