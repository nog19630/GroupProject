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
        public static bool UserSuccessfullyAuthenticated = false;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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

            if (IsLogin(user, pass))
            {
                MessageBox.Show("Login Success");
                UserSuccessfullyAuthenticated = true;
                this.Close();

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


        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                this.Close();
            }
        }
    }
}
