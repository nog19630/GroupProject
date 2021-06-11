
namespace GroupProject
{
    partial class UpdateShipmentStatusForm
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
            this.txt_CurrentStatus = new System.Windows.Forms.TextBox();
            this.txt_ChangeStatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtx_CustomMessage = new System.Windows.Forms.RichTextBox();
            this.txt_ReceiverID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chk_SendChangedMessage = new System.Windows.Forms.CheckBox();
            this.chk_CustomMessage = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change Status";
            // 
            // txt_CurrentStatus
            // 
            this.txt_CurrentStatus.Location = new System.Drawing.Point(12, 28);
            this.txt_CurrentStatus.Name = "txt_CurrentStatus";
            this.txt_CurrentStatus.ReadOnly = true;
            this.txt_CurrentStatus.Size = new System.Drawing.Size(106, 22);
            this.txt_CurrentStatus.TabIndex = 2;
            // 
            // txt_ChangeStatus
            // 
            this.txt_ChangeStatus.Location = new System.Drawing.Point(206, 28);
            this.txt_ChangeStatus.Name = "txt_ChangeStatus";
            this.txt_ChangeStatus.ReadOnly = true;
            this.txt_ChangeStatus.Size = new System.Drawing.Size(106, 22);
            this.txt_ChangeStatus.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtx_CustomMessage);
            this.groupBox1.Controls.Add(this.txt_ReceiverID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chk_SendChangedMessage);
            this.groupBox1.Controls.Add(this.chk_CustomMessage);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advance notification of shipment information";
            // 
            // rtx_CustomMessage
            // 
            this.rtx_CustomMessage.Location = new System.Drawing.Point(6, 117);
            this.rtx_CustomMessage.Name = "rtx_CustomMessage";
            this.rtx_CustomMessage.Size = new System.Drawing.Size(287, 153);
            this.rtx_CustomMessage.TabIndex = 9;
            this.rtx_CustomMessage.Text = "";
            // 
            // txt_ReceiverID
            // 
            this.txt_ReceiverID.Location = new System.Drawing.Point(6, 41);
            this.txt_ReceiverID.Name = "txt_ReceiverID";
            this.txt_ReceiverID.ReadOnly = true;
            this.txt_ReceiverID.Size = new System.Drawing.Size(288, 22);
            this.txt_ReceiverID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Receiver ID";
            // 
            // chk_SendChangedMessage
            // 
            this.chk_SendChangedMessage.AutoSize = true;
            this.chk_SendChangedMessage.Checked = true;
            this.chk_SendChangedMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_SendChangedMessage.Location = new System.Drawing.Point(6, 73);
            this.chk_SendChangedMessage.Name = "chk_SendChangedMessage";
            this.chk_SendChangedMessage.Size = new System.Drawing.Size(167, 16);
            this.chk_SendChangedMessage.TabIndex = 2;
            this.chk_SendChangedMessage.Text = "Send Status Changed  Message";
            this.chk_SendChangedMessage.UseVisualStyleBackColor = true;
            // 
            // chk_CustomMessage
            // 
            this.chk_CustomMessage.AutoSize = true;
            this.chk_CustomMessage.Location = new System.Drawing.Point(6, 95);
            this.chk_CustomMessage.Name = "chk_CustomMessage";
            this.chk_CustomMessage.Size = new System.Drawing.Size(105, 16);
            this.chk_CustomMessage.TabIndex = 0;
            this.chk_CustomMessage.Text = "Custom Message:";
            this.chk_CustomMessage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "----->";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(12, 348);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(140, 23);
            this.btn_Confirm.TabIndex = 6;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(172, 348);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(140, 23);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // UpdateShipmentStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 383);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_ChangeStatus);
            this.Controls.Add(this.txt_CurrentStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UpdateShipmentStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Shipment Status";
            this.Load += new System.EventHandler(this.UpdateStatusForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CurrentStatus;
        private System.Windows.Forms.TextBox txt_ChangeStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_ReceiverID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_SendChangedMessage;
        private System.Windows.Forms.CheckBox chk_CustomMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.RichTextBox rtx_CustomMessage;
        private System.Windows.Forms.Button btn_Cancel;
    }
}