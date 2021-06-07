using System;
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
    public partial class MainMenuForm : Form
    {
        private string connection = "server=localhost;user id=root;database=ede;password=root";
        LoginForm lgnfrm = new LoginForm();
        private string cusID;
        public MainMenuForm(string cusID)
        {
            InitializeComponent();
            //var x;
            this.cusID = cusID;
            MessageBox.Show(cusID);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Time: "+DateTime.Now.ToString("h:mm:ss tt");
            GridFill(dgv_shipments);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Time: " + DateTime.Now.ToString("h:mm:ss tt");
        }

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            lgnfrm.Show();
            this.Hide();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            
        }

        private void GridFill(DataGridView control)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Shipment WHERE sender = @user;", mysqlcon);
                cmd.Parameters.AddWithValue("@user", cusID);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.SelectCommand.CommandType = CommandType.Text;

                DataTable dt = new DataTable();
                cmd.ExecuteNonQuery();
                da.Fill(dt);
                control.DataSource = dt;

                mysqlcon.Close();
            }
        }

        private void btn_fillbill_Click(object sender, EventArgs e)
        {
            airwaybill airwayfrm = new airwaybill(cusID);
            airwayfrm.Show();
        }
    }
}
