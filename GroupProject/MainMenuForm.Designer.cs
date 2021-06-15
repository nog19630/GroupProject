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
            this.label1 = new System.Windows.Forms.Label();
            this.tbc_Function = new System.Windows.Forms.TabControl();
            this.tbp_BookPickup = new System.Windows.Forms.TabPage();
            this.tbp_CheckShipmentStatus = new System.Windows.Forms.TabPage();
            this.tbp_MessageBox = new System.Windows.Forms.TabPage();
            this.tbp_EditPickupOrder = new System.Windows.Forms.TabPage();
            this.tbp_ManageMessage = new System.Windows.Forms.TabPage();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_shipments = new System.Windows.Forms.DataGridView();
            this.btn_fillbill = new System.Windows.Forms.Button();
            this.tbc_Function.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shipments)).BeginInit();
            this.SuspendLayout();
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
            this.tbc_Function.Controls.Add(this.tabPage1);
            this.tbc_Function.Controls.Add(this.tabPage2);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_fillbill);
            this.tabPage1.Controls.Add(this.dgv_shipments);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 477);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(787, 477);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_shipments
            // 
            this.dgv_shipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_shipments.Location = new System.Drawing.Point(6, 6);
            this.dgv_shipments.Name = "dgv_shipments";
            this.dgv_shipments.Size = new System.Drawing.Size(511, 465);
            this.dgv_shipments.TabIndex = 0;
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
            this.tbc_Function.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shipments)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_fillbill;
        private System.Windows.Forms.DataGridView dgv_shipments;
    }
}

