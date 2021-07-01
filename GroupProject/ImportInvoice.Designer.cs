
namespace GroupProject
{
    partial class ImportInvoice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvw_InvoiceList = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SearchShipmentNo = new System.Windows.Forms.TextBox();
            this.lbl_PackageCode = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_selectInvoice = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.lvw_InvoiceList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_SearchShipmentNo);
            this.groupBox1.Controls.Add(this.lbl_PackageCode);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Location = new System.Drawing.Point(3, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 215);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Invoice";
            // 
            // lvw_InvoiceList
            // 
            this.lvw_InvoiceList.FullRowSelect = true;
            this.lvw_InvoiceList.GridLines = true;
            this.lvw_InvoiceList.HideSelection = false;
            this.lvw_InvoiceList.Location = new System.Drawing.Point(18, 65);
            this.lvw_InvoiceList.MultiSelect = false;
            this.lvw_InvoiceList.Name = "lvw_InvoiceList";
            this.lvw_InvoiceList.Size = new System.Drawing.Size(732, 139);
            this.lvw_InvoiceList.TabIndex = 5;
            this.lvw_InvoiceList.UseCompatibleStateImageBehavior = false;
            this.lvw_InvoiceList.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Invoice List:";
            // 
            // txt_SearchShipmentNo
            // 
            this.txt_SearchShipmentNo.Location = new System.Drawing.Point(95, 18);
            this.txt_SearchShipmentNo.Name = "txt_SearchShipmentNo";
            this.txt_SearchShipmentNo.Size = new System.Drawing.Size(307, 22);
            this.txt_SearchShipmentNo.TabIndex = 2;
            // 
            // lbl_PackageCode
            // 
            this.lbl_PackageCode.AutoSize = true;
            this.lbl_PackageCode.Location = new System.Drawing.Point(20, 21);
            this.lbl_PackageCode.Name = "lbl_PackageCode";
            this.lbl_PackageCode.Size = new System.Drawing.Size(60, 12);
            this.lbl_PackageCode.TabIndex = 1;
            this.lbl_PackageCode.Text = "Invoice No:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(421, 18);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 22);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_selectInvoice
            // 
            this.btn_selectInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectInvoice.Location = new System.Drawing.Point(3, 232);
            this.btn_selectInvoice.Name = "btn_selectInvoice";
            this.btn_selectInvoice.Size = new System.Drawing.Size(769, 168);
            this.btn_selectInvoice.TabIndex = 15;
            this.btn_selectInvoice.Text = "Select Invoice";
            this.btn_selectInvoice.UseVisualStyleBackColor = true;
            this.btn_selectInvoice.Click += new System.EventHandler(this.btn_selectInvoice_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(681, 16);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(54, 23);
            this.btnImport.TabIndex = 6;
            this.btnImport.Text = "...";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Import invoice:";
            // 
            // ImportInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 402);
            this.Controls.Add(this.btn_selectInvoice);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportInvoice";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ImportInvoice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SearchShipmentNo;
        private System.Windows.Forms.Label lbl_PackageCode;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_selectInvoice;
        private System.Windows.Forms.ListView lvw_InvoiceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImport;
    }
}