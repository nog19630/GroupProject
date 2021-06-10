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
    public partial class DataMaintenance : Form
    {
        private string connection = "server=localhost;user id=root;database=ede;password=root";

        public DataMaintenance()
        {
            InitializeComponent();
            
        }

        private void cb_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection)) {
                try {
                    mysqlcon.Open();
                    string sql = "SELECT * FROM " + cb_table.Text + ";";
                    MySqlCommand cmd = new MySqlCommand(sql, mysqlcon);
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    da.SelectCommand = cmd;
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    mysqlcon.Close();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }


            }
            
            
        }
    }
}
