
namespace GroupProject
{
    partial class InvoiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSender = new System.Windows.Forms.TextBox();
            this.tbxSenderAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSenderPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxReceiver = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPieces = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxReceiverAddress = new System.Windows.Forms.TextBox();
            this.tbxPostCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxCountry = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxReceiverPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxInvoiceID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proforma Invoice / Commercial Invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "SHIPPER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name: ";
            // 
            // tbxSender
            // 
            this.tbxSender.Location = new System.Drawing.Point(170, 135);
            this.tbxSender.Name = "tbxSender";
            this.tbxSender.ReadOnly = true;
            this.tbxSender.Size = new System.Drawing.Size(373, 22);
            this.tbxSender.TabIndex = 1;
            // 
            // tbxSenderAddress
            // 
            this.tbxSenderAddress.Location = new System.Drawing.Point(170, 172);
            this.tbxSenderAddress.Multiline = true;
            this.tbxSenderAddress.Name = "tbxSenderAddress";
            this.tbxSenderAddress.ReadOnly = true;
            this.tbxSenderAddress.Size = new System.Drawing.Size(552, 79);
            this.tbxSenderAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone/Fax No.:";
            // 
            // tbxSenderPhone
            // 
            this.tbxSenderPhone.Location = new System.Drawing.Point(170, 265);
            this.tbxSenderPhone.Name = "tbxSenderPhone";
            this.tbxSenderPhone.ReadOnly = true;
            this.tbxSenderPhone.Size = new System.Drawing.Size(552, 22);
            this.tbxSenderPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 27);
            this.label6.TabIndex = 8;
            this.label6.Text = "SHIP TO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Receiver:";
            // 
            // tbxReceiver
            // 
            this.tbxReceiver.Location = new System.Drawing.Point(170, 332);
            this.tbxReceiver.Name = "tbxReceiver";
            this.tbxReceiver.ReadOnly = true;
            this.tbxReceiver.Size = new System.Drawing.Size(313, 22);
            this.tbxReceiver.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "No. of pieces:";
            // 
            // tbxPieces
            // 
            this.tbxPieces.Location = new System.Drawing.Point(564, 332);
            this.tbxPieces.Name = "tbxPieces";
            this.tbxPieces.ReadOnly = true;
            this.tbxPieces.Size = new System.Drawing.Size(158, 22);
            this.tbxPieces.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "Address: ";
            // 
            // tbxReceiverAddress
            // 
            this.tbxReceiverAddress.Location = new System.Drawing.Point(170, 372);
            this.tbxReceiverAddress.Multiline = true;
            this.tbxReceiverAddress.Name = "tbxReceiverAddress";
            this.tbxReceiverAddress.ReadOnly = true;
            this.tbxReceiverAddress.Size = new System.Drawing.Size(552, 79);
            this.tbxReceiverAddress.TabIndex = 13;
            // 
            // tbxPostCode
            // 
            this.tbxPostCode.Location = new System.Drawing.Point(170, 470);
            this.tbxPostCode.Name = "tbxPostCode";
            this.tbxPostCode.ReadOnly = true;
            this.tbxPostCode.Size = new System.Drawing.Size(313, 22);
            this.tbxPostCode.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 12);
            this.label10.TabIndex = 15;
            this.label10.Text = "Town/Area code:";
            // 
            // tbxWeight
            // 
            this.tbxWeight.Location = new System.Drawing.Point(564, 470);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.ReadOnly = true;
            this.tbxWeight.Size = new System.Drawing.Size(158, 22);
            this.tbxWeight.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(489, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "Total Weight:";
            // 
            // tbxCountry
            // 
            this.tbxCountry.Location = new System.Drawing.Point(170, 510);
            this.tbxCountry.Name = "tbxCountry";
            this.tbxCountry.ReadOnly = true;
            this.tbxCountry.Size = new System.Drawing.Size(552, 22);
            this.tbxCountry.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 513);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "State/Country:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 554);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 21;
            this.label13.Text = "Phone/Fax No.:";
            // 
            // tbxReceiverPhone
            // 
            this.tbxReceiverPhone.Location = new System.Drawing.Point(170, 551);
            this.tbxReceiverPhone.Name = "tbxReceiverPhone";
            this.tbxReceiverPhone.ReadOnly = true;
            this.tbxReceiverPhone.Size = new System.Drawing.Size(552, 22);
            this.tbxReceiverPhone.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(35, 603);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 23);
            this.label14.TabIndex = 24;
            this.label14.Text = "Description:";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(170, 600);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.Size = new System.Drawing.Size(552, 79);
            this.tbxDescription.TabIndex = 23;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(265, 697);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(218, 27);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total Invoice Value:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(45, 745);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(239, 12);
            this.label16.TabIndex = 26;
            this.label16.Text = "This invoice is generated automatically";
            // 
            // tbxInvoiceID
            // 
            this.tbxInvoiceID.Location = new System.Drawing.Point(564, 135);
            this.tbxInvoiceID.Name = "tbxInvoiceID";
            this.tbxInvoiceID.ReadOnly = true;
            this.tbxInvoiceID.Size = new System.Drawing.Size(158, 22);
            this.tbxInvoiceID.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(562, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 12);
            this.label17.TabIndex = 27;
            this.label17.Text = "Airway Bill No.";
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 790);
            this.Controls.Add(this.tbxInvoiceID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxReceiverPhone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxCountry);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxWeight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxPostCode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxReceiverAddress);
            this.Controls.Add(this.tbxPieces);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxReceiver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxSenderPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxSenderAddress);
            this.Controls.Add(this.tbxSender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InvoiceForm";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSender;
        private System.Windows.Forms.TextBox tbxSenderAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSenderPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxReceiver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPieces;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxReceiverAddress;
        private System.Windows.Forms.TextBox tbxPostCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxCountry;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxReceiverPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxInvoiceID;
        private System.Windows.Forms.Label label17;
    }
}