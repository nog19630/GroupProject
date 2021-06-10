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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_FunctionForm = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnPayServiceCal = new System.Windows.Forms.Button();
            this.lblPayServiceTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clbPayment = new System.Windows.Forms.CheckedListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_shipments = new System.Windows.Forms.DataGridView();
            this.btn_fillbill = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPayServiceCardNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPayServicePay = new System.Windows.Forms.Button();
            this.tbxPayServiceSecureCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.llblLastCreditCard = new System.Windows.Forms.LinkLabel();
            this.checkbPayServiceSafeCreditInfo = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shipments)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_FunctionForm);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 556);
            this.tabControl1.TabIndex = 14;
            // 
            // tbp_FunctionForm
            // 
            this.tbp_FunctionForm.Location = new System.Drawing.Point(4, 22);
            this.tbp_FunctionForm.Name = "tbp_FunctionForm";
            this.tbp_FunctionForm.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_FunctionForm.Size = new System.Drawing.Size(963, 530);
            this.tbp_FunctionForm.TabIndex = 0;
            this.tbp_FunctionForm.Text = "Book Pickup";
            this.tbp_FunctionForm.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Check Shipment Status";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(963, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Check Monthly Records";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPage4.Controls.Add(this.checkbPayServiceSafeCreditInfo);
            this.tabPage4.Controls.Add(this.llblLastCreditCard);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.tbxPayServiceSecureCode);
            this.tabPage4.Controls.Add(this.btnPayServicePay);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.tbxPayServiceCardNo);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.btnPayServiceCal);
            this.tabPage4.Controls.Add(this.lblPayServiceTotal);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.clbPayment);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(963, 530);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pay Delivery Service";
            // 
            // btnPayServiceCal
            // 
            this.btnPayServiceCal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayServiceCal.Location = new System.Drawing.Point(652, 284);
            this.btnPayServiceCal.Name = "btnPayServiceCal";
            this.btnPayServiceCal.Size = new System.Drawing.Size(103, 38);
            this.btnPayServiceCal.TabIndex = 3;
            this.btnPayServiceCal.Text = "Calculate";
            this.btnPayServiceCal.UseVisualStyleBackColor = true;
            this.btnPayServiceCal.Click += new System.EventHandler(this.btnPayServiceCal_Click);
            // 
            // lblPayServiceTotal
            // 
            this.lblPayServiceTotal.AutoSize = true;
            this.lblPayServiceTotal.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayServiceTotal.ForeColor = System.Drawing.Color.Red;
            this.lblPayServiceTotal.Location = new System.Drawing.Point(780, 286);
            this.lblPayServiceTotal.Name = "lblPayServiceTotal";
            this.lblPayServiceTotal.Size = new System.Drawing.Size(135, 27);
            this.lblPayServiceTotal.TabIndex = 2;
            this.lblPayServiceTotal.Text = "Total: $0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(648, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Please Select Payment(s) to Pay";
            // 
            // clbPayment
            // 
            this.clbPayment.FormattingEnabled = true;
            this.clbPayment.Location = new System.Drawing.Point(566, 43);
            this.clbPayment.Name = "clbPayment";
            this.clbPayment.Size = new System.Drawing.Size(375, 225);
            this.clbPayment.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.dgv_shipments);
            this.tabPage5.Controls.Add(this.btn_fillbill);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(963, 530);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Submit Airway Bill";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Shipments to be paid:";
            // 
            // dgv_shipments
            // 
            this.dgv_shipments.AllowUserToAddRows = false;
            this.dgv_shipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_shipments.Location = new System.Drawing.Point(17, 28);
            this.dgv_shipments.Name = "dgv_shipments";
            this.dgv_shipments.ReadOnly = true;
            this.dgv_shipments.Size = new System.Drawing.Size(621, 491);
            this.dgv_shipments.TabIndex = 7;
            // 
            // btn_fillbill
            // 
            this.btn_fillbill.Location = new System.Drawing.Point(659, 162);
            this.btn_fillbill.Name = "btn_fillbill";
            this.btn_fillbill.Size = new System.Drawing.Size(287, 234);
            this.btn_fillbill.TabIndex = 6;
            this.btn_fillbill.Text = "Fill airway bill";
            this.btn_fillbill.UseVisualStyleBackColor = true;
            this.btn_fillbill.Click += new System.EventHandler(this.btn_fillbill_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(963, 530);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Check Account Information";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(971, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(0, 6);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(89, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please Enter Credit Card Information:";
            // 
            // tbxPayServiceCardNo
            // 
            this.tbxPayServiceCardNo.Location = new System.Drawing.Point(130, 56);
            this.tbxPayServiceCardNo.MaxLength = 16;
            this.tbxPayServiceCardNo.Name = "tbxPayServiceCardNo";
            this.tbxPayServiceCardNo.Size = new System.Drawing.Size(225, 22);
            this.tbxPayServiceCardNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Credit Card No.";
            // 
            // btnPayServicePay
            // 
            this.btnPayServicePay.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.btnPayServicePay.Location = new System.Drawing.Point(67, 341);
            this.btnPayServicePay.Name = "btnPayServicePay";
            this.btnPayServicePay.Size = new System.Drawing.Size(277, 132);
            this.btnPayServicePay.TabIndex = 7;
            this.btnPayServicePay.Text = "PAY";
            this.btnPayServicePay.UseVisualStyleBackColor = true;
            this.btnPayServicePay.Click += new System.EventHandler(this.btnPayServicePay_Click);
            // 
            // tbxPayServiceSecureCode
            // 
            this.tbxPayServiceSecureCode.Location = new System.Drawing.Point(130, 107);
            this.tbxPayServiceSecureCode.MaxLength = 3;
            this.tbxPayServiceSecureCode.Name = "tbxPayServiceSecureCode";
            this.tbxPayServiceSecureCode.Size = new System.Drawing.Size(67, 22);
            this.tbxPayServiceSecureCode.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Security Code:";
            // 
            // llblLastCreditCard
            // 
            this.llblLastCreditCard.AutoSize = true;
            this.llblLastCreditCard.Location = new System.Drawing.Point(370, 66);
            this.llblLastCreditCard.Name = "llblLastCreditCard";
            this.llblLastCreditCard.Size = new System.Drawing.Size(117, 12);
            this.llblLastCreditCard.TabIndex = 10;
            this.llblLastCreditCard.TabStop = true;
            this.llblLastCreditCard.Text = "Use previous credit card";
            this.llblLastCreditCard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLastCreditCard_LinkClicked);
            // 
            // checkbPayServiceSafeCreditInfo
            // 
            this.checkbPayServiceSafeCreditInfo.AutoSize = true;
            this.checkbPayServiceSafeCreditInfo.ForeColor = System.Drawing.Color.Brown;
            this.checkbPayServiceSafeCreditInfo.Location = new System.Drawing.Point(30, 156);
            this.checkbPayServiceSafeCreditInfo.Name = "checkbPayServiceSafeCreditInfo";
            this.checkbPayServiceSafeCreditInfo.Size = new System.Drawing.Size(200, 16);
            this.checkbPayServiceSafeCreditInfo.TabIndex = 11;
            this.checkbPayServiceSafeCreditInfo.Text = "Save credit card number for next use?";
            this.checkbPayServiceSafeCreditInfo.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 613);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.label1);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_shipments)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_FunctionForm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_shipments;
        private System.Windows.Forms.Button btn_fillbill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox clbPayment;
        private System.Windows.Forms.Label lblPayServiceTotal;
        private System.Windows.Forms.Button btnPayServiceCal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPayServiceCardNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPayServicePay;
        private System.Windows.Forms.LinkLabel llblLastCreditCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPayServiceSecureCode;
        private System.Windows.Forms.CheckBox checkbPayServiceSafeCreditInfo;
    }
}

