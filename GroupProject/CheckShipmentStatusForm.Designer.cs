
namespace GroupProject
{
    partial class CheckShipmentStatusForm
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
            this.lvw_TrackShipmentList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ShipmentNo = new System.Windows.Forms.Label();
            this.lbl_CenterID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_GatewayID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Insurance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_ShipmentCreateDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_PickupTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_PickupDate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_PickupOrderID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvw_TrackShipmentList
            // 
            this.lvw_TrackShipmentList.GridLines = true;
            this.lvw_TrackShipmentList.HideSelection = false;
            this.lvw_TrackShipmentList.Location = new System.Drawing.Point(0, 12);
            this.lvw_TrackShipmentList.Name = "lvw_TrackShipmentList";
            this.lvw_TrackShipmentList.Size = new System.Drawing.Size(107, 414);
            this.lvw_TrackShipmentList.TabIndex = 0;
            this.lvw_TrackShipmentList.UseCompatibleStateImageBehavior = false;
            this.lvw_TrackShipmentList.View = System.Windows.Forms.View.Details;
            this.lvw_TrackShipmentList.SelectedIndexChanged += new System.EventHandler(this.lvw_TrackShipmentList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shipment No";
            // 
            // lbl_ShipmentNo
            // 
            this.lbl_ShipmentNo.AutoSize = true;
            this.lbl_ShipmentNo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShipmentNo.Location = new System.Drawing.Point(20, 55);
            this.lbl_ShipmentNo.Name = "lbl_ShipmentNo";
            this.lbl_ShipmentNo.Size = new System.Drawing.Size(48, 16);
            this.lbl_ShipmentNo.TabIndex = 2;
            this.lbl_ShipmentNo.Text = "- - -";
            // 
            // lbl_CenterID
            // 
            this.lbl_CenterID.AutoSize = true;
            this.lbl_CenterID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CenterID.Location = new System.Drawing.Point(20, 213);
            this.lbl_CenterID.Name = "lbl_CenterID";
            this.lbl_CenterID.Size = new System.Drawing.Size(48, 16);
            this.lbl_CenterID.TabIndex = 4;
            this.lbl_CenterID.Text = "- - -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Center ID";
            // 
            // lbl_GatewayID
            // 
            this.lbl_GatewayID.AutoSize = true;
            this.lbl_GatewayID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GatewayID.Location = new System.Drawing.Point(20, 292);
            this.lbl_GatewayID.Name = "lbl_GatewayID";
            this.lbl_GatewayID.Size = new System.Drawing.Size(48, 16);
            this.lbl_GatewayID.TabIndex = 6;
            this.lbl_GatewayID.Text = "- - -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gateway ID";
            // 
            // lbl_Insurance
            // 
            this.lbl_Insurance.AutoSize = true;
            this.lbl_Insurance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Insurance.Location = new System.Drawing.Point(20, 371);
            this.lbl_Insurance.Name = "lbl_Insurance";
            this.lbl_Insurance.Size = new System.Drawing.Size(48, 16);
            this.lbl_Insurance.TabIndex = 8;
            this.lbl_Insurance.Text = "- - -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Insurance";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(20, 134);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(48, 16);
            this.lbl_Status.TabIndex = 10;
            this.lbl_Status.Text = "- - -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status";
            // 
            // lbl_ShipmentCreateDate
            // 
            this.lbl_ShipmentCreateDate.AutoSize = true;
            this.lbl_ShipmentCreateDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShipmentCreateDate.Location = new System.Drawing.Point(343, 134);
            this.lbl_ShipmentCreateDate.Name = "lbl_ShipmentCreateDate";
            this.lbl_ShipmentCreateDate.Size = new System.Drawing.Size(48, 16);
            this.lbl_ShipmentCreateDate.TabIndex = 20;
            this.lbl_ShipmentCreateDate.Text = "- - -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(342, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Shipment Create Date";
            // 
            // lbl_PickupTime
            // 
            this.lbl_PickupTime.AutoSize = true;
            this.lbl_PickupTime.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PickupTime.Location = new System.Drawing.Point(343, 292);
            this.lbl_PickupTime.Name = "lbl_PickupTime";
            this.lbl_PickupTime.Size = new System.Drawing.Size(48, 16);
            this.lbl_PickupTime.TabIndex = 16;
            this.lbl_PickupTime.Text = "- - -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(342, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Pickup Time";
            // 
            // lbl_PickupDate
            // 
            this.lbl_PickupDate.AutoSize = true;
            this.lbl_PickupDate.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PickupDate.Location = new System.Drawing.Point(343, 213);
            this.lbl_PickupDate.Name = "lbl_PickupDate";
            this.lbl_PickupDate.Size = new System.Drawing.Size(48, 16);
            this.lbl_PickupDate.TabIndex = 14;
            this.lbl_PickupDate.Text = "- - -";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(342, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Pickup Date";
            // 
            // lbl_PickupOrderID
            // 
            this.lbl_PickupOrderID.AutoSize = true;
            this.lbl_PickupOrderID.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PickupOrderID.Location = new System.Drawing.Point(343, 55);
            this.lbl_PickupOrderID.Name = "lbl_PickupOrderID";
            this.lbl_PickupOrderID.Size = new System.Drawing.Size(48, 16);
            this.lbl_PickupOrderID.TabIndex = 12;
            this.lbl_PickupOrderID.Text = "- - -";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(342, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Pickup Order ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Refresh);
            this.panel1.Controls.Add(this.lbl_ShipmentCreateDate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_PickupTime);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_PickupDate);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lbl_PickupOrderID);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(113, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 414);
            this.panel1.TabIndex = 21;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(586, 386);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 21;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_ShipmentNo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbl_CenterID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_GatewayID);
            this.panel2.Controls.Add(this.lbl_Insurance);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_Status);
            this.panel2.Location = new System.Drawing.Point(113, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 414);
            this.panel2.TabIndex = 22;
            // 
            // CheckShipmentStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvw_TrackShipmentList);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckShipmentStatusForm";
            this.Text = "CheckShipmentStatusForm";
            this.Load += new System.EventHandler(this.CheckShipmentStatusForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvw_TrackShipmentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ShipmentNo;
        private System.Windows.Forms.Label lbl_CenterID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_GatewayID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Insurance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_ShipmentCreateDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_PickupTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_PickupDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_PickupOrderID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Panel panel2;
    }
}