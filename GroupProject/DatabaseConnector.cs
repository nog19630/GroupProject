using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GroupProject
{

    public static class DatabaseConnector
    {
        private static string dataSource = "localhost";
        private static string port = "3306";
        private static string userID = "root";
        private static string password = "root";
        private static MySqlConnection connection;
        private static DataSet ds = new DataSet();
        private static string[] DBtable = { "customer", "documentfreight", "edeaccount", "frieght", "invoice", "operationcenter", "paymentgateway", "pickuporder", "shipment", "staff", "vehicle" };
        private static MySqlCommand command;

        public static void connectDatabase()
        {
            try
            {
                string constructorString = String.Format("Data Source={0};Port={1};User Id={2};Password={3}", dataSource, port, userID, password);
                connection = new MySqlConnection(constructorString);
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    for (int i = 0; i < DBtable.Length; i++)
                    {
                        string sqlString = "SELECT * FROM ede." + DBtable[i];
                        MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connection);
                        adapter.Fill(ds, DBtable[i]);
                    }
                }
                else
                {
                    ds = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void closeDatabase()
        {
            connection.Close();
        }

        public static DataSet getDataSet()
        {
            return ds;
        }

        public static void executeQuery(string query)
        {
            try
            {
                connectDatabase();
                command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                } 
                else {
                    MessageBox.Show("Query Not Executed");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeDatabase();
            }
            
        }
    }

}
