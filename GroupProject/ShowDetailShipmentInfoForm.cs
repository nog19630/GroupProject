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
    public partial class ShowDetailShipmentInfoForm : Form
    {
        public ShowDetailShipmentInfoForm()
        {
            InitializeComponent();
        }

        private void ShowDetailShipmentInfoForm_Load(object sender, EventArgs e)
        {
            lvw_DocumentFreightList.Columns.Add("Item ID", 90);
            lvw_DocumentFreightList.Columns.Add("Name", 90);
            lvw_DocumentFreightList.Columns.Add("Quantity", 60);
            lvw_DocumentFreightList.Columns.Add("Service Type", 90);
            lvw_DocumentFreightList.Columns.Add("Charge", 60);
            lvw_DocumentFreightList.Columns.Add("Shipment No", -2);

            fullList();
        }

        private void fullList()
        {
            string shipmentNo = BookPickupForm.currencyShipmentNo;
            string sql = $"SELECT * FROM ede.documentfreight WHERE shipmentNo = '{shipmentNo}';";
            DataSet dsDocumentFreight = DatabaseConnector.getDataSet(sql, "documentfreight");

            for (int i = 0; i < dsDocumentFreight.Tables["documentfreight"].Rows.Count; i++)
            {
                // documentfreight table
                string itemID = dsDocumentFreight.Tables["documentfreight"].Rows[i]["itemID"].ToString();
                string name = dsDocumentFreight.Tables["documentfreight"].Rows[i]["name"].ToString();
                string quantity = dsDocumentFreight.Tables["documentfreight"].Rows[i]["quantity"].ToString();
                string serviceType = dsDocumentFreight.Tables["documentfreight"].Rows[i]["serviceType"].ToString();
                string charge = dsDocumentFreight.Tables["documentfreight"].Rows[i]["charge"].ToString();
                
                ListViewItem lvi = new ListViewItem(itemID);
                lvi.SubItems.Add(name);
                lvi.SubItems.Add(quantity);
                lvi.SubItems.Add(serviceType);
                lvi.SubItems.Add(charge);
                lvi.SubItems.Add(shipmentNo);
                lvw_DocumentFreightList.Items.Add(lvi);

            }
        }

        private void lvw_DocumentFreightList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lvw_DocumentFreightList.SelectedItems.Count > 0)
            {
                string itemID = lvw_DocumentFreightList.SelectedItems[0].Text;

                string sql = $"SELECT * FROM ede.documentfreight WHERE itemID = '{itemID}';";
                DataRow drDocumentFreight = DatabaseConnector.getDataRow(sql);

                sql = $"SELECT * FROM ede.frieght WHERE itemID = '{itemID}';";
                DataRow drFreight = DatabaseConnector.getDataRow(sql);

                // DocumentFreight table
                string name = drDocumentFreight["name"].ToString();
                string quantity = drDocumentFreight["quantity"].ToString();
                string serviceType = drDocumentFreight["serviceType"].ToString();
                string serviceOtherType = drDocumentFreight["serviceOtherType"].ToString();
                string centerID = drDocumentFreight["centerID"].ToString();
                string charge = drDocumentFreight["charge"].ToString();
                string description = drDocumentFreight["description"].ToString();

                // Freight table
                string weight = drFreight["weight"].ToString();
                string length = drFreight["length"].ToString();
                string width = drFreight["width"].ToString();
                string height = drFreight["height"].ToString();
                string value = drFreight["value"].ToString();

                // add to the text box
                txt_ItemID.Text = itemID;
                txt_Name.Text = name;
                txt_Quantity.Text = quantity;
                txt_ServiceType.Text = serviceType;
                txt_ServiceOtherType.Text = serviceOtherType;
                txt_CenterID.Text = centerID;
                txt_ShipmentNo.Text = BookPickupForm.currencyShipmentNo;
                txt_Charge.Text = charge;
                txt_Weight.Text = weight;
                txt_Length.Text = length;
                txt_Width.Text = width;
                txt_Height.Text = height;
                txt_Value.Text = value;
                txt_Description.Text = description;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
