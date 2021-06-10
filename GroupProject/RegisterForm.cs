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

    public partial class RegisterForm : Form
    {

        private bool oldsystem = false;
        private static string connection = "server=localhost;user id=root;database=ede;password=root";
        private string cusID;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            // Check Each Column Entered
            if (tbxName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please Enter Your Name", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                tbxPassword.Text = ""; tbxRePassword.Text = ""; return;
            }
            else if (tbxPhonePrefix.Text.Trim().Equals("") && tbxPhone.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please Enter Phone Number", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                tbxPassword.Text = ""; tbxRePassword.Text = ""; return;
            }
            else if (llblCheckAccountValid.Text.Equals("Check validation"))
            {
                MessageBox.Show("Please Validate Your Account Name", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                tbxPassword.Text = ""; tbxRePassword.Text = ""; return;
            }
            else if (!checkBoxPassword.Visible)
            {
                MessageBox.Show("Please Check your Password", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                tbxPassword.Text = ""; tbxRePassword.Text = ""; return;
            }
            else if (tbxEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please Enter Email", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                tbxPassword.Text = ""; tbxRePassword.Text = ""; return;
            }
            else if (tbxAccount.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please Enter Address", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                tbxPassword.Text = ""; tbxRePassword.Text = ""; return;
            }

            // Connect
            DatabaseConnector.connectDatabase();
            MySqlCommand cmd = DatabaseConnector.getConnetion().CreateCommand();
            MySqlDataReader reader;

            // Update Data
            {
                if (oldsystem)
                {
                    cmd.CommandText = String.Format("UPDATE ede.customer SET customerBusiness={0}, customerFax='{1}', customerAddress='{2}' WHERE customerID = '{3}';",
                                                    rbBussinessP.Checked ? "'P'" : (rbBussinessC.Checked ? "'C'" : "null"), tbxFax.Text, tbxAddress.Text, cusID);
                    
                }
                else
                {
                    cmd.CommandText = String.Format("SELECT customerID FROM ede.customer ORDER BY customerID DESC LIMIT 1;");
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    cusID = stringAddOne(reader.GetString("customerID"));
                    reader.Close();
                    cmd.CommandText = String.Format("INSERT INTO ede.customer VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, 5000, 'N', null);",
                                                    cusID, tbxName.Text, tbxPhonePrefix.Text+tbxPhone.Text, tbxFax.Text, tbxAddress.Text, tbxPostCode.Text, rbBussinessP.Checked ? "'P'" : (rbBussinessC.Checked ? "'C'" : "null"));
                }

                cmd.ExecuteNonQuery();
                cmd.CommandText = String.Format("SELECT edeID FROM ede.edeaccount ORDER BY edeID DESC LIMIT 1;");
                reader = cmd.ExecuteReader();
                reader.Read();
                cmd.CommandText = String.Format("INSERT INTO ede.edeaccount VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", stringAddOne(reader.GetString("edeID")), cusID, tbxEmail.Text, tbxAccount.Text, tbxPassword.Text, checkBoxEmailNotice.Checked ? 'Y' : 'N');
                reader.Close();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Register Success. Directing to Login Screen...");
                DatabaseConnector.closeDatabase();
                this.Close();

            } 
        }

        // To import data if old customer register in new system, and to avoid repeat information
        private void llblOldUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Locked -> UnLock
            if (!tbxName.Enabled)
            {
                tbxName.Enabled = true;
                tbxPhonePrefix.Enabled = true;
                tbxPhone.Enabled = true;
                llblOldUser.Text = "Check registered";
                oldsystem = false;
                cusID = "";
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
                    DatabaseConnector.connectDatabase();
                    MySqlCommand cmd = DatabaseConnector.getConnetion().CreateCommand();
                    cmd.CommandText = String.Format("SELECT * FROM ede.customer WHERE customerName = '{0}' AND customerPhone = '{1}'", tbxName.Text, tbxPhonePrefix.Text + tbxPhone.Text);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                    reader.Read();
                        MessageBox.Show("Hi, " + tbxName.Text);
                        // Lock Column
                        tbxName.Enabled = false;
                        tbxPhonePrefix.Enabled = false;
                        tbxPhone.Enabled = false;
                        llblOldUser.Text = "Change a User";
                        oldsystem = true;

                        // Import Bussiness Type
                        if (reader.GetChar("customerBusiness").Equals('P'))
                        {
                            rbBussinessP.Checked = true;
                            rbBussinessP.Enabled = false;
                            rbBussinessC.Enabled = false;
                        } else if (reader.GetChar("customerBusiness").Equals('C'))
                        {
                            rbBussinessC.Checked = true;
                            rbBussinessP.Enabled = false;
                            rbBussinessC.Enabled = false;
                        }

                        // Import Fax
                        if (!reader.IsDBNull(3))
                        {
                            tbxFax.Text = reader.GetString("customerFax");
                            tbxFax.Enabled = false;
                        }

                        // Import Address
                        if (!reader.IsDBNull(4))
                        {
                            tbxAddress.Text = reader.GetString("customerAddress");
                            tbxAddress.Enabled = false;
                        }

                        // Store id
                        cusID = reader.GetString("customerID");
                        reader.Close();
                    }
                    else
                    // Customer Not Found
                    {
                        MessageBox.Show("Not Found, you are a new customer");
                    }
                }
                //Exception
                catch (Exception exception)
                {
                    MessageBox.Show("Whoops, Something Wrong", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                //Close DB
                finally
                {
                    DatabaseConnector.closeDatabase();
                }

        }

        // Accpet Policy to submit
        private void checkBoxPolicy_CheckedChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = !btnSubmit.Enabled;
        }

        // Check Account Used
        private void llblCheckAccountValid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Check Data Entered (null?)
            if (tbxAccount.Text.Equals(""))
            {
                MessageBox.Show("Please Enter Account Name", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            else
            {
                DatabaseConnector.connectDatabase();
                MySqlCommand cmd = DatabaseConnector.getConnetion().CreateCommand();
                cmd.CommandText = String.Format("SELECT * FROM ede.edeaccount WHERE loginAccountName = '{0}'", tbxAccount.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Account Name has been used", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Okay!");
                    llblCheckAccountValid.Text = "Valid!";
                }

                DatabaseConnector.closeDatabase();
            }
        }

        // Used in password and re-enter password
        private void CheckPassword(object sender, EventArgs e)
        {
            checkBoxPassword.Visible = tbxPassword.Text.Equals(tbxRePassword.Text) && !tbxPassword.Text.Equals("") && !tbxRePassword.Text.Equals("");
            checkBoxPassword.Text = checkBoxPassword.Text.Length >= 8 ? "Valid!" : "8~16 alphanumeric letters";
            checkBoxPassword.Checked = checkBoxPassword.Text.Length >= 8;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxAccount_TextChanged(object sender, EventArgs e)
        {
            llblCheckAccountValid.Text = "Check validation";
        }

        private String stringAddOne(String str)
        {
            return (Int32.Parse(str) + 1).ToString();
        }
    }
    
}
