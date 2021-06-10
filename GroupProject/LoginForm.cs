using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Timers;

namespace GroupProject
{
    public partial class LoginForm : Form
    {
        public static bool UserSuccessfullyAuthenticated = false;
        private int secureLoginTime = 3; // lock user when fail to login three times
        System.Timers.Timer timer;

        public LoginForm()
        {
            InitializeComponent();

            // Set timer
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Stop();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private bool IsStaffLogin(string user, string pass) {
            string query = $"SELECT * FROM ede.staff WHERE staffID = '{user}' AND staffPassword = '{pass}';";
            try
            {
                return DatabaseConnector.matchQuery(query);
            }
            catch (Exception ex) {
                DatabaseConnector.closeDatabase();
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool IsLogin(string user, string pass)
        {
            string query = $"SELECT * FROM ede.edeaccount WHERE loginAccountName = '{user}' AND loginAccountPw = '{pass}';";
            try
            {
                return DatabaseConnector.matchQuery(query);
            }
            catch (Exception ex)
            {
                DatabaseConnector.closeDatabase();
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = tbx_AccountName.Text;
            string pass = tbx_Password.Text;

            // Missing Account Name
            if (tbx_AccountName.Text.Trim().Equals(""))
                MessageBox.Show("Please Enter Account Name", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // Missing Password
            else if (tbx_Password.Text.Trim().Equals(""))
                MessageBox.Show("Please Enter Password", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // Login Success
            else if (IsLogin(user, pass))
            {
                MessageBox.Show("Login Success");
                UserSuccessfullyAuthenticated = true;
                string cmd = "SELECT * FROM edeaccount WHERE loginAccountName = @name;";
                string cusID = DatabaseConnector.getUserID(user, cmd);
                MainMenuForm mainfrm = new MainMenuForm(cusID); //Passing in customerID for Listboxes or Datagridview to show data according to the cusID
                DatabaseConnector.closeDatabase();
                mainfrm.Show();
                this.Hide();

            }
            // Login Fail
            else 
            {
                // Count Down From 3 to 0
                if (--secureLoginTime == 0)
                {
                    // Security 30 seconds Lock
                    MessageBox.Show("Login Failure, Please wait 30 seconds", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    tbx_AccountName.Enabled = false;
                    tbx_Password.Enabled = false;
                    tbx_Password.Text = "";
                    btn_Login.Enabled = false;
                    btn_Login.Text = "30s";
                    secureLoginTime = 30;

                    timer.Start();
                    timer.Elapsed += Count30;
                }
                else
                {
                    MessageBox.Show("Login Failure, you can try " + secureLoginTime + " more times", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    tbx_Password.Text = "";
                }
            }
        }

        // Timer Loop (30 times)
        private void Count30(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (secureLoginTime == 0)
                {
                    timer.Stop();
                    this.tbx_AccountName.Enabled = true;
                    this.tbx_Password.Enabled = true;
                    btn_Login.Enabled = true;
                    btn_Login.Text = "Login";
                }
                else
                    btn_Login.Text = --secureLoginTime + "s";
            }));
           
        }


        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnTestUse_Click(object sender, EventArgs e)
        {
            UserSuccessfullyAuthenticated = true;
            string cmd = "SELECT * FROM edeaccount WHERE loginAccountName = @name;";
            string cusID = DatabaseConnector.getUserID("root1234", cmd);
            MainMenuForm mainfrm = new MainMenuForm(cusID); //Passing in customerID for Listboxes or Datagridview to show data according to the cusID
            DatabaseConnector.closeDatabase();
            mainfrm.Show();
            this.Hide();
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            string user = tbx_AccountName.Text;
            string pass = tbx_Password.Text;

            if (IsStaffLogin(user, pass))
            {
                // Login Success
                UserSuccessfullyAuthenticated = true;
                string cmd = "SELECT position FROM staff WHERE staffID = @name;";
                string pos = DatabaseConnector.getStaffPos(user, cmd);
                DatabaseConnector.closeDatabase();

                if (pos == "IT Officer")
                {
                    MessageBox.Show("Login Success");
                    DataMaintenance mainfrm = new DataMaintenance();
                    mainfrm.Show();
                    this.Hide();
                }
                else
                { //Add any other positions here according to the case study
                    MessageBox.Show("The staff credentials entered is not permitted to use any of the system's functions.");
                }



            }
            else {
                if (--secureLoginTime == 0)
                {
                    // Security 30 seconds Lock
                    MessageBox.Show("Login Failure, Please wait 30 seconds", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    tbx_AccountName.Enabled = false;
                    tbx_AccountName.Text = "";
                    tbx_Password.Enabled = false;
                    tbx_Password.Text = "";
                    btn_Login.Enabled = false;
                    btn_Login.Text = "30s";
                    secureLoginTime = 30;

                    timer.Start();
                    timer.Elapsed += Count30;
                }
                else
                {
                    MessageBox.Show("Login Failure, you can try " + secureLoginTime + " more times", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
