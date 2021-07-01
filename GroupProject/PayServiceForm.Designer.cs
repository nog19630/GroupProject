
namespace GroupProject
{
    partial class PayServiceForm
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
            this.SuspendLayout();
            // 
            // btnPayServicePay
            // 
            this.btnPayServicePay.Font = new System.Drawing.Font("Arial Narrow", 20F);
            this.btnPayServicePay.Location = new System.Drawing.Point(41, 240);
            this.btnPayServicePay.Name = "btnPayServicePay";
            this.btnPayServicePay.Size = new System.Drawing.Size(277, 132);
            this.btnPayServicePay.TabIndex = 35;
            this.btnPayServicePay.Text = "PAY";
            this.btnPayServicePay.UseVisualStyleBackColor = true;
            this.btnPayServicePay.Click += new System.EventHandler(this.btnPayServicePay_Click);
            // 
            // btnPayServiceCal
            // 
            this.btnPayServiceCal.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayServiceCal.Location = new System.Drawing.Point(483, 371);
            this.btnPayServiceCal.Name = "btnPayServiceCal";
            this.btnPayServiceCal.Size = new System.Drawing.Size(103, 38);
            this.btnPayServiceCal.TabIndex = 34;
            this.btnPayServiceCal.Text = "Calculate";
            this.btnPayServiceCal.UseVisualStyleBackColor = true;
            this.btnPayServiceCal.Click += new System.EventHandler(this.btnPayServiceCal_Click);
            // 
            // lblPayServiceTotal
            // 
            this.lblPayServiceTotal.AutoSize = true;
            this.lblPayServiceTotal.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayServiceTotal.ForeColor = System.Drawing.Color.Red;
            this.lblPayServiceTotal.Location = new System.Drawing.Point(611, 373);
            this.lblPayServiceTotal.Name = "lblPayServiceTotal";
            this.lblPayServiceTotal.Size = new System.Drawing.Size(135, 27);
            this.lblPayServiceTotal.TabIndex = 33;
            this.lblPayServiceTotal.Text = "Total: $0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Please Select Payment(s) to Pay";
            // 
            // clbPayment
            // 
            this.clbPayment.FormattingEnabled = true;
            this.clbPayment.Location = new System.Drawing.Point(397, 130);
            this.clbPayment.Name = "clbPayment";
            this.clbPayment.Size = new System.Drawing.Size(375, 174);
            this.clbPayment.TabIndex = 31;
            // 
            // checkbPayServiceSafeCreditInfo
            // 
            this.checkbPayServiceSafeCreditInfo.AutoSize = true;
            this.checkbPayServiceSafeCreditInfo.ForeColor = System.Drawing.Color.Brown;
            this.checkbPayServiceSafeCreditInfo.Location = new System.Drawing.Point(30, 177);
            this.checkbPayServiceSafeCreditInfo.Name = "checkbPayServiceSafeCreditInfo";
            this.checkbPayServiceSafeCreditInfo.Size = new System.Drawing.Size(200, 16);
            this.checkbPayServiceSafeCreditInfo.TabIndex = 30;
            this.checkbPayServiceSafeCreditInfo.Text = "Save credit card number for next use?";
            this.checkbPayServiceSafeCreditInfo.UseVisualStyleBackColor = true;
            // 
            // llblLastCreditCard
            // 
            this.llblLastCreditCard.AutoSize = true;
            this.llblLastCreditCard.Location = new System.Drawing.Point(370, 87);
            this.llblLastCreditCard.Name = "llblLastCreditCard";
            this.llblLastCreditCard.Size = new System.Drawing.Size(117, 12);
            this.llblLastCreditCard.TabIndex = 29;
            this.llblLastCreditCard.TabStop = true;
            this.llblLastCreditCard.Text = "Use previous credit card";
            this.llblLastCreditCard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblLastCreditCard_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 12);
            this.label6.TabIndex = 28;
            this.label6.Text = "Security Code:";
            // 
            // tbxPayServiceSecureCode
            // 
            this.tbxPayServiceSecureCode.Location = new System.Drawing.Point(130, 128);
            this.tbxPayServiceSecureCode.MaxLength = 3;
            this.tbxPayServiceSecureCode.Name = "tbxPayServiceSecureCode";
            this.tbxPayServiceSecureCode.Size = new System.Drawing.Size(67, 22);
            this.tbxPayServiceSecureCode.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "Credit Card No.";
            // 
            // tbxPayServiceCardNo
            // 
            this.tbxPayServiceCardNo.Location = new System.Drawing.Point(130, 77);
            this.tbxPayServiceCardNo.MaxLength = 16;
            this.tbxPayServiceCardNo.Name = "tbxPayServiceCardNo";
            this.tbxPayServiceCardNo.Size = new System.Drawing.Size(225, 22);
            this.tbxPayServiceCardNo.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.Location = new System.Drawing.Point(89, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Please Enter Credit Card Information:";
            // 
            // PayServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPayServicePay);
            this.Controls.Add(this.btnPayServiceCal);
            this.Controls.Add(this.lblPayServiceTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbPayment);
            this.Controls.Add(this.checkbPayServiceSafeCreditInfo);
            this.Controls.Add(this.llblLastCreditCard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxPayServiceSecureCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPayServiceCardNo);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PayServiceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PayServiceForm";
            this.Load += new System.EventHandler(this.PayServiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}