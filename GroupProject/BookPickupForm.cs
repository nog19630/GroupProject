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
    public partial class BookPickupForm : Form
    {

        public static string currencyShipmentNo;

        public BookPickupForm()
        {
            InitializeComponent();
        }

        private void BookPickupForm_Load(object sender, EventArgs e)
        {
            dtp_SelectPickupTime.Format = DateTimePickerFormat.Custom;
            dtp_SelectPickupTime.ShowUpDown = true;
            dtp_SelectPickupTime.CustomFormat = "hh:mm";

            dtp_SelectPickupDate.Format = DateTimePickerFormat.Custom;
            dtp_SelectPickupDate.CustomFormat = "yy-MM-dd";

            lvw_OrderList.Columns.Add("Shipment No", 120);
            lvw_OrderList.Columns.Add("Sender", 120);
            lvw_OrderList.Columns.Add("Center ID", 120);
            lvw_OrderList.Columns.Add("Gateway ID", 120);
            lvw_OrderList.Columns.Add("Date", 120);
            lvw_OrderList.Columns.Add("Status", -2);

            fullList();
        }

        private void fullList(bool showMessage = false)
        {
            clearData();
            btn_ShipmentDetail.Enabled = false;
            string sql = $"SELECT * FROM ede.shipment WHERE shipmentNo LIKE '{txt_SearchShipmentNo.Text.ToString()}%' AND receiver = '{LoginForm.customerId}'";
            DataSet ds = DatabaseConnector.getDataSet(sql, "shipment");
            if (lvw_OrderList.Items.Count > 0)
            {
                lvw_OrderList.Items.Clear();
            }

            if (ds.Tables["shipment"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["shipment"].Rows.Count; i++)
                {
                    string shipmentNo = ds.Tables["shipment"].Rows[i]["shipmentNo"].ToString();
                    string sender = ds.Tables["shipment"].Rows[i]["sender"].ToString();
                    string centerID = ds.Tables["shipment"].Rows[i]["centerID"].ToString();
                    string gatewayID = ds.Tables["shipment"].Rows[i]["gatewayID"].ToString();
                    string date = ds.Tables["shipment"].Rows[i]["date"].ToString();
                    date = date.Replace(" 0:00:00", "");  
                    string status = ds.Tables["shipment"].Rows[i]["status"].ToString();
                    
                    ListViewItem lvi = new ListViewItem(shipmentNo);
                    lvi.SubItems.Add(sender);
                    lvi.SubItems.Add(centerID);
                    lvi.SubItems.Add(gatewayID);
                    lvi.SubItems.Add(date);
                    lvi.SubItems.Add(status);
                    lvw_OrderList.Items.Add(lvi);
                }
            }
            else
            {
                if (showMessage)
                {
                    MessageBox.Show("Not Match Package Code");
                }       
            }
        }

        private void clearData()
        {
            txt_ShipmentNo.Text = "";
            txt_Sender.Text = "";
            txt_CommodityCode.Text = "";
            txt_CenterID.Text = "";
            txt_Gateway.Text = "";
            txt_CreateDate.Text = "";
            txt_Insurance.Text = "";
            txt_Status.Text = "";
            txt_PickupOrderID.Text = "";
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            fullList(true);
        }

        private void lvw_OrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_ShipmentDetail.Enabled = true;
            if (lvw_OrderList.SelectedItems.Count > 0)
            {
                currencyShipmentNo = lvw_OrderList.SelectedItems[0].Text;
                string shipmentNo = currencyShipmentNo;
                string sql;
                DataRow drShipment;

                sql = $"SELECT * FROM ede.shipment WHERE shipmentNo = '{shipmentNo}'";
                drShipment = DatabaseConnector.getDataRow(sql);

                txt_ShipmentNo.Text = shipmentNo;
                txt_Sender.Text = drShipment["sender"].ToString();
                txt_CommodityCode.Text = drShipment["commodityCode"].ToString();
                txt_CenterID.Text = drShipment["centerID"].ToString();
                txt_Gateway.Text = drShipment["gatewayID"].ToString();
                string date = drShipment["date"].ToString();
                date = date.Replace(" 0:00:00", "");
                txt_CreateDate.Text = date;
                txt_Insurance.Text = drShipment["insurance"].ToString();
                txt_Status.Text = drShipment["status"].ToString();
                txt_PickupOrderID.Text = drShipment["orderID"].ToString();
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (txt_Status.Text != "Booked")
            {
                DialogResult result = MessageBox.Show("Determine the upload data?", "Upload Pickup Order Message", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    string pickupOrderTime = dtp_SelectPickupTime.Text;
                    string shipmentNo = currencyShipmentNo;
                    string orderId;
                    string sql;

                    //order id format{12}: YYMMDD{6} + TIME{6}
                    orderId = DateTime.Now.ToString("yyMMddhhmmss");
                    sql = $"INSERT INTO ede.pickuporder VALUES ('{orderId}', '{LoginForm.userId}', '{dtp_SelectPickupDate.Text}', '{pickupOrderTime}', '{shipmentNo}');";
                    if (DatabaseConnector.executeQuery(sql))
                    {
                        sql = $"UPDATE ede.shipment SET status = 'Booked' WHERE shipmentNo = '{shipmentNo}';";
                        if (DatabaseConnector.executeQuery(sql))
                        {
                            sql = $"UPDATE ede.shipment SET orderID = '{orderId}' WHERE shipmentNo = '{shipmentNo}';";
                            if (DatabaseConnector.executeQuery(sql))
                            {
                                MessageBox.Show("Submitted successfully");
                            }
                            else
                            {
                                MessageBox.Show("Submission failure");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Submission failure");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Submission failure");
                    }
                    fullList();
                }
            }
            else
            {
                MessageBox.Show("Shipment has been booked");
            }
           
        }

        private void btn_ShipmentDetail_Click(object sender, EventArgs e)
        {
            ShowDetailShipmentInfoForm showDetailShipmentInfoForm = new ShowDetailShipmentInfoForm();
            showDetailShipmentInfoForm.ShowDialog();
        }
    }
}
