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

        private void button1_Click(object sender, EventArgs e)
        {
            // insert example 
            string insertQuery = String.Format("INSERT INTO ede.customer (customerID, customerName, customerPhone, customerAddress) VALUES ('{0}', '{1}', '{2}', '{3}')", tbx_EmailAddress.Text, tbx_UserName.Text, tbx_PhoneNumber.Text, tbx_Address.Text);
            DatabaseConnector.executeQuery(insertQuery);
        }
    }
}
