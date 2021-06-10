
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.tbxFax = new System.Windows.Forms.TextBox();
            this.tbxPhonePrefix = new System.Windows.Forms.TextBox();
            this.rbBussinessC = new System.Windows.Forms.RadioButton();
            this.lblBussiness = new System.Windows.Forms.Label();
            this.rbBussinessP = new System.Windows.Forms.RadioButton();
            this.checkBoxPolicy = new System.Windows.Forms.CheckBox();
            this.lblNoteInfo = new System.Windows.Forms.Label();
            this.lblnote1 = new System.Windows.Forms.Label();
            this.lblnote2 = new System.Windows.Forms.Label();
            this.lblnote3 = new System.Windows.Forms.Label();
            this.lblnote4 = new System.Windows.Forms.Label();
            this.checkBoxEmailNotice = new System.Windows.Forms.CheckBox();
            this.lblnote5 = new System.Windows.Forms.Label();
            this.llblOldUser = new System.Windows.Forms.LinkLabel();
            this.llblCheckAccountValid = new System.Windows.Forms.LinkLabel();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblnote6 = new System.Windows.Forms.Label();
            this.tbxRePassword = new System.Windows.Forms.TextBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.lblnote7 = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.tbxPostCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 586);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(36, 586);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 42);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(116, 398);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(262, 70);
            this.tbxAddress.TabIndex = 10;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(206, 101);
            this.tbxPhone.MaxLength = 15;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(172, 22);
            this.tbxPhone.TabIndex = 2;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(116, 281);
            this.tbxEmail.MaxLength = 50;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(262, 22);
            this.tbxEmail.TabIndex = 6;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(116, 200);
            this.tbxPassword.MaxLength = 16;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(200, 22);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.TextChanged += new System.EventHandler(this.CheckPassword);
            // 
            // tbxAccount
            // 
            this.tbxAccount.Location = new System.Drawing.Point(116, 161);
            this.tbxAccount.MaxLength = 16;
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.Size = new System.Drawing.Size(200, 22);
            this.tbxAccount.TabIndex = 3;
            this.tbxAccount.TextChanged += new System.EventHandler(this.tbxAccount_TextChanged);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(116, 65);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(182, 22);
            this.tbxName.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(35, 401);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 12);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(35, 104);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(166, 12);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "Phone Number:     +                     -";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 284);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 12);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(35, 203);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 12);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password: ";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(34, 164);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(80, 12);
            this.lblAccount.TabIndex = 23;
            this.lblAccount.Text = "Account Name: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 12);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(369, 23);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "Delivery Express System: Register Account";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(35, 360);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(66, 12);
            this.lblFax.TabIndex = 37;
            this.lblFax.Text = "Fax Number:";
            // 
            // tbxFax
            // 
            this.tbxFax.Location = new System.Drawing.Point(116, 357);
            this.tbxFax.Name = "tbxFax";
            this.tbxFax.Size = new System.Drawing.Size(262, 22);
            this.tbxFax.TabIndex = 9;
            // 
            // tbxPhonePrefix
            // 
            this.tbxPhonePrefix.Location = new System.Drawing.Point(136, 101);
            this.tbxPhonePrefix.Name = "tbxPhonePrefix";
            this.tbxPhonePrefix.Size = new System.Drawing.Size(51, 22);
            this.tbxPhonePrefix.TabIndex = 1;
            // 
            // rbBussinessC
            // 
            this.rbBussinessC.AutoSize = true;
            this.rbBussinessC.Location = new System.Drawing.Point(136, 321);
            this.rbBussinessC.Name = "rbBussinessC";
            this.rbBussinessC.Size = new System.Drawing.Size(69, 16);
            this.rbBussinessC.TabIndex = 7;
            this.rbBussinessC.TabStop = true;
            this.rbBussinessC.Text = "Company";
            this.rbBussinessC.UseVisualStyleBackColor = true;
            // 
            // lblBussiness
            // 
            this.lblBussiness.AutoSize = true;
            this.lblBussiness.Location = new System.Drawing.Point(35, 323);
            this.lblBussiness.Name = "lblBussiness";
            this.lblBussiness.Size = new System.Drawing.Size(79, 12);
            this.lblBussiness.TabIndex = 41;
            this.lblBussiness.Text = "Bussiness Type:";
            // 
            // rbBussinessP
            // 
            this.rbBussinessP.AutoSize = true;
            this.rbBussinessP.Location = new System.Drawing.Point(242, 321);
            this.rbBussinessP.Name = "rbBussinessP";
            this.rbBussinessP.Size = new System.Drawing.Size(62, 16);
            this.rbBussinessP.TabIndex = 8;
            this.rbBussinessP.TabStop = true;
            this.rbBussinessP.Text = "Personal";
            this.rbBussinessP.UseVisualStyleBackColor = true;
            // 
            // checkBoxPolicy
            // 
            this.checkBoxPolicy.AutoSize = true;
            this.checkBoxPolicy.Location = new System.Drawing.Point(36, 532);
            this.checkBoxPolicy.Name = "checkBoxPolicy";
            this.checkBoxPolicy.Size = new System.Drawing.Size(166, 16);
            this.checkBoxPolicy.TabIndex = 12;
            this.checkBoxPolicy.Text = "I confirm the company policy.";
            this.checkBoxPolicy.UseVisualStyleBackColor = true;
            this.checkBoxPolicy.CheckedChanged += new System.EventHandler(this.checkBoxPolicy_CheckedChanged);
            // 
            // lblNoteInfo
            // 
            this.lblNoteInfo.AutoSize = true;
            this.lblNoteInfo.ForeColor = System.Drawing.Color.Red;
            this.lblNoteInfo.Location = new System.Drawing.Point(35, 648);
            this.lblNoteInfo.Name = "lblNoteInfo";
            this.lblNoteInfo.Size = new System.Drawing.Size(89, 12);
            this.lblNoteInfo.TabIndex = 44;
            this.lblNoteInfo.Text = "* must be filled in";
            // 
            // lblnote1
            // 
            this.lblnote1.AutoSize = true;
            this.lblnote1.ForeColor = System.Drawing.Color.Red;
            this.lblnote1.Location = new System.Drawing.Point(26, 65);
            this.lblnote1.Name = "lblnote1";
            this.lblnote1.Size = new System.Drawing.Size(11, 12);
            this.lblnote1.TabIndex = 45;
            this.lblnote1.Text = "*";
            // 
            // lblnote2
            // 
            this.lblnote2.AutoSize = true;
            this.lblnote2.ForeColor = System.Drawing.Color.Red;
            this.lblnote2.Location = new System.Drawing.Point(26, 161);
            this.lblnote2.Name = "lblnote2";
            this.lblnote2.Size = new System.Drawing.Size(11, 12);
            this.lblnote2.TabIndex = 46;
            this.lblnote2.Text = "*";
            // 
            // lblnote3
            // 
            this.lblnote3.AutoSize = true;
            this.lblnote3.ForeColor = System.Drawing.Color.Red;
            this.lblnote3.Location = new System.Drawing.Point(26, 200);
            this.lblnote3.Name = "lblnote3";
            this.lblnote3.Size = new System.Drawing.Size(11, 12);
            this.lblnote3.TabIndex = 47;
            this.lblnote3.Text = "*";
            // 
            // lblnote4
            // 
            this.lblnote4.AutoSize = true;
            this.lblnote4.ForeColor = System.Drawing.Color.Red;
            this.lblnote4.Location = new System.Drawing.Point(26, 281);
            this.lblnote4.Name = "lblnote4";
            this.lblnote4.Size = new System.Drawing.Size(11, 12);
            this.lblnote4.TabIndex = 48;
            this.lblnote4.Text = "*";
            // 
            // checkBoxEmailNotice
            // 
            this.checkBoxEmailNotice.AutoSize = true;
            this.checkBoxEmailNotice.Location = new System.Drawing.Point(36, 564);
            this.checkBoxEmailNotice.Name = "checkBoxEmailNotice";
            this.checkBoxEmailNotice.Size = new System.Drawing.Size(328, 16);
            this.checkBoxEmailNotice.TabIndex = 13;
            this.checkBoxEmailNotice.Text = "I want to receive the company email, advertise and policy update.";
            this.checkBoxEmailNotice.UseVisualStyleBackColor = true;
            // 
            // lblnote5
            // 
            this.lblnote5.AutoSize = true;
            this.lblnote5.ForeColor = System.Drawing.Color.Red;
            this.lblnote5.Location = new System.Drawing.Point(26, 101);
            this.lblnote5.Name = "lblnote5";
            this.lblnote5.Size = new System.Drawing.Size(11, 12);
            this.lblnote5.TabIndex = 50;
            this.lblnote5.Text = "*";
            // 
            // llblOldUser
            // 
            this.llblOldUser.AutoSize = true;
            this.llblOldUser.Location = new System.Drawing.Point(304, 75);
            this.llblOldUser.Name = "llblOldUser";
            this.llblOldUser.Size = new System.Drawing.Size(103, 12);
            this.llblOldUser.TabIndex = 16;
            this.llblOldUser.TabStop = true;
            this.llblOldUser.Text = "Already a Customer?";
            this.llblOldUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblOldUser_LinkClicked);
            // 
            // llblCheckAccountValid
            // 
            this.llblCheckAccountValid.AutoSize = true;
            this.llblCheckAccountValid.Location = new System.Drawing.Point(323, 171);
            this.llblCheckAccountValid.Name = "llblCheckAccountValid";
            this.llblCheckAccountValid.Size = new System.Drawing.Size(84, 12);
            this.llblCheckAccountValid.TabIndex = 17;
            this.llblCheckAccountValid.TabStop = true;
            this.llblCheckAccountValid.Text = "Check validation";
            this.llblCheckAccountValid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCheckAccountValid_LinkClicked);
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(35, 242);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(70, 12);
            this.lblRePassword.TabIndex = 53;
            this.lblRePassword.Text = "Re-Enter Pw: ";
            // 
            // lblnote6
            // 
            this.lblnote6.AutoSize = true;
            this.lblnote6.ForeColor = System.Drawing.Color.Red;
            this.lblnote6.Location = new System.Drawing.Point(26, 239);
            this.lblnote6.Name = "lblnote6";
            this.lblnote6.Size = new System.Drawing.Size(11, 12);
            this.lblnote6.TabIndex = 54;
            this.lblnote6.Text = "*";
            // 
            // tbxRePassword
            // 
            this.tbxRePassword.Location = new System.Drawing.Point(116, 239);
            this.tbxRePassword.MaxLength = 16;
            this.tbxRePassword.Name = "tbxRePassword";
            this.tbxRePassword.PasswordChar = '*';
            this.tbxRePassword.Size = new System.Drawing.Size(200, 22);
            this.tbxRePassword.TabIndex = 5;
            this.tbxRePassword.TextChanged += new System.EventHandler(this.CheckPassword);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Checked = true;
            this.checkBoxPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPassword.Enabled = false;
            this.checkBoxPassword.Location = new System.Drawing.Point(329, 241);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(49, 16);
            this.checkBoxPassword.TabIndex = 56;
            this.checkBoxPassword.Text = "Valid";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.Visible = false;
            // 
            // lblnote7
            // 
            this.lblnote7.AutoSize = true;
            this.lblnote7.ForeColor = System.Drawing.Color.Red;
            this.lblnote7.Location = new System.Drawing.Point(26, 398);
            this.lblnote7.Name = "lblnote7";
            this.lblnote7.Size = new System.Drawing.Size(11, 12);
            this.lblnote7.TabIndex = 57;
            this.lblnote7.Text = "*";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(34, 490);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(55, 12);
            this.lblPostCode.TabIndex = 58;
            this.lblPostCode.Text = "Post Code:";
            // 
            // tbxPostCode
            // 
            this.tbxPostCode.Location = new System.Drawing.Point(116, 487);
            this.tbxPostCode.Name = "tbxPostCode";
            this.tbxPostCode.Size = new System.Drawing.Size(262, 22);
            this.tbxPostCode.TabIndex = 11;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 683);
            this.Controls.Add(this.tbxPostCode);
            this.Controls.Add(this.lblPostCode);
            this.Controls.Add(this.lblnote7);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.tbxRePassword);
            this.Controls.Add(this.lblnote6);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.llblCheckAccountValid);
            this.Controls.Add(this.llblOldUser);
            this.Controls.Add(this.lblnote5);
            this.Controls.Add(this.checkBoxEmailNotice);
            this.Controls.Add(this.lblnote4);
            this.Controls.Add(this.lblnote3);
            this.Controls.Add(this.lblnote2);
            this.Controls.Add(this.lblnote1);
            this.Controls.Add(this.lblNoteInfo);
            this.Controls.Add(this.checkBoxPolicy);
            this.Controls.Add(this.rbBussinessP);
            this.Controls.Add(this.lblBussiness);
            this.Controls.Add(this.rbBussinessC);
            this.Controls.Add(this.tbxPhonePrefix);
            this.Controls.Add(this.tbxFax);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
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
            this.Controls.Add(this.lblTitle);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox tbxFax;
        private System.Windows.Forms.TextBox tbxPhonePrefix;
        private System.Windows.Forms.RadioButton rbBussinessC;
        private System.Windows.Forms.Label lblBussiness;
        private System.Windows.Forms.RadioButton rbBussinessP;
        private System.Windows.Forms.CheckBox checkBoxPolicy;
        private System.Windows.Forms.Label lblNoteInfo;
        private System.Windows.Forms.Label lblnote1;
        private System.Windows.Forms.Label lblnote2;
        private System.Windows.Forms.Label lblnote3;
        private System.Windows.Forms.Label lblnote4;
        private System.Windows.Forms.CheckBox checkBoxEmailNotice;
        private System.Windows.Forms.Label lblnote5;
        private System.Windows.Forms.LinkLabel llblOldUser;
        private System.Windows.Forms.LinkLabel llblCheckAccountValid;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label lblnote6;
        private System.Windows.Forms.TextBox tbxRePassword;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.Label lblnote7;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.TextBox tbxPostCode;
    }
}