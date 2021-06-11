
namespace GroupProject
{
    partial class EditShipmentForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_EdeACcountID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvw_OrderList = new System.Windows.Forms.ListView();
            this.lbl_PackageCode = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_SearchType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SearchText = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtp_SelectPickupTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_SelectPickupDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_CreateDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Insurance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_GatewayID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CenterID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Receiver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Sender = new System.Windows.Forms.TextBox();
            this.txt_ShipmentNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_UpdateStatus = new System.Windows.Forms.Button();
            this.btn_DeletePickupOrder = new System.Windows.Forms.Button();
            this.btn_UpdatePickupDataTime = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pickup Time";
            // 
            // txt_EdeACcountID
            // 
            this.txt_EdeACcountID.Location = new System.Drawing.Point(195, 34);
            this.txt_EdeACcountID.Name = "txt_EdeACcountID";
            this.txt_EdeACcountID.ReadOnly = true;
            this.txt_EdeACcountID.Size = new System.Drawing.Size(162, 22);
            this.txt_EdeACcountID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ede Account ID";
            // 
            // lvw_OrderList
            // 
            this.lvw_OrderList.FullRowSelect = true;
            this.lvw_OrderList.GridLines = true;
            this.lvw_OrderList.HideSelection = false;
            this.lvw_OrderList.Location = new System.Drawing.Point(18, 65);
            this.lvw_OrderList.MultiSelect = false;
            this.lvw_OrderList.Name = "lvw_OrderList";
            this.lvw_OrderList.Size = new System.Drawing.Size(732, 123);
            this.lvw_OrderList.TabIndex = 5;
            this.lvw_OrderList.UseCompatibleStateImageBehavior = false;
            this.lvw_OrderList.View = System.Windows.Forms.View.Details;
            this.lvw_OrderList.SelectedIndexChanged += new System.EventHandler(this.lvw_OrderList_SelectedIndexChanged);
            // 
            // lbl_PackageCode
            // 
            this.lbl_PackageCode.AutoSize = true;
            this.lbl_PackageCode.Location = new System.Drawing.Point(20, 23);
            this.lbl_PackageCode.Name = "lbl_PackageCode";
            this.lbl_PackageCode.Size = new System.Drawing.Size(120, 12);
            this.lbl_PackageCode.TabIndex = 1;
            this.lbl_PackageCode.Text = "Order ID / Shipment No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_SearchType);
            this.groupBox1.Controls.Add(this.lvw_OrderList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_SearchText);
            this.groupBox1.Controls.Add(this.lbl_PackageCode);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 201);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Pickup Order";
            // 
            // cmb_SearchType
            // 
            this.cmb_SearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchType.FormattingEnabled = true;
            this.cmb_SearchType.Location = new System.Drawing.Point(553, 20);
            this.cmb_SearchType.Name = "cmb_SearchType";
            this.cmb_SearchType.Size = new System.Drawing.Size(104, 20);
            this.cmb_SearchType.TabIndex = 33;
            this.cmb_SearchType.SelectedIndexChanged += new System.EventHandler(this.cmb_SearchType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pickup Order / Shipment List:";
            // 
            // txt_SearchText
            // 
            this.txt_SearchText.Location = new System.Drawing.Point(146, 18);
            this.txt_SearchText.Name = "txt_SearchText";
            this.txt_SearchText.Size = new System.Drawing.Size(401, 22);
            this.txt_SearchText.TabIndex = 2;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "Order ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "Pickup Date";
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.Location = new System.Drawing.Point(18, 34);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.ReadOnly = true;
            this.txt_OrderID.Size = new System.Drawing.Size(162, 22);
            this.txt_OrderID.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_SelectPickupTime);
            this.groupBox2.Controls.Add(this.dtp_SelectPickupDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_OrderID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_EdeACcountID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(406, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 120);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pickup Order Information";
            // 
            // dtp_SelectPickupTime
            // 
            this.dtp_SelectPickupTime.CustomFormat = "";
            this.dtp_SelectPickupTime.Location = new System.Drawing.Point(195, 83);
            this.dtp_SelectPickupTime.MinDate = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            this.dtp_SelectPickupTime.Name = "dtp_SelectPickupTime";
            this.dtp_SelectPickupTime.Size = new System.Drawing.Size(162, 22);
            this.dtp_SelectPickupTime.TabIndex = 17;
            this.dtp_SelectPickupTime.Value = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            // 
            // dtp_SelectPickupDate
            // 
            this.dtp_SelectPickupDate.Location = new System.Drawing.Point(18, 83);
            this.dtp_SelectPickupDate.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtp_SelectPickupDate.MinDate = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            this.dtp_SelectPickupDate.Name = "dtp_SelectPickupDate";
            this.dtp_SelectPickupDate.Size = new System.Drawing.Size(162, 22);
            this.dtp_SelectPickupDate.TabIndex = 16;
            this.dtp_SelectPickupDate.Value = new System.DateTime(2021, 6, 10, 0, 0, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmb_Status);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txt_CreateDate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_Insurance);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_GatewayID);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txt_CenterID);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_Receiver);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_Sender);
            this.groupBox3.Controls.Add(this.txt_ShipmentNo);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(11, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 215);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shipment Information";
            // 
            // cmb_Status
            // 
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(197, 36);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(161, 20);
            this.cmb_Status.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(195, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 31;
            this.label13.Text = "Create Date";
            // 
            // txt_CreateDate
            // 
            this.txt_CreateDate.Location = new System.Drawing.Point(197, 180);
            this.txt_CreateDate.Name = "txt_CreateDate";
            this.txt_CreateDate.ReadOnly = true;
            this.txt_CreateDate.Size = new System.Drawing.Size(162, 22);
            this.txt_CreateDate.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "Insurance";
            // 
            // txt_Insurance
            // 
            this.txt_Insurance.Location = new System.Drawing.Point(18, 180);
            this.txt_Insurance.Name = "txt_Insurance";
            this.txt_Insurance.ReadOnly = true;
            this.txt_Insurance.Size = new System.Drawing.Size(162, 22);
            this.txt_Insurance.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(195, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "Gateway ID";
            // 
            // txt_GatewayID
            // 
            this.txt_GatewayID.Location = new System.Drawing.Point(197, 132);
            this.txt_GatewayID.Name = "txt_GatewayID";
            this.txt_GatewayID.ReadOnly = true;
            this.txt_GatewayID.Size = new System.Drawing.Size(162, 22);
            this.txt_GatewayID.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "Center ID";
            // 
            // txt_CenterID
            // 
            this.txt_CenterID.Location = new System.Drawing.Point(18, 132);
            this.txt_CenterID.Name = "txt_CenterID";
            this.txt_CenterID.ReadOnly = true;
            this.txt_CenterID.Size = new System.Drawing.Size(162, 22);
            this.txt_CenterID.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "Receiver";
            // 
            // txt_Receiver
            // 
            this.txt_Receiver.Location = new System.Drawing.Point(197, 83);
            this.txt_Receiver.Name = "txt_Receiver";
            this.txt_Receiver.ReadOnly = true;
            this.txt_Receiver.Size = new System.Drawing.Size(162, 22);
            this.txt_Receiver.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sender";
            // 
            // txt_Sender
            // 
            this.txt_Sender.Location = new System.Drawing.Point(18, 83);
            this.txt_Sender.Name = "txt_Sender";
            this.txt_Sender.ReadOnly = true;
            this.txt_Sender.Size = new System.Drawing.Size(162, 22);
            this.txt_Sender.TabIndex = 14;
            // 
            // txt_ShipmentNo
            // 
            this.txt_ShipmentNo.Location = new System.Drawing.Point(18, 34);
            this.txt_ShipmentNo.Name = "txt_ShipmentNo";
            this.txt_ShipmentNo.ReadOnly = true;
            this.txt_ShipmentNo.Size = new System.Drawing.Size(162, 22);
            this.txt_ShipmentNo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "Shipment No";
            // 
            // btn_UpdateStatus
            // 
            this.btn_UpdateStatus.Enabled = false;
            this.btn_UpdateStatus.Location = new System.Drawing.Point(406, 358);
            this.btn_UpdateStatus.Name = "btn_UpdateStatus";
            this.btn_UpdateStatus.Size = new System.Drawing.Size(180, 22);
            this.btn_UpdateStatus.TabIndex = 23;
            this.btn_UpdateStatus.Text = "Update Status";
            this.btn_UpdateStatus.UseVisualStyleBackColor = true;
            this.btn_UpdateStatus.Click += new System.EventHandler(this.btn_UpdateStatus_Click);
            // 
            // btn_DeletePickupOrder
            // 
            this.btn_DeletePickupOrder.Enabled = false;
            this.btn_DeletePickupOrder.Location = new System.Drawing.Point(601, 358);
            this.btn_DeletePickupOrder.Name = "btn_DeletePickupOrder";
            this.btn_DeletePickupOrder.Size = new System.Drawing.Size(179, 22);
            this.btn_DeletePickupOrder.TabIndex = 24;
            this.btn_DeletePickupOrder.Text = "Delete Pickup Order";
            this.btn_DeletePickupOrder.UseVisualStyleBackColor = true;
            this.btn_DeletePickupOrder.Click += new System.EventHandler(this.btn_DeletePickupOrder_Click);
            // 
            // btn_UpdatePickupDataTime
            // 
            this.btn_UpdatePickupDataTime.Enabled = false;
            this.btn_UpdatePickupDataTime.Location = new System.Drawing.Point(406, 397);
            this.btn_UpdatePickupDataTime.Name = "btn_UpdatePickupDataTime";
            this.btn_UpdatePickupDataTime.Size = new System.Drawing.Size(180, 22);
            this.btn_UpdatePickupDataTime.TabIndex = 25;
            this.btn_UpdatePickupDataTime.Text = "Update Pickup Date and Time";
            this.btn_UpdatePickupDataTime.UseVisualStyleBackColor = true;
            this.btn_UpdatePickupDataTime.Click += new System.EventHandler(this.btn_UpdatePickupDataTime_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(599, 397);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(180, 22);
            this.btn_Reset.TabIndex = 26;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // EditShipmentForm
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 438);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_UpdatePickupDataTime);
            this.Controls.Add(this.btn_DeletePickupOrder);
            this.Controls.Add(this.btn_UpdateStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditShipmentForm";
            this.Text = "EditPickupForm";
            this.Load += new System.EventHandler(this.EditPickupForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_EdeACcountID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvw_OrderList;
        private System.Windows.Forms.Label lbl_PackageCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SearchText;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_OrderID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Insurance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_GatewayID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_CenterID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Receiver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Sender;
        private System.Windows.Forms.TextBox txt_ShipmentNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_CreateDate;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Button btn_UpdateStatus;
        private System.Windows.Forms.Button btn_DeletePickupOrder;
        private System.Windows.Forms.ComboBox cmb_SearchType;
        private System.Windows.Forms.Button btn_UpdatePickupDataTime;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DateTimePicker dtp_SelectPickupDate;
        private System.Windows.Forms.DateTimePicker dtp_SelectPickupTime;
    }
}