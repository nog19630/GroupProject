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
    public partial class airwaybill : Form
    {
        private string connection = "server=localhost;user id=root;database=ede;password=root";
        private string cusID;
        public airwaybill(string cusID)
        {
            InitializeComponent();
            this.cusID = cusID;
        }

        private void airwaybill_Load(object sender, EventArgs e)
        {
            GridFill(dgv_pack);
        }

        private void GridFill(DataGridView control)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                mysqlcon.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Shipment WHERE sender = @user;",mysqlcon);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the form?", "Reset Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                airwaybill resetfrm = new airwaybill(cusID);
                resetfrm.Show();
                this.Dispose();
            }

        }
    }
}
