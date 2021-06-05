﻿using System;
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
        string connection = @"server=localhost;user id=root;database=ede;password=root";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.TopMost = true;
            frm.Show();
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
            } else
            {
                MessageBox.Show("Login Failure");
            }
        }
    }
}
