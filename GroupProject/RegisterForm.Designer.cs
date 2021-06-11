
namespace GroupProject
{
    partial class RegisterForm
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Business = new System.Windows.Forms.TextBox();
            this.txt_PostCode = new System.Windows.Forms.TextBox();
            this.txt_FaxNumber = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Business = new System.Windows.Forms.Label();
            this.lbl_PostCode = new System.Windows.Forms.Label();
            this.lbl_Fax = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_CreditLimit = new System.Windows.Forms.Label();
            this.txt_CreditLimit = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CreditInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AccountAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AccountName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(290, 565);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 26);
            this.btn_Cancel.TabIndex = 36;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(160, 565);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(112, 26);
            this.btn_Reset.TabIndex = 35;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(30, 565);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(112, 26);
            this.btn_Submit.TabIndex = 34;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(101, 266);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(247, 70);
            this.txt_Address.TabIndex = 33;
            // 
            // txt_Business
            // 
            this.txt_Business.Location = new System.Drawing.Point(101, 157);
            this.txt_Business.Name = "txt_Business";
            this.txt_Business.Size = new System.Drawing.Size(247, 22);
            this.txt_Business.TabIndex = 32;
            // 
            // txt_PostCode
            // 
            this.txt_PostCode.Location = new System.Drawing.Point(101, 123);
            this.txt_PostCode.Name = "txt_PostCode";
            this.txt_PostCode.Size = new System.Drawing.Size(247, 22);
            this.txt_PostCode.TabIndex = 31;
            // 
            // txt_FaxNumber
            // 
            this.txt_FaxNumber.Location = new System.Drawing.Point(101, 89);
            this.txt_FaxNumber.Name = "txt_FaxNumber";
            this.txt_FaxNumber.Size = new System.Drawing.Size(247, 22);
            this.txt_FaxNumber.TabIndex = 30;
            this.txt_FaxNumber.UseSystemPasswordChar = true;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(101, 55);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(247, 22);
            this.txt_PhoneNumber.TabIndex = 29;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(101, 21);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(247, 22);
            this.txt_UserName.TabIndex = 28;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(5, 269);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(54, 12);
            this.lbl_Address.TabIndex = 27;
            this.lbl_Address.Text = "* Address:";
            // 
            // lbl_Business
            // 
            this.lbl_Business.AutoSize = true;
            this.lbl_Business.Location = new System.Drawing.Point(5, 160);
            this.lbl_Business.Name = "lbl_Business";
            this.lbl_Business.Size = new System.Drawing.Size(48, 12);
            this.lbl_Business.TabIndex = 26;
            this.lbl_Business.Text = "Business:";
            // 
            // lbl_PostCode
            // 
            this.lbl_PostCode.AutoSize = true;
            this.lbl_PostCode.Location = new System.Drawing.Point(5, 126);
            this.lbl_PostCode.Name = "lbl_PostCode";
            this.lbl_PostCode.Size = new System.Drawing.Size(55, 12);
            this.lbl_PostCode.TabIndex = 25;
            this.lbl_PostCode.Text = "Post Code:";
            // 
            // lbl_Fax
            // 
            this.lbl_Fax.AutoSize = true;
            this.lbl_Fax.Location = new System.Drawing.Point(5, 92);
            this.lbl_Fax.Name = "lbl_Fax";
            this.lbl_Fax.Size = new System.Drawing.Size(69, 12);
            this.lbl_Fax.TabIndex = 24;
            this.lbl_Fax.Text = "Fax Number: ";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(5, 58);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(90, 12);
            this.lbl_PhoneNumber.TabIndex = 23;
            this.lbl_PhoneNumber.Text = "* Phone Number: ";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(5, 24);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(68, 12);
            this.lbl_UserName.TabIndex = 22;
            this.lbl_UserName.Text = "* User Name:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(26, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(369, 23);
            this.lbl_Title.TabIndex = 21;
            this.lbl_Title.Text = "Delivery Express System: Register Account";
            // 
            // lbl_CreditLimit
            // 
            this.lbl_CreditLimit.AutoSize = true;
            this.lbl_CreditLimit.Location = new System.Drawing.Point(5, 196);
            this.lbl_CreditLimit.Name = "lbl_CreditLimit";
            this.lbl_CreditLimit.Size = new System.Drawing.Size(65, 12);
            this.lbl_CreditLimit.TabIndex = 37;
            this.lbl_CreditLimit.Text = "Credit Limit:";
            // 
            // txt_CreditLimit
            // 
            this.txt_CreditLimit.Location = new System.Drawing.Point(101, 193);
            this.txt_CreditLimit.Name = "txt_CreditLimit";
            this.txt_CreditLimit.Size = new System.Drawing.Size(247, 22);
            this.txt_CreditLimit.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_CreditInfo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_CreditLimit);
            this.groupBox1.Controls.Add(this.lbl_CreditLimit);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.txt_Business);
            this.groupBox1.Controls.Add(this.txt_PostCode);
            this.groupBox1.Controls.Add(this.txt_FaxNumber);
            this.groupBox1.Controls.Add(this.txt_PhoneNumber);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Controls.Add(this.lbl_Address);
            this.groupBox1.Controls.Add(this.lbl_Business);
            this.groupBox1.Controls.Add(this.lbl_PostCode);
            this.groupBox1.Controls.Add(this.lbl_Fax);
            this.groupBox1.Controls.Add(this.lbl_PhoneNumber);
            this.groupBox1.Controls.Add(this.lbl_UserName);
            this.groupBox1.Location = new System.Drawing.Point(30, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 354);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Password);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_AccountName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_AccountAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(30, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 129);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "Credit Information:";
            // 
            // txt_CreditInfo
            // 
            this.txt_CreditInfo.Location = new System.Drawing.Point(101, 228);
            this.txt_CreditInfo.Name = "txt_CreditInfo";
            this.txt_CreditInfo.Size = new System.Drawing.Size(247, 22);
            this.txt_CreditInfo.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "* Account Address:";
            // 
            // txt_AccountAddress
            // 
            this.txt_AccountAddress.Location = new System.Drawing.Point(101, 24);
            this.txt_AccountAddress.Name = "txt_AccountAddress";
            this.txt_AccountAddress.Size = new System.Drawing.Size(247, 22);
            this.txt_AccountAddress.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 12);
            this.label3.TabIndex = 42;
            this.label3.Text = "* Account Name:";
            // 
            // txt_AccountName
            // 
            this.txt_AccountName.Location = new System.Drawing.Point(101, 56);
            this.txt_AccountName.Name = "txt_AccountName";
            this.txt_AccountName.Size = new System.Drawing.Size(247, 22);
            this.txt_AccountName.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 12);
            this.label4.TabIndex = 44;
            this.label4.Text = "* Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(101, 90);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(247, 22);
            this.txt_Password.TabIndex = 45;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Title);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Business;
        private System.Windows.Forms.TextBox txt_PostCode;
        private System.Windows.Forms.TextBox txt_FaxNumber;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Business;
        private System.Windows.Forms.Label lbl_PostCode;
        private System.Windows.Forms.Label lbl_Fax;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_CreditLimit;
        private System.Windows.Forms.TextBox txt_CreditLimit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_CreditInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AccountName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_AccountAddress;
        private System.Windows.Forms.Label label2;
    }
}