
namespace GroupProject
{
    partial class BookPickupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_SearchShipmentNo = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CreateDate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CommodityCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_CenterID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.txt_Gateway = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvw_OrderList = new System.Windows.Forms.ListView();
            this.lbl_PackageCode = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PickupOrderID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Sender = new System.Windows.Forms.TextBox();
            this.txt_ShipmentNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_SelectPickupDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Insurance = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.dtp_SelectPickupTime = new System.Windows.Forms.DateTimePicker();
            this.btn_ShipmentDetail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SearchShipmentNo
            // 
            this.txt_SearchShipmentNo.Location = new System.Drawing.Point(95, 18);
            this.txt_SearchShipmentNo.Name = "txt_SearchShipmentNo";
            this.txt_SearchShipmentNo.Size = new System.Drawing.Size(562, 22);
            this.txt_SearchShipmentNo.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(663, 18);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 22);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "Create Date";
            // 
            // txt_CreateDate
            // 
            this.txt_CreateDate.Location = new System.Drawing.Point(268, 83);
            this.txt_CreateDate.Name = "txt_CreateDate";
            this.txt_CreateDate.ReadOnly = true;
            this.txt_CreateDate.Size = new System.Drawing.Size(235, 22);
            this.txt_CreateDate.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "Commodity Code";
            // 
            // txt_CommodityCode
            // 
            this.txt_CommodityCode.Location = new System.Drawing.Point(17, 133);
            this.txt_CommodityCode.Name = "txt_CommodityCode";
            this.txt_CommodityCode.ReadOnly = true;
            this.txt_CommodityCode.Size = new System.Drawing.Size(235, 22);
            this.txt_CommodityCode.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(512, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "Center ID";
            // 
            // txt_CenterID
            // 
            this.txt_CenterID.Location = new System.Drawing.Point(515, 34);
            this.txt_CenterID.Name = "txt_CenterID";
            this.txt_CenterID.ReadOnly = true;
            this.txt_CenterID.Size = new System.Drawing.Size(235, 22);
            this.txt_CenterID.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "Status";
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(268, 133);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ReadOnly = true;
            this.txt_Status.Size = new System.Drawing.Size(235, 22);
            this.txt_Status.TabIndex = 14;
            // 
            // txt_Gateway
            // 
            this.txt_Gateway.Location = new System.Drawing.Point(18, 83);
            this.txt_Gateway.Name = "txt_Gateway";
            this.txt_Gateway.ReadOnly = true;
            this.txt_Gateway.Size = new System.Drawing.Size(235, 22);
            this.txt_Gateway.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "Gateway ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shipment List:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Pickup Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvw_OrderList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_SearchShipmentNo);
            this.groupBox1.Controls.Add(this.lbl_PackageCode);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 215);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Package ";
            // 
            // lvw_OrderList
            // 
            this.lvw_OrderList.FullRowSelect = true;
            this.lvw_OrderList.GridLines = true;
            this.lvw_OrderList.HideSelection = false;
            this.lvw_OrderList.Location = new System.Drawing.Point(18, 65);
            this.lvw_OrderList.MultiSelect = false;
            this.lvw_OrderList.Name = "lvw_OrderList";
            this.lvw_OrderList.Size = new System.Drawing.Size(732, 139);
            this.lvw_OrderList.TabIndex = 5;
            this.lvw_OrderList.UseCompatibleStateImageBehavior = false;
            this.lvw_OrderList.View = System.Windows.Forms.View.Details;
            this.lvw_OrderList.SelectedIndexChanged += new System.EventHandler(this.lvw_OrderList_SelectedIndexChanged);
            // 
            // lbl_PackageCode
            // 
            this.lbl_PackageCode.AutoSize = true;
            this.lbl_PackageCode.Location = new System.Drawing.Point(20, 21);
            this.lbl_PackageCode.Name = "lbl_PackageCode";
            this.lbl_PackageCode.Size = new System.Drawing.Size(69, 12);
            this.lbl_PackageCode.TabIndex = 1;
            this.lbl_PackageCode.Text = "Shipment No:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pickup Order ID";
            // 
            // txt_PickupOrderID
            // 
            this.txt_PickupOrderID.Location = new System.Drawing.Point(514, 133);
            this.txt_PickupOrderID.Name = "txt_PickupOrderID";
            this.txt_PickupOrderID.ReadOnly = true;
            this.txt_PickupOrderID.Size = new System.Drawing.Size(235, 22);
            this.txt_PickupOrderID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Insurance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sender";
            // 
            // txt_Sender
            // 
            this.txt_Sender.Location = new System.Drawing.Point(268, 34);
            this.txt_Sender.Name = "txt_Sender";
            this.txt_Sender.ReadOnly = true;
            this.txt_Sender.Size = new System.Drawing.Size(235, 22);
            this.txt_Sender.TabIndex = 6;
            // 
            // txt_ShipmentNo
            // 
            this.txt_ShipmentNo.Location = new System.Drawing.Point(18, 34);
            this.txt_ShipmentNo.Name = "txt_ShipmentNo";
            this.txt_ShipmentNo.ReadOnly = true;
            this.txt_ShipmentNo.Size = new System.Drawing.Size(235, 22);
            this.txt_ShipmentNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Shipment No.";
            // 
            // dtp_SelectPickupDate
            // 
            this.dtp_SelectPickupDate.Location = new System.Drawing.Point(114, 408);
            this.dtp_SelectPickupDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtp_SelectPickupDate.MinDate = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            this.dtp_SelectPickupDate.Name = "dtp_SelectPickupDate";
            this.dtp_SelectPickupDate.Size = new System.Drawing.Size(197, 22);
            this.dtp_SelectPickupDate.TabIndex = 12;
            this.dtp_SelectPickupDate.Value = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_CreateDate);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_CommodityCode);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_CenterID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_Status);
            this.groupBox2.Controls.Add(this.txt_Gateway);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_PickupOrderID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_Insurance);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_Sender);
            this.groupBox2.Controls.Add(this.txt_ShipmentNo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 169);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Information";
            // 
            // txt_Insurance
            // 
            this.txt_Insurance.Location = new System.Drawing.Point(515, 83);
            this.txt_Insurance.Name = "txt_Insurance";
            this.txt_Insurance.ReadOnly = true;
            this.txt_Insurance.Size = new System.Drawing.Size(235, 22);
            this.txt_Insurance.TabIndex = 8;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Confirm.Location = new System.Drawing.Point(659, 407);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(122, 23);
            this.btn_Confirm.TabIndex = 15;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // dtp_SelectPickupTime
            // 
            this.dtp_SelectPickupTime.CustomFormat = "";
            this.dtp_SelectPickupTime.Location = new System.Drawing.Point(320, 408);
            this.dtp_SelectPickupTime.MinDate = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            this.dtp_SelectPickupTime.Name = "dtp_SelectPickupTime";
            this.dtp_SelectPickupTime.Size = new System.Drawing.Size(196, 22);
            this.dtp_SelectPickupTime.TabIndex = 16;
            this.dtp_SelectPickupTime.Value = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            // 
            // btn_ShipmentDetail
            // 
            this.btn_ShipmentDetail.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ShipmentDetail.Enabled = false;
            this.btn_ShipmentDetail.Location = new System.Drawing.Point(528, 407);
            this.btn_ShipmentDetail.Name = "btn_ShipmentDetail";
            this.btn_ShipmentDetail.Size = new System.Drawing.Size(122, 23);
            this.btn_ShipmentDetail.TabIndex = 17;
            this.btn_ShipmentDetail.Text = "Shipment Detail";
            this.btn_ShipmentDetail.UseVisualStyleBackColor = false;
            this.btn_ShipmentDetail.Click += new System.EventHandler(this.btn_ShipmentDetail_Click);
            // 
            // BookPickupForm
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 438);
            this.Controls.Add(this.btn_ShipmentDetail);
            this.Controls.Add(this.dtp_SelectPickupTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_SelectPickupDate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Confirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookPickupForm";
            this.Text = "BookPickupForm";
            this.Load += new System.EventHandler(this.BookPickupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_SearchShipmentNo;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_CreateDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_CommodityCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_CenterID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.TextBox txt_Gateway;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_PackageCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PickupOrderID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Sender;
        private System.Windows.Forms.TextBox txt_ShipmentNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_SelectPickupDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Insurance;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.ListView lvw_OrderList;
        private System.Windows.Forms.DateTimePicker dtp_SelectPickupTime;
        private System.Windows.Forms.Button btn_ShipmentDetail;
    }
}