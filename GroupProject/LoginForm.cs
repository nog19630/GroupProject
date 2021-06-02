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

namespace GroupProject
{
    public partial class LoginForm : Form
    {
        string connection = ConfigurationManager.ConnectionStrings["GroupProject.Properties.Settings.Setting"].ConnectionString;
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

        }
    }
}
