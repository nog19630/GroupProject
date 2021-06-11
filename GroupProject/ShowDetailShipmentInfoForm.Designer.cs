
namespace GroupProject
{
    partial class ShowDetailShipmentInfoForm
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
            this.lvw_DocumentFreightList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CenterID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ServiceOtherType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ServiceType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Charge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ShipmentNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Length = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Document Freight:";
            // 
            // lvw_DocumentFreightList
            // 
            this.lvw_DocumentFreightList.FullRowSelect = true;
            this.lvw_DocumentFreightList.GridLines = true;
            this.lvw_DocumentFreightList.HideSelection = false;
            this.lvw_DocumentFreightList.Location = new System.Drawing.Point(12, 24);
            this.lvw_DocumentFreightList.MultiSelect = false;
            this.lvw_DocumentFreightList.Name = "lvw_DocumentFreightList";
            this.lvw_DocumentFreightList.Size = new System.Drawing.Size(500, 139);
            this.lvw_DocumentFreightList.TabIndex = 6;
            this.lvw_DocumentFreightList.UseCompatibleStateImageBehavior = false;
            this.lvw_DocumentFreightList.View = System.Windows.Forms.View.Details;
            this.lvw_DocumentFreightList.SelectedIndexChanged += new System.EventHandler(this.lvw_DocumentFreightList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Value);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_Height);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_Width);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_Length);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_Weight);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Charge);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_ShipmentNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_CenterID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_ServiceOtherType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_ServiceType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Quantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_ItemID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 428);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Freight Information";
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(11, 612);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(500, 26);
            this.btn_Return.TabIndex = 8;
            this.btn_Return.Text = "Return";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item ID";
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Location = new System.Drawing.Point(6, 42);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.ReadOnly = true;
            this.txt_ItemID.Size = new System.Drawing.Size(150, 22);
            this.txt_ItemID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(174, 42);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(150, 22);
            this.txt_Name.TabIndex = 3;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(342, 42);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.ReadOnly = true;
            this.txt_Quantity.Size = new System.Drawing.Size(150, 22);
            this.txt_Quantity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // txt_CenterID
            // 
            this.txt_CenterID.Location = new System.Drawing.Point(342, 96);
            this.txt_CenterID.Name = "txt_CenterID";
            this.txt_CenterID.ReadOnly = true;
            this.txt_CenterID.Size = new System.Drawing.Size(150, 22);
            this.txt_CenterID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Center ID";
            // 
            // txt_ServiceOtherType
            // 
            this.txt_ServiceOtherType.Location = new System.Drawing.Point(174, 96);
            this.txt_ServiceOtherType.Name = "txt_ServiceOtherType";
            this.txt_ServiceOtherType.ReadOnly = true;
            this.txt_ServiceOtherType.Size = new System.Drawing.Size(150, 22);
            this.txt_ServiceOtherType.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Service Other Type";
            // 
            // txt_ServiceType
            // 
            this.txt_ServiceType.Location = new System.Drawing.Point(6, 96);
            this.txt_ServiceType.Name = "txt_ServiceType";
            this.txt_ServiceType.ReadOnly = true;
            this.txt_ServiceType.Size = new System.Drawing.Size(150, 22);
            this.txt_ServiceType.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Service Type";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(6, 312);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Description.Size = new System.Drawing.Size(486, 110);
            this.txt_Description.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Description";
            // 
            // txt_Charge
            // 
            this.txt_Charge.Location = new System.Drawing.Point(174, 150);
            this.txt_Charge.Name = "txt_Charge";
            this.txt_Charge.ReadOnly = true;
            this.txt_Charge.Size = new System.Drawing.Size(150, 22);
            this.txt_Charge.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "Charge";
            // 
            // txt_ShipmentNo
            // 
            this.txt_ShipmentNo.Location = new System.Drawing.Point(6, 150);
            this.txt_ShipmentNo.Name = "txt_ShipmentNo";
            this.txt_ShipmentNo.ReadOnly = true;
            this.txt_ShipmentNo.Size = new System.Drawing.Size(150, 22);
            this.txt_ShipmentNo.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "Shipment No";
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(342, 150);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.ReadOnly = true;
            this.txt_Weight.Size = new System.Drawing.Size(150, 22);
            this.txt_Weight.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "Weight";
            // 
            // txt_Height
            // 
            this.txt_Height.Location = new System.Drawing.Point(342, 206);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.ReadOnly = true;
            this.txt_Height.Size = new System.Drawing.Size(150, 22);
            this.txt_Height.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "Height";
            // 
            // txt_Width
            // 
            this.txt_Width.Location = new System.Drawing.Point(174, 206);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.ReadOnly = true;
            this.txt_Width.Size = new System.Drawing.Size(150, 22);
            this.txt_Width.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(170, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "Width";
            // 
            // txt_Length
            // 
            this.txt_Length.Location = new System.Drawing.Point(6, 204);
            this.txt_Length.Name = "txt_Length";
            this.txt_Length.ReadOnly = true;
            this.txt_Length.Size = new System.Drawing.Size(150, 22);
            this.txt_Length.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 12);
            this.label14.TabIndex = 20;
            this.label14.Text = "Length";
            // 
            // txt_Value
            // 
            this.txt_Value.Location = new System.Drawing.Point(6, 258);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.ReadOnly = true;
            this.txt_Value.Size = new System.Drawing.Size(150, 22);
            this.txt_Value.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 12);
            this.label15.TabIndex = 26;
            this.label15.Text = "Value";
            // 
            // ShowDetailShipmentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 650);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvw_DocumentFreightList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowDetailShipmentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Detail Shipment";
            this.Load += new System.EventHandler(this.ShowDetailShipmentInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvw_DocumentFreightList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Charge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ShipmentNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_CenterID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ServiceOtherType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ServiceType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Length;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Weight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Label label15;
    }
}