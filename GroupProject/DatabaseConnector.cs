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
        private static string database = "ede";
        private static string password = "root";
        private static MySqlConnection connection = new MySqlConnection();
        private static DataSet ds = new DataSet();
        private static string[] DBtable = { "customer", "documentfreight", "edeaccount", "freight", "invoice", "operationcenter", "paymentgateway", "pickuporder", "shipment", "staff", "vehicle" };
        private static MySqlCommand command;

        public static bool connectDatabase()
        {
            try
            {
                string constructorString = String.Format("Data Source={0};Port={1};User Id={2};database ={3};Password={4}", dataSource, port, userID, database,password);
                connection = new MySqlConnection(constructorString);
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    for (int i = 0; i < DBtable.Length; i++)
                    {
                        string sqlString = "SELECT * FROM ede." + DBtable[i];
                        MySqlDataAdapter adapter = new MySqlDataAdapter(sqlString, connection);
                        adapter.Fill(ds, DBtable[i]);
                        adapter.Dispose();
                    }
                    return true;
                }
                else
                {
                    ds = null;
                    MessageBox.Show("Connection Failed");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static void closeDatabase()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public static MySqlConnection getConnetion()
        {
            return connection;
        }

        public static DataSet getDataSet()
        {
            connectDatabase();
            DataSet tempDs = ds.Clone();
            closeDatabase();
            return tempDs;
        }

        public static DataSet getDataSet(string query, string tableName)
        {
            try
            {
                if (connectDatabase())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    ds.Reset();
                    adapter.Fill(ds, tableName);
                    adapter.Dispose();
                    DataSet tempDs = ds.Copy();
                    return tempDs;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                closeDatabase();
            }
        }

        public static DataRow getDataRow(string query)
        {
            DataSet ds = getDataSet(query, "table");
            return ds.Tables["table"].Rows[0];
        }

        public static bool executeQuery(string query)
        {
            try
            {
                if (connectDatabase())
                {
                    command = new MySqlCommand(query, connection);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } else
                {
                    return false;
                }
                
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                closeDatabase();
            }
            
        }

        public static bool matchQuery(string query)
        {
            try
            {
                if (connectDatabase())
                {
                    command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        return false;
                    }
                } 
                else
                {
                    return false;
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                closeDatabase();
            }
        }

        public static string getUserID(string user, string sql) {
            connectDatabase();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@name", user);
            cmd.CommandType = CommandType.Text;
            using (MySqlDataReader dr = cmd.ExecuteReader()) {
                dr.Read();
                return dr["customerID"].ToString();
            }
                
        }

        public static string getStaffPos(string user, string sql)
        {
            connectDatabase();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@name", user);
            cmd.CommandType = CommandType.Text;
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                dr.Read();
                return dr["position"].ToString();
            }

        }
        public static void GridFill(DataGridView control,string sql) //Filling datagridview with package to be filled with bill
        {

            connectDatabase();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@user", LoginForm.customerId);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.SelectCommand.CommandType = CommandType.Text;

            DataTable dt = new DataTable();
            cmd.ExecuteNonQuery();
            da.Fill(dt);
            control.DataSource = dt;

            closeDatabase();

        }

        

    }



}
