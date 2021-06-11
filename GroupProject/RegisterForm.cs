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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txt_AccountAddress.Text != "" && txt_AccountName.Text != "" && txt_Password.Text != "" && txt_AccountAddress.Text != "" && txt_PhoneNumber.Text != "" && txt_UserName.Text != "")
            {
                string edeId = "ed" + DateTime.Now.ToString("yyMMmmss");
                string customerId = "cs" + DateTime.Now.ToString("yyMMddmmss");
                string creditLimit = txt_CreditLimit.Text;
                if (txt_CreditLimit.Text == "")
                {
                    creditLimit = "NULL";
                }
                string insertQuery1 = $"INSERT INTO ede.customer VALUES ('{customerId}', '{txt_UserName.Text}', '{txt_PhoneNumber.Text}', '{txt_FaxNumber.Text}', '{txt_Address.Text}', '{txt_PostCode.Text}', '{txt_Business.Text}', {creditLimit}, NULL, '{txt_CreditInfo.Text}');";
                string insertQuery2 = $"INSERT INTO ede.edeaccount VALUES ('{edeId}', '{customerId}', '{txt_AccountAddress.Text}', '{txt_AccountName.Text}', '{txt_Password.Text}', NULL);";
                if (DatabaseConnector.executeQuery(insertQuery1) && DatabaseConnector.executeQuery(insertQuery2))
                {
                    MessageBox.Show("Register Success");
                }
                else
                {
                    string deleteQuery1 = $"DELECT FROM ede.customer WHERE customerID = '{customerId}'";
                    string deleteQuery2 = $"DELECT FROM ede.edeaccount WHERE edeID = '{edeId}'";
                    DatabaseConnector.executeQuery(deleteQuery1);
                    DatabaseConnector.executeQuery(deleteQuery2);
                    MessageBox.Show("Register Failure");
                }
            }
            else
            {
                MessageBox.Show("Please enter information");
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_PhoneNumber.Text = "";
            txt_FaxNumber.Text = "";
            txt_PostCode.Text = "";
            txt_Business.Text = "";
            txt_CreditLimit.Text = "";
            txt_Address.Text = "";
        }
    }
}
