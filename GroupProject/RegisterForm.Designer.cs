
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(270, 581);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(149, 38);
            this.btn_Cancel.TabIndex = 36;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(12, 581);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(136, 38);
            this.btn_Submit.TabIndex = 34;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
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
            // tbxPostCode
            // 
            this.tbxPostCode.Location = new System.Drawing.Point(108, 471);
            this.tbxPostCode.Name = "tbxPostCode";
            this.tbxPostCode.Size = new System.Drawing.Size(262, 22);
            this.tbxPostCode.TabIndex = 70;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(26, 474);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(55, 12);
            this.lblPostCode.TabIndex = 85;
            this.lblPostCode.Text = "Post Code:";
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Checked = true;
            this.checkBoxPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPassword.Enabled = false;
            this.checkBoxPassword.Location = new System.Drawing.Point(321, 224);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(49, 16);
            this.checkBoxPassword.TabIndex = 84;
            this.checkBoxPassword.Text = "Valid";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.Visible = false;
            // 
            // tbxRePassword
            // 
            this.tbxRePassword.Location = new System.Drawing.Point(108, 222);
            this.tbxRePassword.MaxLength = 16;
            this.tbxRePassword.Name = "tbxRePassword";
            this.tbxRePassword.PasswordChar = '*';
            this.tbxRePassword.Size = new System.Drawing.Size(200, 22);
            this.tbxRePassword.TabIndex = 64;
            this.tbxRePassword.TextChanged += new System.EventHandler(this.CheckPassword);
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(27, 225);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(70, 12);
            this.lblRePassword.TabIndex = 83;
            this.lblRePassword.Text = "Re-Enter Pw: ";
            // 
            // llblCheckAccountValid
            // 
            this.llblCheckAccountValid.AutoSize = true;
            this.llblCheckAccountValid.Location = new System.Drawing.Point(315, 154);
            this.llblCheckAccountValid.Name = "llblCheckAccountValid";
            this.llblCheckAccountValid.Size = new System.Drawing.Size(84, 12);
            this.llblCheckAccountValid.TabIndex = 74;
            this.llblCheckAccountValid.TabStop = true;
            this.llblCheckAccountValid.Text = "Check validation";
            this.llblCheckAccountValid.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCheckAccountValid_LinkClicked);
            // 
            // llblOldUser
            // 
            this.llblOldUser.AutoSize = true;
            this.llblOldUser.Location = new System.Drawing.Point(296, 58);
            this.llblOldUser.Name = "llblOldUser";
            this.llblOldUser.Size = new System.Drawing.Size(103, 12);
            this.llblOldUser.TabIndex = 73;
            this.llblOldUser.TabStop = true;
            this.llblOldUser.Text = "Already a Customer?";
            this.llblOldUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblOldUser_LinkClicked);
            // 
            // checkBoxEmailNotice
            // 
            this.checkBoxEmailNotice.AutoSize = true;
            this.checkBoxEmailNotice.Location = new System.Drawing.Point(29, 547);
            this.checkBoxEmailNotice.Name = "checkBoxEmailNotice";
            this.checkBoxEmailNotice.Size = new System.Drawing.Size(328, 16);
            this.checkBoxEmailNotice.TabIndex = 72;
            this.checkBoxEmailNotice.Text = "I want to receive the company email, advertise and policy update.";
            this.checkBoxEmailNotice.UseVisualStyleBackColor = true;
            // 
            // checkBoxPolicy
            // 
            this.checkBoxPolicy.AutoSize = true;
            this.checkBoxPolicy.Location = new System.Drawing.Point(29, 515);
            this.checkBoxPolicy.Name = "checkBoxPolicy";
            this.checkBoxPolicy.Size = new System.Drawing.Size(166, 16);
            this.checkBoxPolicy.TabIndex = 71;
            this.checkBoxPolicy.Text = "I confirm the company policy.";
            this.checkBoxPolicy.UseVisualStyleBackColor = true;
            this.checkBoxPolicy.CheckedChanged += new System.EventHandler(this.checkBoxPolicy_CheckedChanged);
            // 
            // rbBussinessP
            // 
            this.rbBussinessP.AutoSize = true;
            this.rbBussinessP.Location = new System.Drawing.Point(234, 305);
            this.rbBussinessP.Name = "rbBussinessP";
            this.rbBussinessP.Size = new System.Drawing.Size(62, 16);
            this.rbBussinessP.TabIndex = 67;
            this.rbBussinessP.TabStop = true;
            this.rbBussinessP.Text = "Personal";
            this.rbBussinessP.UseVisualStyleBackColor = true;
            // 
            // lblBussiness
            // 
            this.lblBussiness.AutoSize = true;
            this.lblBussiness.Location = new System.Drawing.Point(27, 306);
            this.lblBussiness.Name = "lblBussiness";
            this.lblBussiness.Size = new System.Drawing.Size(79, 12);
            this.lblBussiness.TabIndex = 82;
            this.lblBussiness.Text = "Bussiness Type:";
            // 
            // rbBussinessC
            // 
            this.rbBussinessC.AutoSize = true;
            this.rbBussinessC.Location = new System.Drawing.Point(128, 305);
            this.rbBussinessC.Name = "rbBussinessC";
            this.rbBussinessC.Size = new System.Drawing.Size(69, 16);
            this.rbBussinessC.TabIndex = 66;
            this.rbBussinessC.TabStop = true;
            this.rbBussinessC.Text = "Company";
            this.rbBussinessC.UseVisualStyleBackColor = true;
            // 
            // tbxPhonePrefix
            // 
            this.tbxPhonePrefix.Location = new System.Drawing.Point(128, 84);
            this.tbxPhonePrefix.Name = "tbxPhonePrefix";
            this.tbxPhonePrefix.Size = new System.Drawing.Size(51, 22);
            this.tbxPhonePrefix.TabIndex = 60;
            // 
            // tbxFax
            // 
            this.tbxFax.Location = new System.Drawing.Point(108, 341);
            this.tbxFax.Name = "tbxFax";
            this.tbxFax.Size = new System.Drawing.Size(262, 22);
            this.tbxFax.TabIndex = 68;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(27, 343);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(66, 12);
            this.lblFax.TabIndex = 81;
            this.lblFax.Text = "Fax Number:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(108, 381);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(262, 70);
            this.tbxAddress.TabIndex = 69;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(198, 84);
            this.tbxPhone.MaxLength = 15;
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(172, 22);
            this.tbxPhone.TabIndex = 61;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(108, 264);
            this.tbxEmail.MaxLength = 50;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(262, 22);
            this.tbxEmail.TabIndex = 65;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(108, 184);
            this.tbxPassword.MaxLength = 16;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(200, 22);
            this.tbxPassword.TabIndex = 63;
            this.tbxPassword.TextChanged += new System.EventHandler(this.CheckPassword);
            // 
            // tbxAccount
            // 
            this.tbxAccount.Location = new System.Drawing.Point(108, 144);
            this.tbxAccount.MaxLength = 16;
            this.tbxAccount.Name = "tbxAccount";
            this.tbxAccount.Size = new System.Drawing.Size(200, 22);
            this.tbxAccount.TabIndex = 62;
            this.tbxAccount.TextChanged += new System.EventHandler(this.tbxAccount_TextChanged);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(108, 48);
            this.tbxName.MaxLength = 50;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(182, 22);
            this.tbxName.TabIndex = 59;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(27, 384);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 12);
            this.lblAddress.TabIndex = 80;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(27, 88);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(166, 12);
            this.lblPhone.TabIndex = 79;
            this.lblPhone.Text = "Phone Number:     +                     -";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 268);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 12);
            this.lblEmail.TabIndex = 78;
            this.lblEmail.Text = "Email Address:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 186);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(54, 12);
            this.lblPassword.TabIndex = 77;
            this.lblPassword.Text = "Password: ";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(26, 148);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(80, 12);
            this.lblAccount.TabIndex = 76;
            this.lblAccount.Text = "Account Name: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 12);
            this.lblName.TabIndex = 75;
            this.lblName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 86;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 87;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(18, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 88;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(18, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 89;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(18, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 90;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(18, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 91;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(18, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 92;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(18, 515);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 93;
            this.label8.Text = "*";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 630);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}