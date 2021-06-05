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

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                int i = 0;
                mysqlcon.Open();
                String command = "select * from edeaccount where loginAccountName = @name and loginAccountPw = @password;";
                MySqlCommand cmd = new MySqlCommand(command, mysqlcon);
                cmd.Parameters.AddWithValue("@name", txt_username.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                cmd.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                da.Fill(dt); //MySqlDataReader dr = cmd.ExecuteReader(); Use this when passing arguments through forms is needed
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (i == 0)
                    {
                        MessageBox.Show("Incorrect credentials");
                    }
                    else
                    {
                            MainMenuForm fm1 = new MainMenuForm();
                            fm1.Show();
                            this.Hide();
                    }
                }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

