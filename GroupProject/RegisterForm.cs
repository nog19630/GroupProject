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
            // insert example
            string sqlCustomer = String.Format("INSERT INTO ede.customer (customerID, customerName, customerPhone, customerAddress) VALUES ('{0}', '{1}', '{2}', '{3}')", tbxName.Text, tbxEmail.Text, tbxPhone.Text, tbxAddress.Text);
            if (DatabaseConnector.executeQuery(sqlCustomer))
            {
                MessageBox.Show("Register Success");
            }
            else
            {
                MessageBox.Show("Register Failure");
            }
        }

        private void llblOldUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Locked -> UnLock
            if (tbxName.Enabled == false)
            {
                tbxName.Enabled = true;
                tbxPhonePrefix.Enabled = true;
                tbxPhone.Enabled = true;
                llblOldUser.Text = "Check registered";
                return;
            }

            // Check Name Entered
            if (tbxName.Text.Trim().Equals(""))
                MessageBox.Show("Please Enter Your Name", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Check Phone Entered
            else if (tbxPhone.Text.Trim().Equals(""))
                MessageBox.Show("Please Enter Your Phone Number", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // SQL
            else try
                {

                string sql = String.Format("SELECT * FROM ede.customer WHERE customerName = '{0}' AND customerPhone = '{1}'",tbxName.Text, tbxPhonePrefix.Text+tbxPhone.Text);
                if (!DatabaseConnector.getUserID(tbxName.Text, sql).Equals("")){
                    MessageBox.Show("Hi, " + tbxName.Text);

                    // Lock Column
                    tbxName.Enabled = false;
                    tbxPhonePrefix.Enabled = false;
                    tbxPhone.Enabled = false;
                    llblOldUser.Text = "Change a User";
                }

                // Customer Not Found
            } catch (MySql.Data.MySqlClient.MySqlException exception) {
                MessageBox.Show("Not Found", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Other Exception
            } catch (Exception exception) {
                MessageBox.Show("Whoops, Something Wrong", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

        }

        private void checkBoxPolicy_CheckedChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = !btnSubmit.Enabled;
        }
    }
    
}
