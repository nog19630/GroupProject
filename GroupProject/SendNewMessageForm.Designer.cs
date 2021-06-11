
namespace GroupProject
{
    partial class SendNewMessageForm
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
            this.lvw_ReceiverList = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_EmailAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CustomerID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_EdeAccountID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Keyword = new System.Windows.Forms.TextBox();
            this.cmb_KeywordType = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receiver";
            // 
            // lvw_ReceiverList
            // 
            this.lvw_ReceiverList.FullRowSelect = true;
            this.lvw_ReceiverList.GridLines = true;
            this.lvw_ReceiverList.HideSelection = false;
            this.lvw_ReceiverList.Location = new System.Drawing.Point(11, 55);
            this.lvw_ReceiverList.MultiSelect = false;
            this.lvw_ReceiverList.Name = "lvw_ReceiverList";
            this.lvw_ReceiverList.Size = new System.Drawing.Size(623, 134);
            this.lvw_ReceiverList.TabIndex = 13;
            this.lvw_ReceiverList.UseCompatibleStateImageBehavior = false;
            this.lvw_ReceiverList.View = System.Windows.Forms.View.Details;
            this.lvw_ReceiverList.SelectedIndexChanged += new System.EventHandler(this.lvw_ReceiverList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_EmailAddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_CustomerName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_CustomerID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_EdeAccountID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 66);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Receiver Information";
            // 
            // txt_EmailAddress
            // 
            this.txt_EmailAddress.Location = new System.Drawing.Point(474, 35);
            this.txt_EmailAddress.Name = "txt_EmailAddress";
            this.txt_EmailAddress.ReadOnly = true;
            this.txt_EmailAddress.Size = new System.Drawing.Size(143, 22);
            this.txt_EmailAddress.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Customer Name";
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(319, 35);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.ReadOnly = true;
            this.txt_CustomerName.Size = new System.Drawing.Size(143, 22);
            this.txt_CustomerName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email Address";
            // 
            // txt_CustomerID
            // 
            this.txt_CustomerID.Location = new System.Drawing.Point(164, 35);
            this.txt_CustomerID.Name = "txt_CustomerID";
            this.txt_CustomerID.ReadOnly = true;
            this.txt_CustomerID.Size = new System.Drawing.Size(143, 22);
            this.txt_CustomerID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Customer ID";
            // 
            // txt_EdeAccountID
            // 
            this.txt_EdeAccountID.Location = new System.Drawing.Point(9, 35);
            this.txt_EdeAccountID.Name = "txt_EdeAccountID";
            this.txt_EdeAccountID.ReadOnly = true;
            this.txt_EdeAccountID.Size = new System.Drawing.Size(143, 22);
            this.txt_EdeAccountID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ede Account ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "Keyword:";
            // 
            // txt_Keyword
            // 
            this.txt_Keyword.Location = new System.Drawing.Point(67, 6);
            this.txt_Keyword.Name = "txt_Keyword";
            this.txt_Keyword.Size = new System.Drawing.Size(364, 22);
            this.txt_Keyword.TabIndex = 16;
            // 
            // cmb_KeywordType
            // 
            this.cmb_KeywordType.FormattingEnabled = true;
            this.cmb_KeywordType.Location = new System.Drawing.Point(437, 6);
            this.cmb_KeywordType.Name = "cmb_KeywordType";
            this.cmb_KeywordType.Size = new System.Drawing.Size(108, 20);
            this.cmb_KeywordType.TabIndex = 17;
            this.cmb_KeywordType.SelectedIndexChanged += new System.EventHandler(this.cmb_KeywordType_SelectedIndexChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(551, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(83, 23);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Enabled = false;
            this.btn_Send.Location = new System.Drawing.Point(418, 276);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(105, 23);
            this.btn_Send.TabIndex = 19;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(529, 276);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(105, 23);
            this.btn_Cancel.TabIndex = 19;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // SendNewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 306);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_KeywordType);
            this.Controls.Add(this.txt_Keyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvw_ReceiverList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SendNewMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Receiver ID";
            this.Load += new System.EventHandler(this.SendNewMessageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvw_ReceiverList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_EmailAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_CustomerID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_EdeAccountID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Keyword;
        private System.Windows.Forms.ComboBox cmb_KeywordType;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Cancel;
    }
}