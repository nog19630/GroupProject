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
        public airwaybill(string cusID)
        {
            InitializeComponent();
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
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Shipment WHERE sender = @user;");
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
    }
}
