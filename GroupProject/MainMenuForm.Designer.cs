namespace GroupProject
{
    partial class MainMenuForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new GroupProject.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.tbc_Function = new System.Windows.Forms.TabControl();
            this.tbp_BookPickup = new System.Windows.Forms.TabPage();
            this.tbp_CheckShipmentStatus = new System.Windows.Forms.TabPage();
            this.tbp_MessageBox = new System.Windows.Forms.TabPage();
            this.tbp_EditPickupOrder = new System.Windows.Forms.TabPage();
            this.tbp_ManageMessage = new System.Windows.Forms.TabPage();
            this.tbp_submitbill = new System.Windows.Forms.TabPage();
            this.btn_fillbill = new System.Windows.Forms.Button();
            this.dgv_shipments = new System.Windows.Forms.DataGridView();
            this.tbp_payservice = new System.Windows.Forms.TabPage();
            this.btnPayServicePay = new System.Windows.Forms.Button();
            this.btnPayServiceCal = new System.Windows.Forms.Button();
            this.lblPayServiceTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbPayment = new System.Windows.Forms.CheckedListBox();
            this.checkbPayServiceSafeCreditInfo = new System.Windows.Forms.CheckBox();
            this.llblLastCreditCard = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPayServiceSecureCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPayServiceCardNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbp_datamain = new System.Windows.Forms.TabPage();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_maintenance = new System.Windows.Forms.DataGridView();
            this.cbo_table = new System.Windows.Forms.ComboBox();
            this.tbp_MonthInv = new System.Windows.Forms.TabPage();
            this.rv_monthlyInv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbp_ImportInv = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_AccountID = new System.Windows.Forms.Label();
            this.lbl_CustomerID = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.tbc_Function.SuspendLayout();
            this.tbp_submitbill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shipments)).BeginInit();
            this.tbp_payservice.SuspendLayout();
            this.tbp_datamain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_maintenance)).BeginInit();
            this.tbp_MonthInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World!";
            // 
            // tbc_Function
            // 
            this.tbc_Function.Controls.Add(this.tbp_BookPickup);
            this.tbc_Function.Controls.Add(this.tbp_CheckShipmentStatus);
            this.tbc_Function.Controls.Add(this.tbp_MessageBox);
            this.tbc_Function.Controls.Add(this.tbp_EditPickupOrder);
            this.tbc_Function.Controls.Add(this.tbp_ManageMessage);
            this.tbc_Function.Controls.Add(this.tbp_submitbill);
            this.tbc_Function.Controls.Add(this.tbp_payservice);
            this.tbc_Function.Controls.Add(this.tbp_datamain);
            this.tbc_Function.Controls.Add(this.tbp_MonthInv);
            this.tbc_Function.Controls.Add(this.tbp_ImportInv);
            this.tbc_Function.Location = new System.Drawing.Point(4, 69);
            this.tbc_Function.Name = "tbc_Function";
            this.tbc_Function.SelectedIndex = 0;
            this.tbc_Function.Size = new System.Drawing.Size(795, 503);
            this.tbc_Function.TabIndex = 14;
            this.tbc_Function.SelectedIndexChanged += new System.EventHandler(this.tbc_Function_SelectedIndexChanged);
            // 
            // tbp_BookPickup
            // 
            this.tbp_BookPickup.Location = new System.Drawing.Point(4, 22);
            this.tbp_BookPickup.Name = "tbp_BookPickup";
            this.tbp_BookPickup.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_BookPickup.Size = new System.Drawing.Size(787, 477);
            this.tbp_BookPickup.TabIndex = 0;
            this.tbp_BookPickup.Text = "Book Pickup";
            this.tbp_BookPickup.UseVisualStyleBackColor = true;
            // 
            // tbp_CheckShipmentStatus
            // 
            this.tbp_CheckShipmentStatus.BackColor = System.Drawing.Color.White;
            this.tbp_CheckShipmentStatus.Location = new System.Drawing.Point(4, 22);
            this.tbp_CheckShipmentStatus.Name = "tbp_CheckShipmentStatus";
            this.tbp_CheckShipmentStatus.Size = new System.Drawing.Size(787, 477);
            this.tbp_CheckShipmentStatus.TabIndex = 1;
            this.tbp_CheckShipmentStatus.Text = "Check Booking Shipment Status";
            // 
            // tbp_MessageBox
            // 
            this.tbp_MessageBox.Location = new System.Drawing.Point(4, 22);
            this.tbp_MessageBox.Name = "tbp_MessageBox";
            this.tbp_MessageBox.Size = new System.Drawing.Size(787, 477);
            this.tbp_MessageBox.TabIndex = 3;
            this.tbp_MessageBox.Text = "Message Box";
            this.tbp_MessageBox.UseVisualStyleBackColor = true;
            // 
            // tbp_EditPickupOrder
            // 
            this.tbp_EditPickupOrder.Location = new System.Drawing.Point(4, 22);
            this.tbp_EditPickupOrder.Name = "tbp_EditPickupOrder";
            this.tbp_EditPickupOrder.Size = new System.Drawing.Size(787, 477);
            this.tbp_EditPickupOrder.TabIndex = 2;
            this.tbp_EditPickupOrder.Text = "Edit Pickup Order";
            this.tbp_EditPickupOrder.UseVisualStyleBackColor = true;
            // 
            // tbp_ManageMessage
            // 
            this.tbp_ManageMessage.Location = new System.Drawing.Point(4, 22);
            this.tbp_ManageMessage.Name = "tbp_ManageMessage";
            this.tbp_ManageMessage.Size = new System.Drawing.Size(787, 477);
            this.tbp_ManageMessage.TabIndex = 4;
            this.tbp_ManageMessage.Text = "Manage Message";
            this.tbp_ManageMessage.UseVisualStyleBackColor = true;
            // 
            // tbp_submitbill
            // 
            this.tbp_submitbill.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbp_submitbill.Controls.Add(this.btn_fillbill);
            this.tbp_submitbill.Controls.Add(this.dgv_shipments);
            this.tbp_submitbill.Location = new System.Drawing.Point(4, 22);
            this.tbp_submitbill.Name = "tbp_submitbill";
            this.tbp_submitbill.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_submitbill.Size = new System.Drawing.Size(787, 477);
            this.tbp_submitbill.TabIndex = 5;
            this.tbp_submitbill.Text = "Submit Airway bill";
            // 
            // btn_fillbill
            // 
            this.btn_fillbill.Location = new System.Drawing.Point(523, 129);
            this.btn_fillbill.Name = "btn_fillbill";
            this.btn_fillbill.Size = new System.Drawing.Size(258, 233);
            this.btn_fillbill.TabIndex = 1;
            this.btn_fillbill.Text = "Submit Airway bill";
            this.btn_fillbill.UseVisualStyleBackColor = true;
            this.btn_fillbill.Click += new System.EventHandler(this.btn_fillbill_Click);
            // 
            // dgv_shipments
            // 
            this.dgv_shipments.AllowUserToAddRows = false;
            this.dgv_shipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_shipments.Location = new System.Drawing.Point(6, 7);
            this.dgv_shipments.Name = "dgv_shipments";
            this.dgv_shipments.Size = new System.Drawing.Size(511, 465);
            this.dgv_shipments.TabIndex = 0;
            // 
            // tbp_payservice
            // 
            this.tbp_payservice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbp_payservice.Controls.Add(this.btnPayServicePay);
            this.tbp_payservice.Controls.Add(this.btnPayServiceCal);
            this.tbp_payservice.Controls.Add(this.lblPayServiceTotal);
            this.tbp_payservice.Controls.Add(this.label3);
            this.tbp_payservice.Controls.Add(this.clbPayment);
            this.tbp_payservice.Controls.Add(this.checkbPayServiceSafeCreditInfo);
            this.tbp_payservice.Controls.Add(this.llblLastCreditCard);
            this.tbp_payservice.Controls.Add(this.label6);
            this.tbp_payservice.Controls.Add(this.tbxPayServiceSecureCode);
            this.tbp_payservice.Controls.Add(this.label5);
            this.tbp_payservice.Controls.Add(this.tbxPayServiceCardNo);
            this.tbp_payservice.Controls.Add(this.label4);
            this.tbp_payservice.Location = new System.Drawing.Point(4, 22);
            this.tbp_payservice.Name = "tbp_payservice";
            this.tbp_payservice.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_payservice.Size = new System.Drawing.Size(787, 477);
            this.tbp_payservice.TabIndex = 6;
            this.tbp_payservice.Text = "Pay Delivery Service";
            // 
            // btnPayServicePay
            // 
            this.btnPayServicePay.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.btnPayServicePay.Location = new System.Drawing.Point(37, 230);
            this.btnPayServicePay.Name = "btnPayServicePay";
            this.btnPayServicePay.Size = new System.Drawing.Size(277, 143);
            this.btnPayServicePay.TabIndex = 23;
            this.btnPayServicePay.Text = "PAY";
            this.btnPayServicePay.UseVisualStyleBackColor = true;
            this.btnPayServicePay.Click += new System.EventHandler(this.btnPayServicePay_Click);
            // 
            // btnPayServiceCal
            // 
            this.btnPayServiceCal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayServiceCal.Location = new System.Drawing.Point(479, 372);
            this.btnPayServiceCal.Name = "btnPayServiceCal";
            this.btnPayServiceCal.Size = new System.Drawing.Size(103, 41);
            this.btnPayServiceCal.TabIndex = 22;
            this.btnPayServiceCal.Text = "Calculate";
            this.btnPayServiceCal.UseVisualStyleBackColor = true;
            this.btnPayServiceCal.Click += new System.EventHandler(this.btnPayServiceCal_Click);
            // 
            // lblPayServiceTotal
            // 
            this.lblPayServiceTotal.AutoSize = true;
            this.lblPayServiceTotal.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayServiceTotal.ForeColor = System.Drawing.Color.Red;
            this.lblPayServiceTotal.Location = new System.Drawing.Point(607, 374);
            this.lblPayServiceTotal.Name = "lblPayServiceTotal";
            this.lblPayServiceTotal.Size = new System.Drawing.Size(135, 27);
            this.lblPayServiceTotal.TabIndex = 21;
            this.lblPayServiceTotal.Text = "Total: $0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Please Select Payment(s) to Pay";
            // 
            // clbPayment
            // 
            this.clbPayment.FormattingEnabled = true;
            this.clbPayment.Location = new System.Drawing.Point(393, 111);
            this.clbPayment.Name = "clbPayment";
            this.clbPayment.Size = new System.Drawing.Size(375, 199);
            this.clbPayment.TabIndex = 19;
            // 
            // checkbPayServiceSafeCreditInfo
            // 
            this.checkbPayServiceSafeCreditInfo.AutoSize = true;
            this.checkbPayServiceSafeCreditInfo.ForeColor = System.Drawing.Color.Brown;
            this.checkbPayServiceSafeCreditInfo.Location = new System.Drawing.Point(26, 161);
            this.checkbPayServiceSafeCreditInfo.Name = "checkbPayServiceSafeCreditInfo";
            this.checkbPayServiceSafeCreditInfo.Size = new System.Drawing.Size(206, 17);
            this.checkbPayServiceSafeCreditInfo.TabIndex = 18;
            this.checkbPayServiceSafeCreditInfo.Text = "Save credit card number for next use?";
            this.checkbPayServiceSafeCreditInfo.UseVisualStyleBackColor = true;
            // 
            // llblLastCreditCard
            // 
            this.llblLastCreditCard.AutoSize = true;
            this.llblLastCreditCard.Location = new System.Drawing.Point(366, 64);
            this.llblLastCreditCard.Name = "llblLastCreditCard";
            this.llblLastCreditCard.Size = new System.Drawing.Size(122, 13);
            this.llblLastCreditCard.TabIndex = 17;
            this.llblLastCreditCard.TabStop = true;
            this.llblLastCreditCard.Text = "Use previous credit card";
            this.llblLastCreditCard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLastCreditCard_LinkClicked_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Security Code:";
            // 
            // tbxPayServiceSecureCode
            // 
            this.tbxPayServiceSecureCode.Location = new System.Drawing.Point(126, 108);
            this.tbxPayServiceSecureCode.MaxLength = 3;
            this.tbxPayServiceSecureCode.Name = "tbxPayServiceSecureCode";
            this.tbxPayServiceSecureCode.Size = new System.Drawing.Size(67, 20);
            this.tbxPayServiceSecureCode.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Credit Card No.";
            // 
            // tbxPayServiceCardNo
            // 
            this.tbxPayServiceCardNo.Location = new System.Drawing.Point(126, 53);
            this.tbxPayServiceCardNo.MaxLength = 16;
            this.tbxPayServiceCardNo.Name = "tbxPayServiceCardNo";
            this.tbxPayServiceCardNo.Size = new System.Drawing.Size(225, 20);
            this.tbxPayServiceCardNo.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(85, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Please Enter Credit Card Information:";
            // 
            // tbp_datamain
            // 
            this.tbp_datamain.Controls.Add(this.btn_update);
            this.tbp_datamain.Controls.Add(this.dgv_maintenance);
            this.tbp_datamain.Controls.Add(this.cbo_table);
            this.tbp_datamain.Location = new System.Drawing.Point(4, 22);
            this.tbp_datamain.Name = "tbp_datamain";
            this.tbp_datamain.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_datamain.Size = new System.Drawing.Size(787, 477);
            this.tbp_datamain.TabIndex = 7;
            this.tbp_datamain.Text = "Data Maintenance";
            this.tbp_datamain.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(6, 368);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(121, 103);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dgv_maintenance
            // 
            this.dgv_maintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_maintenance.Location = new System.Drawing.Point(133, 7);
            this.dgv_maintenance.Name = "dgv_maintenance";
            this.dgv_maintenance.Size = new System.Drawing.Size(648, 465);
            this.dgv_maintenance.TabIndex = 1;
            // 
            // cbo_table
            // 
            this.cbo_table.FormattingEnabled = true;
            this.cbo_table.Items.AddRange(new object[] {
            "operationcenter",
            "staff",
            "vehicle"});
            this.cbo_table.Location = new System.Drawing.Point(6, 7);
            this.cbo_table.Name = "cbo_table";
            this.cbo_table.Size = new System.Drawing.Size(121, 21);
            this.cbo_table.TabIndex = 0;
            this.cbo_table.SelectedIndexChanged += new System.EventHandler(this.cbo_table_SelectedIndexChanged);
            // 
            // tbp_MonthInv
            // 
            this.tbp_MonthInv.Controls.Add(this.rv_monthlyInv);
            this.tbp_MonthInv.Location = new System.Drawing.Point(4, 22);
            this.tbp_MonthInv.Name = "tbp_MonthInv";
            this.tbp_MonthInv.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_MonthInv.Size = new System.Drawing.Size(787, 477);
            this.tbp_MonthInv.TabIndex = 8;
            this.tbp_MonthInv.Text = "Monthly Invoice";
            this.tbp_MonthInv.UseVisualStyleBackColor = true;
            // 
            // rv_monthlyInv
            // 
            this.rv_monthlyInv.Location = new System.Drawing.Point(4, 3);
            this.rv_monthlyInv.Name = "rv_monthlyInv";
            this.rv_monthlyInv.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.rv_monthlyInv.ServerReport.BearerToken = null;
            this.rv_monthlyInv.Size = new System.Drawing.Size(780, 468);
            this.rv_monthlyInv.TabIndex = 0;
            // 
            // tbp_ImportInv
            // 
            this.tbp_ImportInv.Location = new System.Drawing.Point(4, 22);
            this.tbp_ImportInv.Name = "tbp_ImportInv";
            this.tbp_ImportInv.Size = new System.Drawing.Size(787, 477);
            this.tbp_ImportInv.TabIndex = 9;
            this.tbp_ImportInv.Text = "Import Invoice";
            this.tbp_ImportInv.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel1.Text = "Time: 11:59:30";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(802, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(0, 7);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(322, 23);
            this.lbl_Title.TabIndex = 15;
            this.lbl_Title.Text = "Delivery Express System: Main Menu";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.AutoSize = true;
            this.lbl_UserType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserType.Location = new System.Drawing.Point(239, 36);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(46, 19);
            this.lbl_UserType.TabIndex = 18;
            this.lbl_UserType.Text = "Type: ";
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(719, 8);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(76, 28);
            this.btn_Logout.TabIndex = 19;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_AccountID
            // 
            this.lbl_AccountID.AutoSize = true;
            this.lbl_AccountID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccountID.Location = new System.Drawing.Point(4, 36);
            this.lbl_AccountID.Name = "lbl_AccountID";
            this.lbl_AccountID.Size = new System.Drawing.Size(87, 19);
            this.lbl_AccountID.TabIndex = 20;
            this.lbl_AccountID.Text = "Account ID: ";
            // 
            // lbl_CustomerID
            // 
            this.lbl_CustomerID.AutoSize = true;
            this.lbl_CustomerID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerID.Location = new System.Drawing.Point(430, 36);
            this.lbl_CustomerID.Name = "lbl_CustomerID";
            this.lbl_CustomerID.Size = new System.Drawing.Size(95, 19);
            this.lbl_CustomerID.TabIndex = 21;
            this.lbl_CustomerID.Text = "Customer ID: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 599);
            this.Controls.Add(this.lbl_CustomerID);
            this.Controls.Add(this.lbl_AccountID);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lbl_UserType);
            this.Controls.Add(this.tbc_Function);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.tbc_Function.ResumeLayout(false);
            this.tbp_submitbill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shipments)).EndInit();
            this.tbp_payservice.ResumeLayout(false);
            this.tbp_payservice.PerformLayout();
            this.tbp_datamain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_maintenance)).EndInit();
            this.tbp_MonthInv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbc_Function;
        private System.Windows.Forms.TabPage tbp_BookPickup;
        private System.Windows.Forms.TabPage tbp_CheckShipmentStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_AccountID;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tbp_EditPickupOrder;
        private System.Windows.Forms.Label lbl_CustomerID;
        private System.Windows.Forms.TabPage tbp_MessageBox;
        private System.Windows.Forms.TabPage tbp_ManageMessage;
        private System.Windows.Forms.TabPage tbp_submitbill;
        private System.Windows.Forms.TabPage tbp_payservice;
        private System.Windows.Forms.Button btn_fillbill;
        private System.Windows.Forms.DataGridView dgv_shipments;
        private System.Windows.Forms.Button btnPayServicePay;
        private System.Windows.Forms.Button btnPayServiceCal;
        private System.Windows.Forms.Label lblPayServiceTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbPayment;
        private System.Windows.Forms.CheckBox checkbPayServiceSafeCreditInfo;
        private System.Windows.Forms.LinkLabel llblLastCreditCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPayServiceSecureCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPayServiceCardNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tbp_datamain;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_maintenance;
        private System.Windows.Forms.ComboBox cbo_table;
        private System.Windows.Forms.TabPage tbp_MonthInv;
        private System.Windows.Forms.TabPage tbp_ImportInv;
        private Microsoft.Reporting.WinForms.ReportViewer rv_monthlyInv;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
    }
}

