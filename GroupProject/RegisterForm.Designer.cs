
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tbxPostCode = new System.Windows.Forms.TextBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.tbxRePassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.llblCheckAccountValid = new System.Windows.Forms.LinkLabel();
            this.llblOldUser = new System.Windows.Forms.LinkLabel();
            this.checkBoxEmailNotice = new System.Windows.Forms.CheckBox();
            this.checkBoxPolicy = new System.Windows.Forms.CheckBox();
            this.rbBussinessP = new System.Windows.Forms.RadioButton();
            this.lblBussiness = new System.Windows.Forms.Label();
            this.rbBussinessC = new System.Windows.Forms.RadioButton();
            this.tbxPhonePrefix = new System.Windows.Forms.TextBox();
            this.tbxFax = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxAccount = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(270, 629);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(149, 41);
            this.btn_Cancel.TabIndex = 36;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(12, 629);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(136, 41);
            this.btn_Submit.TabIndex = 34;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(26, 10);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(369, 23);
            this.lbl_Title.TabIndex = 21;
            this.lbl_Title.Text = "Delivery Express System: Register Account";
            // 
            // tbxPostCode
            // 
            this.tbxPostCode.Location = new System.Drawing.Point(108, 510);
            this.tbxPostCode.Name = "tbxPostCode";
            this.tbxPostCode.Size = new System.Drawing.Size(262, 20);
            this.tbxPostCode.TabIndex = 70;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(26, 513);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(59, 13);
            this.lblPostCode.TabIndex = 85;
            this.lblPostCode.Text = "Post Code:";
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Checked = true;
            this.checkBoxPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPassword.Enabled = false;
            this.checkBoxPassword.Location = new System.Drawing.Point(321, 243);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(49, 17);
            this.checkBoxPassword.TabIndex = 84;
            this.checkBoxPassword.Text = "Valid";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.Visible = false;
            // 
            // tbxRePassword
            // 
            this.tbxRePassword.Location = new System.Drawing.Point(108, 241);
            this.tbxRePassword.MaxLength = 16;
            this.tbxRePassword.Name = "tbxRePassword";
            this.tbxRePassword.PasswordChar = '*';
            this.tbxRePassword.Size = new System.Drawing.Size(200, 20);
            this.tbxRePassword.TabIndex = 64;
            this.tbxRePassword.TextChanged += new System.EventHandler(this.CheckPassword);
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(27, 244);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(73, 13);
            this.lblRePassword.TabIndex = 83;
            this.lblRePassword.Text = "Re-Enter Pw: ";
            // 
            // llblCheckAccountValid
            // 
            this.llblCheckAccountValid.AutoSize = true;
            this.llblCheckAccountValid.Location = new System.Drawing.Point(315, 167);
            this.llblCheckAccountValid.Name = "llblCheckAccountValid";
            this.llblCheckAccountValid.Size = new System.Drawing.Size(86, 13);
            this.llblCheckAccountValid.TabIndex = 74;
            this.llblCheckAccountValid.TabStop = true;
            this.llblCheckAccountValid.Text = "Check validation";
            this.llblCheckAccountValid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCheckAccountValid_LinkClicked);
            // 
            // llblOldUser
            // 
            this.llblOldUser.AutoSize = true;
            this.llblOldUser.Location = new System.Drawing.Point(296, 63);
            this.llblOldUser.Name = "llblOldUser";
            this.llblOldUser.Size = new System.Drawing.Size(104, 13);
            this.llblOldUser.TabIndex = 73;
            this.llblOldUser.TabStop = true;
            this.llblOldUser.Text = "Already a Customer?";
            this.llblOldUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblOldUser_LinkClicked);
            // 
            // checkBoxEmailNotice
            // 
            this.checkBoxEmailNotice.AutoSize = true;
            this.checkBoxEmailNotice.Location = new System.Drawing.Point(28, 593);
            this.checkBoxEmailNotice.Name = "checkBoxEmailNotice";
            this.checkBoxEmailNotice.Size = new System.Drawing.Size(335, 17);
            this.checkBoxEmailNotice.TabIndex = 72;
            this.checkBoxEmailNotice.Text = "I want to receive the company email, advertise and policy update.";
            this.checkBoxEmailNotice.UseVisualStyleBackColor = true;
            // 
            // checkBoxPolicy
            // 
            this.checkBoxPolicy.AutoSize = true;
            this.checkBoxPolicy.Location = new System.Drawing.Point(28, 558);
            this.checkBoxPolicy.Name = "checkBoxPolicy";
            this.checkBoxPolicy.Size = new System.Drawing.Size(163, 17);
            this.checkBoxPolicy.TabIndex = 71;
            this.checkBoxPolicy.Text = "I confirm the company policy.";
            this.checkBoxPolicy.UseVisualStyleBackColor = true;
            this.checkBoxPolicy.CheckedChanged += new System.EventHandler(this.checkBoxPolicy_CheckedChanged);
            // 
            // rbBussinessP
            // 
            this.rbBussinessP.AutoSize = true;
            this.rbBussinessP.Location = new System.Drawing.Point(234, 330);
            this.rbBussinessP.Name = "rbBussinessP";
            this.rbBussinessP.Size = new System.Drawing.Size(66, 17);
            this.rbBussinessP.TabIndex = 67;
            this.rbBussinessP.TabStop = true;
            this.rbBussinessP.Text = "Personal";
            this.rbBussinessP.UseVisualStyleBackColor = true;
            // 
            // lblBussiness
            // 
            this.lblBussiness.AutoSize = true;
            this.lblBussiness.Location = new System.Drawing.Point(27, 332);
            this.lblBussiness.Name = "lblBussiness";
            this.lblBussiness.Size = new System.Drawing.Size(84, 13);
            this.lblBussiness.TabIndex = 82;
            this.lblBussiness.Text = "Bussiness Type:";
            // 
            // rbBussinessC
            // 
            this.rbBussinessC.AutoSize = true;
            this.rbBussinessC.Location = new System.Drawing.Point(128, 330);
            this.rbBussinessC.Name = "rbBussinessC";
            this.rbBussinessC.Size = new System.Drawing.Size(69, 17);
            this.rbBussinessC.TabIndex = 66;
            this.rbBussinessC.TabStop = true;
            this.rbBussinessC.Text = "Company";
            this.rbBussinessC.UseVisualStyleBackColor = true;
            // 
            // tbxPhonePrefix
            // 
            this.tbxPhonePrefix.Location = new System.Drawing.Point(128, 91);
            this.tbxPhonePrefix.Name = "tbxPhonePrefix";
            this.tbxPhonePrefix.Size = new System.Drawing.Size(51, 20);
            this.tbxPhonePrefix.TabIndex = 60;
            // 
            // tbxFax
            // 
            this.tbxFax.Location = new System.Drawing.Point(108, 369);
            this.tbxFax.Name = "tbxFax";
            this.tbxFax.Size = new System.Drawing.Size(262, 20);
            this.tbxFax.TabIndex = 68;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(27, 372);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(67, 13);
            this.lblFax.TabIndex = 81;
            this.lblFax.Text = "Fax Number:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(108, 413);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(262, 76);
            this.tbxAddress.TabIndex = 69;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(198, 91);
            this.tbxPhone.MaxLength = 15;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(172, 20);
            this.tbxPhone.TabIndex = 61;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(108, 286);
            this.tbxEmail.MaxLength = 50;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(262, 20);
            this.tbxEmail.TabIndex = 65;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(108, 199);
            this.tbxPassword.MaxLength = 16;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(200, 20);
            this.tbxPassword.TabIndex = 63;
            this.tbxPassword.TextChanged += new System.EventHandler(this.CheckPassword);
            // 
            // tbxAccount
            // 
            this.tbxAccount.Location = new System.Drawing.Point(108, 156);
            this.tbxAccount.MaxLength = 16;
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.Size = new System.Drawing.Size(200, 20);
            this.tbxAccount.TabIndex = 62;
            this.tbxAccount.TextChanged += new System.EventHandler(this.tbxAccount_TextChanged);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(108, 52);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(182, 20);
            this.tbxName.TabIndex = 59;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(27, 416);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 80;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(27, 95);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(168, 13);
            this.lblPhone.TabIndex = 79;
            this.lblPhone.Text = "Phone Number:     +                     -";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 290);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(76, 13);
            this.lblEmail.TabIndex = 78;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 202);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 77;
            this.lblPassword.Text = "Password: ";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(26, 160);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(84, 13);
            this.lblAccount.TabIndex = 76;
            this.lblAccount.Text = "Account Name: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 75;
            this.lblName.Text = "Name:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 682);
            this.Controls.Add(this.tbxPostCode);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.tbxRePassword);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.llblCheckAccountValid);
            this.Controls.Add(this.llblOldUser);
            this.Controls.Add(this.checkBoxEmailNotice);
            this.Controls.Add(this.checkBoxPolicy);
            this.Controls.Add(this.rbBussinessP);
            this.Controls.Add(this.lblBussiness);
            this.Controls.Add(this.rbBussinessC);
            this.Controls.Add(this.tbxPhonePrefix);
            this.Controls.Add(this.tbxFax);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxAccount);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Title);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TextBox tbxPostCode;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.TextBox tbxRePassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.LinkLabel llblCheckAccountValid;
        private System.Windows.Forms.LinkLabel llblOldUser;
        private System.Windows.Forms.CheckBox checkBoxEmailNotice;
        private System.Windows.Forms.CheckBox checkBoxPolicy;
        private System.Windows.Forms.RadioButton rbBussinessP;
        private System.Windows.Forms.Label lblBussiness;
        private System.Windows.Forms.RadioButton rbBussinessC;
        private System.Windows.Forms.TextBox tbxPhonePrefix;
        private System.Windows.Forms.TextBox tbxFax;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxAccount;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblName;
    }
}