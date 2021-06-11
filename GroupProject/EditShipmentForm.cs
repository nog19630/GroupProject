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
    public partial class EditShipmentForm : Form
    {
        public static string ShipmentNo;
        public static string SelectedStatus;

        public EditShipmentForm()
        {
            InitializeComponent();
        }

        private void EditPickupForm_Load(object sender, EventArgs e)
        {
            dtp_SelectPickupTime.Format = DateTimePickerFormat.Custom;
            dtp_SelectPickupTime.ShowUpDown = true;
            dtp_SelectPickupTime.CustomFormat = "hh:mm";

            dtp_SelectPickupDate.Format = DateTimePickerFormat.Custom;
            dtp_SelectPickupDate.CustomFormat = "yy-MM-dd";

            cmb_SearchType.Items.Add("Shipment");
            cmb_SearchType.Items.Add("Pickup Order");
            
            cmb_SearchType.SelectedItem = "Shipment";

            fullList();
        }

        private void fullList(bool showMessage = false)
        {
            cmb_Status.DropDownHeight = 106;
            string searchText = txt_SearchText.Text;
            string sql;
            string selectType = (cmb_SearchType.SelectedIndex == 0) ? "shipmentNo" : "pickuporder";
            if (cmb_SearchType.SelectedIndex == 1)
            {
                sql = $"SELECT * FROM ede.pickuporder WHERE orderID LIKE '{searchText}%';";
                
            }
            else
            {
                sql = $"SELECT * FROM ede.shipment WHERE shipmentNo LIKE '{searchText}%';";
            }
            DataSet ds = DatabaseConnector.getDataSet(sql, selectType);
            
            if (lvw_OrderList.Items.Count > 0)
            {
                lvw_OrderList.Items.Clear();
            }

            if (ds.Tables[selectType].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[selectType].Rows.Count; i++)
                {
                    if (cmb_SearchType.SelectedIndex == 1)
                    {
                        string orderID = ds.Tables["pickuporder"].Rows[i]["orderID"].ToString();
                        string edeId = ds.Tables["pickuporder"].Rows[i]["edeID"].ToString();
                        string pickupDate = ds.Tables["pickuporder"].Rows[i]["pickupDate"].ToString();
                        pickupDate = pickupDate.Replace(" 0:00:00", "");
                        string pickupTime = ds.Tables["pickuporder"].Rows[i]["pickupTime"].ToString();
                        string shipmentNo = ds.Tables["pickuporder"].Rows[i]["shipmentNo"].ToString();
                        ListViewItem lvi = new ListViewItem(orderID);
                        lvi.SubItems.Add(edeId);
                        lvi.SubItems.Add(pickupDate);
                        lvi.SubItems.Add(pickupTime);
                        lvi.SubItems.Add(shipmentNo);
                        lvw_OrderList.Items.Add(lvi);
                    }
                    else
                    {
                        string shipmentNo = ds.Tables["shipmentNo"].Rows[i]["shipmentNo"].ToString();
                        string sender = ds.Tables["shipmentNo"].Rows[i]["sender"].ToString();
                        string receiver = ds.Tables["shipmentNo"].Rows[i]["receiver"].ToString();
                        string centerID = ds.Tables["shipmentNo"].Rows[i]["centerID"].ToString();
                        string gatewayID = ds.Tables["shipmentNo"].Rows[i]["gatewayID"].ToString();
                        string date = ds.Tables["shipmentNo"].Rows[i]["date"].ToString();
                        date = date.Replace(" 0:00:00", "");
                        string insurance = ds.Tables["shipmentNo"].Rows[i]["insurance"].ToString();
                        string commodityCode = ds.Tables["shipmentNo"].Rows[i]["commodityCode"].ToString();
                        string status = ds.Tables["shipmentNo"].Rows[i]["status"].ToString();
                        ListViewItem lvi = new ListViewItem(shipmentNo);
                        lvi.SubItems.Add(sender);
                        lvi.SubItems.Add(receiver);
                        lvi.SubItems.Add(centerID);
                        lvi.SubItems.Add(gatewayID);
                        lvi.SubItems.Add(date);
                        lvi.SubItems.Add(insurance);
                        lvi.SubItems.Add(commodityCode);
                        lvi.SubItems.Add(status);
                        lvw_OrderList.Items.Add(lvi);
                    }
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            fullList(true);
        }

        private void cmb_SearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearData();
            btn_UpdateStatus.Enabled = false;
            btn_DeletePickupOrder.Enabled = false;
            btn_UpdatePickupDataTime.Enabled = false;
            
            lvw_OrderList.Columns.Clear();
            if (cmb_SearchType.SelectedIndex == 1)
            {
                lvw_OrderList.Columns.Add("Pickup Order ID", 100);
                lvw_OrderList.Columns.Add("Ede Account ID", 100);
                lvw_OrderList.Columns.Add("Pickup Date", 100);
                lvw_OrderList.Columns.Add("Pickup Time", 100);
                lvw_OrderList.Columns.Add("Shipment No", 100);
            }
            else
            {
                lvw_OrderList.Columns.Add("Shipment No", 100);
                lvw_OrderList.Columns.Add("Sender", 80);
                lvw_OrderList.Columns.Add("Receiver", 80);
                lvw_OrderList.Columns.Add("Center ID", 70);
                lvw_OrderList.Columns.Add("Gateway ID", 70);
                lvw_OrderList.Columns.Add("Create Date", 70);
                lvw_OrderList.Columns.Add("Insurance", 70);
                lvw_OrderList.Columns.Add("Commodity Code", 100);
                lvw_OrderList.Columns.Add("Status", -2);
            }
            fullList();
        }

        private void clearData()
        {
            txt_OrderID.Text = "";
            txt_EdeACcountID.Text = "";
            dtp_SelectPickupDate.Text = DateTime.Now.ToString();
            dtp_SelectPickupTime.Text = DateTime.Now.ToString();
            txt_ShipmentNo.Text = "";
            txt_Sender.Text = "";
            txt_Receiver.Text = "";
            txt_CenterID.Text = "";
            txt_GatewayID.Text = "";
            txt_CreateDate.Text = "";
            txt_Insurance.Text = "";
            cmb_Status.Items.Clear();
        }

        private void lvw_OrderList_SelectedIndexChanged(object s, EventArgs e)
        {
            if (lvw_OrderList.SelectedItems.Count > 0)
            {
                clearData();
                cmb_Status.Items.Add("Ordered");
                cmb_Status.Items.Add("Transit");
                cmb_Status.Items.Add("Reservation");
                cmb_Status.Items.Add("Booked");
                cmb_Status.Items.Add("PickedUp");

                
                btn_UpdateStatus.Enabled = true;
                btn_DeletePickupOrder.Enabled = false;
                btn_UpdatePickupDataTime.Enabled = false;

                string sql;
                DataRow drShipment, drPickupOrder;

                // shipment table
                string shipmentNo, sender, receiver, centerID, gatewayID, date, insurance, status;
                shipmentNo = (cmb_SearchType.SelectedIndex == 1) ? lvw_OrderList.SelectedItems[0].SubItems[4].Text : lvw_OrderList.SelectedItems[0].Text;
                
                sql = $"SELECT * FROM ede.shipment WHERE shipmentNo = '{shipmentNo}';";
                drShipment = DatabaseConnector.getDataRow(sql);

                // add to the text box (shipment)
                
                sender = drShipment["sender"].ToString();
                receiver = drShipment["receiver"].ToString();
                centerID = drShipment["centerID"].ToString();
                gatewayID = drShipment["gatewayID"].ToString();
                date = drShipment["date"].ToString();
                date = date.Replace(" 0:00:00", "");
                insurance = drShipment["insurance"].ToString();
                status = drShipment["status"].ToString();

                // pickup order
                string orderID, edeID, pickupDate, pickupTime;
                orderID = (cmb_SearchType.SelectedIndex == 1) ? lvw_OrderList.SelectedItems[0].Text : drShipment["orderID"].ToString();

                if (orderID != "")
                {
                    btn_DeletePickupOrder.Enabled = true;
                    btn_UpdatePickupDataTime.Enabled = true;
                    sql = $"SELECT * FROM ede.pickuporder WHERE orderID = '{orderID}';";
                    drPickupOrder = DatabaseConnector.getDataRow(sql);


                    // add to the text box (pickup order)
                    edeID = drPickupOrder["edeID"].ToString();
                    pickupDate = drPickupOrder["pickupDate"].ToString();
                    pickupDate = pickupDate.Replace(" 0:00:00", "");
                    pickupTime = drPickupOrder["pickupTime"].ToString();

                    txt_OrderID.Text = orderID;
                    txt_EdeACcountID.Text = edeID;
                    dtp_SelectPickupDate.Text = pickupDate;
                    dtp_SelectPickupTime.Text = pickupTime;
                }
                
                txt_ShipmentNo.Text = shipmentNo;
                txt_Sender.Text = sender;
                txt_Receiver.Text = receiver;
                txt_CenterID.Text = centerID;
                txt_GatewayID.Text = gatewayID;
                txt_CreateDate.Text = date;
                txt_Insurance.Text = insurance;

                switch (status)
                {
                    case "Ordered":
                        cmb_Status.SelectedIndex = 0;
                        break;
                    case "Transit":
                        cmb_Status.SelectedIndex = 1;
                        break;
                    case "Reservation":
                        cmb_Status.SelectedIndex = 2;
                        break;
                    case "Booked":
                        cmb_Status.SelectedIndex = 3;
                        break;
                    case "PickedUp":
                        cmb_Status.SelectedIndex = 4;
                        break;
                }

            }
        }

        private void btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            ShipmentNo = txt_ShipmentNo.Text;
            SelectedStatus = cmb_Status.SelectedItem.ToString();
            UpdateShipmentStatusForm updateStatusForm = new UpdateShipmentStatusForm();
            updateStatusForm.ShowDialog();
            fullList();
        }

        private void btn_DeletePickupOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Determine the delete pickup order?", "Delete Pickup Order Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string orderID = txt_OrderID.Text;
                string sql = $"DELETE FROM ede.pickuporder WHERE orderID = '{orderID}';";
                if (DatabaseConnector.executeQuery(sql))
                {
                    sql = $"UPDATE ede.shipment SET status = 'Reservation' WHERE orderID = '{orderID}';"; 
                    if (DatabaseConnector.executeQuery(sql))
                    {
                        sql = $"UPDATE ede.shipment SET orderID = NULL WHERE orderID = '{orderID}';";
                        if (DatabaseConnector.executeQuery(sql))
                        {
                            MessageBox.Show("Delete Success");
                        }     
                    }
                    else
                    {
                        MessageBox.Show("Delete Failure");
                    }
                }
                else
                {
                    MessageBox.Show("Delete Failure");
                }
                fullList();
            }
        }

        private void btn_UpdatePickupDataTime_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Determine the Update pickup date and time?", "Update Pickup Order Time Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                string orderID = txt_OrderID.Text;
                string date = dtp_SelectPickupDate.Text;
                string time = dtp_SelectPickupTime.Text;
                string sql = $"UPDATE ede.pickuporder SET pickupDate = '{date}', pickupTime = '{time}' WHERE orderID = '{orderID}';";
                if (DatabaseConnector.executeQuery(sql))
                {
                    MessageBox.Show("Update Success");
                }
                else
                {
                    MessageBox.Show("Update Failure");
                }
                fullList();
            }

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            fullList();
            btn_DeletePickupOrder.Enabled = false;
            btn_UpdateStatus.Enabled = false;
            btn_UpdatePickupDataTime.Enabled = false;
            clearData();
        }
    }
}
