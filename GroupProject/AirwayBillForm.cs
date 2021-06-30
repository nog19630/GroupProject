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
    public partial class AirwayBillForm : Form
    {
        private string connection = "server=localhost;user id=root;database=ede;password=root";
        private string cusID;
        public AirwayBillForm(string cusID)
        {
            InitializeComponent();
            this.cusID = cusID;
        }

        private void AirwayBillForm_Load(object sender, EventArgs e)
        {
            DatabaseConnector.GridFill(dgv_pack, "SELECT * FROM Shipment WHERE sender = @user AND status = 'wait_bill';");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the form?", "Reset Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AirwayBillForm resetfrm = new AirwayBillForm(cusID);
                resetfrm.Show();
                this.Dispose();
            }
        }
        private void dgv_pack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_pack.CurrentCell != null || dgv_pack.CurrentRow.ToString() != "")
            {
                grp_info.Enabled = true;
                if (dgv_pack.CurrentRow.Cells[8].Value.ToString() == "D")// D = document F = freight
                {
                    num_quant.Enabled = false;
                    num_weight.Enabled = true;
                    num_height.Enabled = false;
                    num_length.Enabled = false;
                    num_width.Enabled = false;
                }
                else
                {
                    num_quant.Enabled = true;
                    num_weight.Enabled = true;
                    num_height.Enabled = true;
                    num_length.Enabled = true;
                    num_width.Enabled = true;
                }
            }
        }
 
        private void radio_express_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_express.Checked)
            {
                grp_package.Enabled = true;
            }
            else
            {
                grp_package.Enabled = false;
            }
        }

        private double calculateCharge()
        {
            double charge = 0;
            try
            {
                if (dgv_pack.CurrentRow.Cells[8].Value.ToString() == "D")
                {
                    if (((double)num_weight.Value <= 0.5))
                    {
                        charge = 158;
                    }
                    else
                    {
                        charge = 150 + (((double)num_weight.Value - 0.5) / 0.5);
                    }
                }
                else
                {

                    if (dgv_pack.CurrentRow.Cells[3].Value.ToString().Substring(0, 2) == "AU")
                    {
                        if (num_weight.Value < 15)
                        {
                            charge = (double)num_weight.Value * 75;
                        }
                        else if (num_weight.Value < 29)
                        {
                            charge = (double)num_weight.Value * 70;
                        }
                        else if (num_weight.Value < 44)
                        {
                            charge = (double)num_weight.Value * 65;
                        }
                        else if (num_weight.Value < 69)
                        {
                            charge = (double)num_weight.Value * 62;
                        }
                        else if (num_weight.Value < 99)
                        {
                            charge = (double)num_weight.Value * 61;
                        }
                        else if (num_weight.Value < 499)
                        {
                            charge = (double)num_weight.Value * 58;
                        }
                        else if (num_weight.Value < 999)
                        {
                            charge = (double)num_weight.Value * 58;
                        }

                    }
                    else if (dgv_pack.CurrentRow.Cells[3].Value.ToString().Substring(0, 2) == "JP")
                    {
                        if (num_weight.Value < 15)
                        {
                            charge = (double)num_weight.Value * 75;
                        }
                        else if (num_weight.Value < 29)
                        {
                            charge = (double)num_weight.Value * 70;
                        }
                        else if (num_weight.Value < 44)
                        {
                            charge = (double)num_weight.Value * 65;
                        }
                        else if (num_weight.Value < 69)
                        {
                            charge = (double)num_weight.Value * 62;
                        }
                        else if (num_weight.Value < 99)
                        {
                            charge = (double)num_weight.Value * 61;
                        }
                        else if (num_weight.Value < 499)
                        {
                            charge = (double)num_weight.Value * 58;
                        }
                        else if (num_weight.Value < 999)
                        {
                            charge = (double)num_weight.Value * 58;
                        }
                    }
                    else if (dgv_pack.CurrentRow.Cells[3].Value.ToString().Substring(0, 2) == "SH")
                    {
                        if (num_weight.Value < 15)
                        {
                            charge = (double)num_weight.Value * 45;
                        }
                        else if (num_weight.Value < 29)
                        {
                            charge = (double)num_weight.Value * 40;
                        }
                        else if (num_weight.Value < 44)
                        {
                            charge = (double)num_weight.Value * 37;
                        }
                        else if (num_weight.Value < 69)
                        {
                            charge = (double)num_weight.Value * 35;
                        }
                        else if (num_weight.Value < 99)
                        {
                            charge = (double)num_weight.Value * 33;
                        }
                        else if (num_weight.Value < 499)
                        {
                            charge = (double)num_weight.Value * 32;
                        }
                        else if (num_weight.Value < 999)
                        {
                            charge = (double)num_weight.Value * 32;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid input.\n" + e.Message);
            }

            return charge;
        }

        private void btn_calculate_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Charge of shipment: $" + calculateCharge());
        }

        private void btn_submit_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlcon = new MySqlConnection(connection))
            {
                try
                {
                    string service = "";
                    if (radio_doc.Checked)
                    {
                        service = radio_doc.Text;
                    }
                    else if (radio_pack.Checked)
                    {
                        service = radio_pack.Text;
                    }
                    else if (radio_express.Checked)
                    {
                        service = radio_express.Text;
                    }
                    else if (radio_domestic.Checked)
                    {
                        service = radio_domestic.Text;
                    }
                    else if (radio_world.Checked)
                    {
                        service = radio_world.Text;
                    }
                    else if (radio_other.Checked)
                    {
                        service = radio_other.Text;
                    }
                    if (dgv_pack.CurrentRow.Cells[8].Value.ToString() == "D")// D = document F = freight
                    {
                        string sql = "INSERT INTO documentfreight (name,quantity,serviceType,serviceOtherType,declaredvalue,centerID,shipmentNo,charge,description) VALUES(" +
                            "@name,@quantity, @service, @othertype, @declaredval,@center ,@shipmentno, @charge, @desc);";

                        mysqlcon.Open();
                        MySqlCommand cmd = new MySqlCommand(sql, mysqlcon);
                        cmd.Parameters.AddWithValue("@name", txt_recname.Text);
                        cmd.Parameters.AddWithValue("@quantity", num_quant.Value);
                        cmd.Parameters.AddWithValue("@service", service);
                        cmd.Parameters.AddWithValue("@othertype", txt_others.Text);
                        cmd.Parameters.AddWithValue("@declaredval", num_declared.Value);
                        cmd.Parameters.AddWithValue("@center", dgv_pack.CurrentRow.Cells[3].Value);
                        cmd.Parameters.AddWithValue("@shipmentno", dgv_pack.CurrentRow.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@charge", calculateCharge());
                        cmd.Parameters.AddWithValue("@desc", txt_desc.Text);
                        cmd.CommandType = CommandType.Text;
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            if (DatabaseConnector.executeQuery("UPDATE shipment " +
                                "SET status = 'wait_pay' " +
                                "WHERE shipmentNo = " + dgv_pack.CurrentRow.Cells[0].Value + ";"))
                                MessageBox.Show("Airway bill successfully submitted.");
                            else
                                MessageBox.Show("Failed to submit airway bill.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit airway bill.");
                        }
                    }
                    else
                    {
                        string sql = "INSERT INTO documentfreight (name,quantity,serviceType,serviceOtherType,declaredvalue,centerID,shipmentNo,charge,description) VALUES(" +
                        "@name, @quantity, @service, @othertype, @declaredval, @center, @shipmentno, @charge, @desc);" +
                        "INSERT INTO freight (weight, length, width, height, value) VALUES(" +
                        "@weight, @length, @width, @height, NULL);";


                        MySqlCommand cmd = new MySqlCommand(sql, mysqlcon);
                        cmd.Parameters.AddWithValue("@quantity", num_quant.Value);
                        cmd.Parameters.AddWithValue("@service", service);
                        cmd.Parameters.AddWithValue("@othertype", txt_others.Text);
                        cmd.Parameters.AddWithValue("@declaredval", num_declared.Value);
                        cmd.Parameters.AddWithValue("@center", dgv_pack.CurrentRow.Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("@shipmentno", dgv_pack.CurrentRow.Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@charge", calculateCharge());
                        cmd.Parameters.AddWithValue("@desc", txt_desc.Text);
                        cmd.Parameters.AddWithValue("@weight", num_weight.Value);
                        cmd.Parameters.AddWithValue("@length", num_length.Value);
                        cmd.Parameters.AddWithValue("@width", num_width.Value);
                        cmd.Parameters.AddWithValue("@height", num_height.Value);
                        cmd.CommandType = CommandType.Text;
                        if (cmd.ExecuteNonQuery() >= 1)
                        {
                            if (DatabaseConnector.executeQuery("UPDATE shipment " +
                           "SET status = 'wait_pay' " +
                           "WHERE shipmentNo = " + dgv_pack.CurrentRow.Cells[0].Value + ";"))
                                MessageBox.Show("Airway bill successfully submitted.");
                            else
                                MessageBox.Show("Failed to submit airway bill.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to submit airway bill.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mysqlcon.Close();
                }
            }


        }
    }
}
