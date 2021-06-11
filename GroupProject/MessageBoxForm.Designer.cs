
namespace GroupProject
{
    partial class MessageBoxForm
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
            this.rtx_MessageContent = new System.Windows.Forms.RichTextBox();
            this.lvw_MessageList = new System.Windows.Forms.ListView();
            this.btn_UpdateList = new System.Windows.Forms.Button();
            this.btn_DeleteMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Message List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Message Content";
            // 
            // rtx_MessageContent
            // 
            this.rtx_MessageContent.Location = new System.Drawing.Point(12, 197);
            this.rtx_MessageContent.Name = "rtx_MessageContent";
            this.rtx_MessageContent.ReadOnly = true;
            this.rtx_MessageContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtx_MessageContent.Size = new System.Drawing.Size(766, 194);
            this.rtx_MessageContent.TabIndex = 9;
            this.rtx_MessageContent.Text = "";
            // 
            // lvw_MessageList
            // 
            this.lvw_MessageList.FullRowSelect = true;
            this.lvw_MessageList.GridLines = true;
            this.lvw_MessageList.HideSelection = false;
            this.lvw_MessageList.Location = new System.Drawing.Point(12, 24);
            this.lvw_MessageList.MultiSelect = false;
            this.lvw_MessageList.Name = "lvw_MessageList";
            this.lvw_MessageList.Size = new System.Drawing.Size(766, 141);
            this.lvw_MessageList.TabIndex = 10;
            this.lvw_MessageList.UseCompatibleStateImageBehavior = false;
            this.lvw_MessageList.View = System.Windows.Forms.View.Details;
            this.lvw_MessageList.SelectedIndexChanged += new System.EventHandler(this.lvw_MessageList_SelectedIndexChanged);
            // 
            // btn_UpdateList
            // 
            this.btn_UpdateList.Location = new System.Drawing.Point(12, 403);
            this.btn_UpdateList.Name = "btn_UpdateList";
            this.btn_UpdateList.Size = new System.Drawing.Size(381, 23);
            this.btn_UpdateList.TabIndex = 11;
            this.btn_UpdateList.Text = "Update List";
            this.btn_UpdateList.UseVisualStyleBackColor = true;
            this.btn_UpdateList.Click += new System.EventHandler(this.btn_UpdateList_Click);
            // 
            // btn_DeleteMessage
            // 
            this.btn_DeleteMessage.Location = new System.Drawing.Point(399, 403);
            this.btn_DeleteMessage.Name = "btn_DeleteMessage";
            this.btn_DeleteMessage.Size = new System.Drawing.Size(381, 23);
            this.btn_DeleteMessage.TabIndex = 12;
            this.btn_DeleteMessage.Text = "Delete Message";
            this.btn_DeleteMessage.UseVisualStyleBackColor = true;
            this.btn_DeleteMessage.Click += new System.EventHandler(this.btn_DeleteMessage_Click);
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 438);
            this.Controls.Add(this.btn_DeleteMessage);
            this.Controls.Add(this.btn_UpdateList);
            this.Controls.Add(this.lvw_MessageList);
            this.Controls.Add(this.rtx_MessageContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxForm";
            this.Text = "MessageBox";
            this.Load += new System.EventHandler(this.MessageBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtx_MessageContent;
        private System.Windows.Forms.ListView lvw_MessageList;
        private System.Windows.Forms.Button btn_UpdateList;
        private System.Windows.Forms.Button btn_DeleteMessage;
    }
}