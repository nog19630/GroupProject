
namespace GroupProject
{
    partial class ManageMessageForm
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
            this.lvw_MessageList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Keyword = new System.Windows.Forms.TextBox();
            this.cmb_KeywordType = new System.Windows.Forms.ComboBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.rtx_MessageContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SendNewMessage = new System.Windows.Forms.Button();
            this.btn_EditSelectedMessage = new System.Windows.Forms.Button();
            this.btn_DeleteSelectedMessage = new System.Windows.Forms.Button();
            this.btn_EditSelectedStatus = new System.Windows.Forms.Button();
            this.btn_ResetContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvw_MessageList
            // 
            this.lvw_MessageList.FullRowSelect = true;
            this.lvw_MessageList.GridLines = true;
            this.lvw_MessageList.HideSelection = false;
            this.lvw_MessageList.Location = new System.Drawing.Point(12, 48);
            this.lvw_MessageList.MultiSelect = false;
            this.lvw_MessageList.Name = "lvw_MessageList";
            this.lvw_MessageList.Size = new System.Drawing.Size(766, 134);
            this.lvw_MessageList.TabIndex = 12;
            this.lvw_MessageList.UseCompatibleStateImageBehavior = false;
            this.lvw_MessageList.View = System.Windows.Forms.View.Details;
            this.lvw_MessageList.SelectedIndexChanged += new System.EventHandler(this.lvw_MessageList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Message List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Keyword Filter: ";
            // 
            // txt_Keyword
            // 
            this.txt_Keyword.Location = new System.Drawing.Point(97, 6);
            this.txt_Keyword.Name = "txt_Keyword";
            this.txt_Keyword.Size = new System.Drawing.Size(467, 22);
            this.txt_Keyword.TabIndex = 14;
            // 
            // cmb_KeywordType
            // 
            this.cmb_KeywordType.FormattingEnabled = true;
            this.cmb_KeywordType.Location = new System.Drawing.Point(570, 8);
            this.cmb_KeywordType.Name = "cmb_KeywordType";
            this.cmb_KeywordType.Size = new System.Drawing.Size(112, 20);
            this.cmb_KeywordType.TabIndex = 15;
            this.cmb_KeywordType.SelectedIndexChanged += new System.EventHandler(this.cmb_KeywordType_SelectedIndexChanged);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(688, 5);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(90, 23);
            this.btn_Filter.TabIndex = 16;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // rtx_MessageContent
            // 
            this.rtx_MessageContent.Location = new System.Drawing.Point(12, 214);
            this.rtx_MessageContent.Name = "rtx_MessageContent";
            this.rtx_MessageContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtx_MessageContent.Size = new System.Drawing.Size(766, 175);
            this.rtx_MessageContent.TabIndex = 18;
            this.rtx_MessageContent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Message Content";
            // 
            // btn_SendNewMessage
            // 
            this.btn_SendNewMessage.Location = new System.Drawing.Point(12, 403);
            this.btn_SendNewMessage.Name = "btn_SendNewMessage";
            this.btn_SendNewMessage.Size = new System.Drawing.Size(147, 23);
            this.btn_SendNewMessage.TabIndex = 19;
            this.btn_SendNewMessage.Text = "Send New Message";
            this.btn_SendNewMessage.UseVisualStyleBackColor = true;
            this.btn_SendNewMessage.Click += new System.EventHandler(this.btn_SendNewMessage_Click);
            // 
            // btn_EditSelectedMessage
            // 
            this.btn_EditSelectedMessage.Enabled = false;
            this.btn_EditSelectedMessage.Location = new System.Drawing.Point(166, 403);
            this.btn_EditSelectedMessage.Name = "btn_EditSelectedMessage";
            this.btn_EditSelectedMessage.Size = new System.Drawing.Size(147, 23);
            this.btn_EditSelectedMessage.TabIndex = 20;
            this.btn_EditSelectedMessage.Text = "Edit Selected Message";
            this.btn_EditSelectedMessage.UseVisualStyleBackColor = true;
            this.btn_EditSelectedMessage.Click += new System.EventHandler(this.btn_EditSelectedMessage_Click);
            // 
            // btn_DeleteSelectedMessage
            // 
            this.btn_DeleteSelectedMessage.Enabled = false;
            this.btn_DeleteSelectedMessage.Location = new System.Drawing.Point(474, 403);
            this.btn_DeleteSelectedMessage.Name = "btn_DeleteSelectedMessage";
            this.btn_DeleteSelectedMessage.Size = new System.Drawing.Size(147, 23);
            this.btn_DeleteSelectedMessage.TabIndex = 21;
            this.btn_DeleteSelectedMessage.Text = "Delete Selected Message";
            this.btn_DeleteSelectedMessage.UseVisualStyleBackColor = true;
            this.btn_DeleteSelectedMessage.Click += new System.EventHandler(this.btn_DeleteSelectedMessage_Click);
            // 
            // btn_EditSelectedStatus
            // 
            this.btn_EditSelectedStatus.Enabled = false;
            this.btn_EditSelectedStatus.Location = new System.Drawing.Point(628, 403);
            this.btn_EditSelectedStatus.Name = "btn_EditSelectedStatus";
            this.btn_EditSelectedStatus.Size = new System.Drawing.Size(147, 23);
            this.btn_EditSelectedStatus.TabIndex = 22;
            this.btn_EditSelectedStatus.Text = "Edit Selected Status";
            this.btn_EditSelectedStatus.UseVisualStyleBackColor = true;
            this.btn_EditSelectedStatus.Click += new System.EventHandler(this.btn_EditSelectedStatus_Click);
            // 
            // btn_ResetContent
            // 
            this.btn_ResetContent.Location = new System.Drawing.Point(320, 403);
            this.btn_ResetContent.Name = "btn_ResetContent";
            this.btn_ResetContent.Size = new System.Drawing.Size(147, 23);
            this.btn_ResetContent.TabIndex = 23;
            this.btn_ResetContent.Text = "Reset Content";
            this.btn_ResetContent.UseVisualStyleBackColor = true;
            this.btn_ResetContent.Click += new System.EventHandler(this.btn_ResetContent_Click);
            // 
            // ManageMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 438);
            this.Controls.Add(this.btn_ResetContent);
            this.Controls.Add(this.btn_EditSelectedStatus);
            this.Controls.Add(this.btn_DeleteSelectedMessage);
            this.Controls.Add(this.btn_EditSelectedMessage);
            this.Controls.Add(this.btn_SendNewMessage);
            this.Controls.Add(this.rtx_MessageContent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.cmb_KeywordType);
            this.Controls.Add(this.txt_Keyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvw_MessageList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageMessageForm";
            this.Text = "ManageMessageForm";
            this.Load += new System.EventHandler(this.ManageMessageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvw_MessageList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Keyword;
        private System.Windows.Forms.ComboBox cmb_KeywordType;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.RichTextBox rtx_MessageContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SendNewMessage;
        private System.Windows.Forms.Button btn_EditSelectedMessage;
        private System.Windows.Forms.Button btn_DeleteSelectedMessage;
        private System.Windows.Forms.Button btn_EditSelectedStatus;
        private System.Windows.Forms.Button btn_ResetContent;
    }
}