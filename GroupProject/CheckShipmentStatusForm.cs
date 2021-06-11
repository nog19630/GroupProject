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
    public partial class CheckShipmentStatusForm : Form
    {
        public CheckShipmentStatusForm()
        {
            InitializeComponent();
        }

        private void CheckShipmentStatusForm_Load(object sender, EventArgs e)
        {
            // add columns to list view
            lvw_TrackShipmentList.Columns.Add("Shipment No", -2);
            lvw_TrackShipmentList.Items.Clear();

            fullList();
        }

        private void fullList()
        {
            lvw_TrackShipmentList.Items.Clear();

            // generate list data from database
            string sqlGetCustomerID = $"SELECT * FROM ede.edeaccount WHERE edeID = '{LoginForm.userId}';";
            DataRow drEdeAccount = DatabaseConnector.getDataRow(sqlGetCustomerID);
            string receiver = drEdeAccount["customerID"].ToString();


            string sqlGetShipmentNo = $"SELECT * FROM ede.shipment, ede.pickuporder WHERE pickuporder.shipmentNo = shipment.shipmentNo AND receiver = '{receiver}';";
            DataSet ds = DatabaseConnector.getDataSet(sqlGetShipmentNo, "shipment");

            if (ds.Tables["shipment"].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables["shipment"].Rows.Count; i++)
                {
                    lvw_TrackShipmentList.Items.Add(ds.Tables["shipment"].Rows[i]["shipmentNo"].ToString());
                }
            }
        }

        private void lvw_TrackShipmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvw_TrackShipmentList.SelectedItems.Count > 0)
            {
                string shipmentID, status, centerID, gatewayID, insurance, orderID, shipmentCreateDate, pickupDate, pickupTime;
                shipmentID = lvw_TrackShipmentList.SelectedItems[0].Text;

                // get data row
                DataRow drShipment, drPickupOrder;
                string sql = $"SELECT * FROM ede.shipment WHERE shipmentNo = '{shipmentID}';";
                drShipment = DatabaseConnector.getDataRow(sql);

                sql = $"SELECT * FROM ede.pickuporder WHERE shipmentNo = '{shipmentID}';";
                drPickupOrder = DatabaseConnector.getDataRow(sql);

                // full string (table: shipment)
                status = drShipment["status"].ToString();
                centerID = drShipment["centerID"].ToString();
                gatewayID = drShipment["gatewayID"].ToString();
                insurance = drShipment["insurance"].ToString();
                shipmentCreateDate = drShipment["date"].ToString();
                shipmentCreateDate = shipmentCreateDate.Replace(" 0:00:00", "");

                // full string (table: pickuporder)
                orderID = drPickupOrder["orderID"].ToString();
                pickupDate = drPickupOrder["pickupDate"].ToString();
                pickupDate = pickupDate.Replace(" 0:00:00", "");
                pickupTime = drPickupOrder["pickupTime"].ToString();

                // full string to label
                lbl_ShipmentNo.Text = shipmentID;
                lbl_Status.Text = status;
                lbl_CenterID.Text = (centerID != "") ? centerID : "- - -";
                lbl_GatewayID.Text = (gatewayID != "") ? gatewayID : "- - -";
                lbl_Insurance.Text = (insurance != "") ? insurance : "- - -"; ;
                lbl_PickupOrderID.Text = orderID;
                lbl_ShipmentCreateDate.Text = shipmentCreateDate;
                lbl_PickupDate.Text = pickupDate;
                lbl_PickupTime.Text = pickupTime;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            fullList();
            lbl_ShipmentNo.Text = "- - -";
            lbl_Status.Text = "- - -";
            lbl_CenterID.Text = "- - -";
            lbl_GatewayID.Text = "- - -";
            lbl_Insurance.Text = "- - -";
            lbl_PickupOrderID.Text = "- - -";
            lbl_ShipmentCreateDate.Text = "- - -";
            lbl_PickupDate.Text = "- - -";
            lbl_PickupTime.Text = "- - -";
        }
    }
}
