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

namespace GroupProject
{
    public partial class LoginForm : Form
    {
        public static string userId;
        public static string loginAccount;
        public static string customerId;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private bool IsLogin(string user, string pass, char userType) 
        {
            string query = "";
            if (userType == 'u') { 
                query = $"SELECT * FROM ede.edeaccount WHERE loginAccountName = '{user}' AND loginAccountPw = '{pass}';";
            }
            else if (userType == 'a')
            {
                query = $"SELECT * FROM ede.staff WHERE staffID = '{user}' AND staffPassword = '{pass}';";
            }
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
            userId = "";

            if (IsLogin(user, pass, 'u'))
            {
                string sql = $"SELECT * FROM ede.edeaccount WHERE loginAccountName = '{user}';";
                DataRow drEdeId = DatabaseConnector.getDataRow(sql);
                userId = drEdeId["edeID"].ToString();
                loginAccount = user;
                customerId = drEdeId["customerID"].ToString();
                MessageBox.Show("Login Success");
                MainMenuForm.userType = 'u';
                MainMenuForm mainMenuForm = new MainMenuForm();
                this.Hide();
                mainMenuForm.ShowDialog();
                this.Controls.Clear();
                this.InitializeComponent();
                this.Show();

            }
            else if (IsLogin(user, pass, 'a'))
            {
                userId = user;
                loginAccount = user;
                MessageBox.Show("Login Success");
                MainMenuForm.userType = 'a';
                MainMenuForm mainMenuForm = new MainMenuForm();
                this.Hide();
                mainMenuForm.ShowDialog();
                this.Controls.Clear();
                this.InitializeComponent();
                this.Show();
            }
            else
            {
                MessageBox.Show("Login Failure");
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
