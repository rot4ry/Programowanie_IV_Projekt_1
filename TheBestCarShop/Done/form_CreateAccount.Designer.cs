namespace TheBestCarShop
{
    partial class form_CreateAccount
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
            this.createAccountButton = new System.Windows.Forms.Button();
            this.personalBox = new System.Windows.Forms.GroupBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.companyNameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.GroupBox();
            this.postcodeTB = new System.Windows.Forms.TextBox();
            this.buildingTB = new System.Windows.Forms.TextBox();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.clearPasswordButton = new System.Windows.Forms.Button();
            this.dividerLabel_Login = new System.Windows.Forms.Label();
            this.usernameInfoLabel = new System.Windows.Forms.Label();
            this.generateUsernameButton = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB_repeat = new System.Windows.Forms.TextBox();
            this.passwordTB_create = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topLabel2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.personalBox.SuspendLayout();
            this.addressBox.SuspendLayout();
            this.loginBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createAccountButton
            // 
            this.createAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createAccountButton.BackColor = System.Drawing.Color.Snow;
            this.createAccountButton.Enabled = false;
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.createAccountButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createAccountButton.Location = new System.Drawing.Point(259, 645);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(250, 3, 250, 10);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(163, 42);
            this.createAccountButton.TabIndex = 20;
            this.createAccountButton.Text = "Create account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // personalBox
            // 
            this.personalBox.BackColor = System.Drawing.Color.White;
            this.personalBox.Controls.Add(this.phoneTB);
            this.personalBox.Controls.Add(this.mailTB);
            this.personalBox.Controls.Add(this.companyNameTB);
            this.personalBox.Controls.Add(this.surnameTB);
            this.personalBox.Controls.Add(this.nameTB);
            this.personalBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.personalBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.personalBox.Location = new System.Drawing.Point(39, 76);
            this.personalBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.personalBox.Name = "personalBox";
            this.personalBox.Size = new System.Drawing.Size(288, 189);
            this.personalBox.TabIndex = 0;
            this.personalBox.TabStop = false;
            this.personalBox.Text = "Personal Details";
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.phoneTB.ForeColor = System.Drawing.Color.Gray;
            this.phoneTB.Location = new System.Drawing.Point(28, 144);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(232, 27);
            this.phoneTB.TabIndex = 5;
            this.phoneTB.Text = " Phone number ★";
            this.phoneTB.Enter += new System.EventHandler(this.phoneTB_Enter);
            this.phoneTB.Leave += new System.EventHandler(this.phoneTB_Leave);
            // 
            // mailTB
            // 
            this.mailTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.mailTB.ForeColor = System.Drawing.Color.Gray;
            this.mailTB.Location = new System.Drawing.Point(28, 115);
            this.mailTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(232, 27);
            this.mailTB.TabIndex = 4;
            this.mailTB.Text = " e-mail address ★";
            this.mailTB.Enter += new System.EventHandler(this.mailTB_Enter);
            this.mailTB.Leave += new System.EventHandler(this.mailTB_Leave);
            // 
            // companyNameTB
            // 
            this.companyNameTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.companyNameTB.ForeColor = System.Drawing.Color.Gray;
            this.companyNameTB.Location = new System.Drawing.Point(28, 86);
            this.companyNameTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.companyNameTB.Name = "companyNameTB";
            this.companyNameTB.Size = new System.Drawing.Size(232, 27);
            this.companyNameTB.TabIndex = 3;
            this.companyNameTB.Text = " Company Name";
            this.companyNameTB.Enter += new System.EventHandler(this.companyNameTB_Enter);
            this.companyNameTB.Leave += new System.EventHandler(this.companyNameTB_Leave);
            // 
            // surnameTB
            // 
            this.surnameTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.surnameTB.ForeColor = System.Drawing.Color.Gray;
            this.surnameTB.Location = new System.Drawing.Point(28, 57);
            this.surnameTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(232, 27);
            this.surnameTB.TabIndex = 2;
            this.surnameTB.Text = " Second name ★";
            this.surnameTB.Enter += new System.EventHandler(this.surnameTB_Enter);
            this.surnameTB.Leave += new System.EventHandler(this.surnameTB_Leave);
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.ForeColor = System.Drawing.Color.Gray;
            this.nameTB.Location = new System.Drawing.Point(28, 27);
            this.nameTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(232, 27);
            this.nameTB.TabIndex = 1;
            this.nameTB.Text = " First name ★";
            this.nameTB.Enter += new System.EventHandler(this.nameTB_Enter);
            this.nameTB.Leave += new System.EventHandler(this.nameTB_Leave);
            // 
            // addressBox
            // 
            this.addressBox.Controls.Add(this.postcodeTB);
            this.addressBox.Controls.Add(this.buildingTB);
            this.addressBox.Controls.Add(this.streetTB);
            this.addressBox.Controls.Add(this.cityTB);
            this.addressBox.Controls.Add(this.countryTB);
            this.addressBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addressBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addressBox.Location = new System.Drawing.Point(354, 76);
            this.addressBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(288, 189);
            this.addressBox.TabIndex = 6;
            this.addressBox.TabStop = false;
            this.addressBox.Text = "Address Details";
            // 
            // postcodeTB
            // 
            this.postcodeTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.postcodeTB.ForeColor = System.Drawing.Color.Gray;
            this.postcodeTB.Location = new System.Drawing.Point(28, 115);
            this.postcodeTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.postcodeTB.Name = "postcodeTB";
            this.postcodeTB.Size = new System.Drawing.Size(232, 27);
            this.postcodeTB.TabIndex = 10;
            this.postcodeTB.Text = " Postcode ★";
            this.postcodeTB.Enter += new System.EventHandler(this.postcodeTB_Enter);
            this.postcodeTB.Leave += new System.EventHandler(this.postcodeTB_Leave);
            // 
            // buildingTB
            // 
            this.buildingTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buildingTB.ForeColor = System.Drawing.Color.Gray;
            this.buildingTB.Location = new System.Drawing.Point(28, 144);
            this.buildingTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.buildingTB.Name = "buildingTB";
            this.buildingTB.Size = new System.Drawing.Size(232, 27);
            this.buildingTB.TabIndex = 11;
            this.buildingTB.Text = " Building number ★";
            this.buildingTB.Enter += new System.EventHandler(this.buildingTB_Enter);
            this.buildingTB.Leave += new System.EventHandler(this.buildingTB_Leave);
            // 
            // streetTB
            // 
            this.streetTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.streetTB.ForeColor = System.Drawing.Color.Gray;
            this.streetTB.Location = new System.Drawing.Point(28, 86);
            this.streetTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(232, 27);
            this.streetTB.TabIndex = 9;
            this.streetTB.Text = " Street ★";
            this.streetTB.Enter += new System.EventHandler(this.streetTB_Enter);
            this.streetTB.Leave += new System.EventHandler(this.streetTB_Leave);
            // 
            // cityTB
            // 
            this.cityTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.cityTB.ForeColor = System.Drawing.Color.Gray;
            this.cityTB.Location = new System.Drawing.Point(28, 57);
            this.cityTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(232, 27);
            this.cityTB.TabIndex = 8;
            this.cityTB.Text = " City ★";
            this.cityTB.Enter += new System.EventHandler(this.cityTB_Enter);
            this.cityTB.Leave += new System.EventHandler(this.cityTB_Leave);
            // 
            // countryTB
            // 
            this.countryTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.countryTB.ForeColor = System.Drawing.Color.Gray;
            this.countryTB.Location = new System.Drawing.Point(28, 27);
            this.countryTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(232, 27);
            this.countryTB.TabIndex = 7;
            this.countryTB.Text = " Country ★";
            this.countryTB.Enter += new System.EventHandler(this.countryTB_Enter);
            this.countryTB.Leave += new System.EventHandler(this.countryTB_Leave);
            // 
            // loginBox
            // 
            this.loginBox.Controls.Add(this.clearPasswordButton);
            this.loginBox.Controls.Add(this.dividerLabel_Login);
            this.loginBox.Controls.Add(this.usernameInfoLabel);
            this.loginBox.Controls.Add(this.generateUsernameButton);
            this.loginBox.Controls.Add(this.loginTB);
            this.loginBox.Controls.Add(this.passwordTB_repeat);
            this.loginBox.Controls.Add(this.passwordTB_create);
            this.loginBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.loginBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginBox.Location = new System.Drawing.Point(39, 277);
            this.loginBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(603, 204);
            this.loginBox.TabIndex = 12;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Login Details";
            // 
            // clearPasswordButton
            // 
            this.clearPasswordButton.BackColor = System.Drawing.Color.Snow;
            this.clearPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearPasswordButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.clearPasswordButton.Location = new System.Drawing.Point(315, 132);
            this.clearPasswordButton.Name = "clearPasswordButton";
            this.clearPasswordButton.Size = new System.Drawing.Size(256, 44);
            this.clearPasswordButton.TabIndex = 3;
            this.clearPasswordButton.TabStop = false;
            this.clearPasswordButton.Text = "Clear password";
            this.clearPasswordButton.UseVisualStyleBackColor = false;
            this.clearPasswordButton.Click += new System.EventHandler(this.clearPasswordButton_Click);
            // 
            // dividerLabel_Login
            // 
            this.dividerLabel_Login.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dividerLabel_Login.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dividerLabel_Login.Location = new System.Drawing.Point(6, 103);
            this.dividerLabel_Login.Name = "dividerLabel_Login";
            this.dividerLabel_Login.Size = new System.Drawing.Size(591, 20);
            this.dividerLabel_Login.TabIndex = 5;
            this.dividerLabel_Login.Text = "————————————————————————————————————————";
            this.dividerLabel_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameInfoLabel
            // 
            this.usernameInfoLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.usernameInfoLabel.ForeColor = System.Drawing.Color.Gray;
            this.usernameInfoLabel.Location = new System.Drawing.Point(310, 23);
            this.usernameInfoLabel.Name = "usernameInfoLabel";
            this.usernameInfoLabel.Size = new System.Drawing.Size(272, 77);
            this.usernameInfoLabel.TabIndex = 4;
            this.usernameInfoLabel.Text = "Your username is generated using your First and Last Names and random numbers. Yo" +
    "u can change it to some extent to match your liking - try it!";
            this.usernameInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateUsernameButton
            // 
            this.generateUsernameButton.BackColor = System.Drawing.Color.Snow;
            this.generateUsernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateUsernameButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.generateUsernameButton.Location = new System.Drawing.Point(28, 56);
            this.generateUsernameButton.Name = "generateUsernameButton";
            this.generateUsernameButton.Size = new System.Drawing.Size(260, 44);
            this.generateUsernameButton.TabIndex = 13;
            this.generateUsernameButton.Text = "Generate username";
            this.generateUsernameButton.UseVisualStyleBackColor = false;
            this.generateUsernameButton.Click += new System.EventHandler(this.generateUsernameButton_Click);
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.loginTB.ForeColor = System.Drawing.Color.Gray;
            this.loginTB.Location = new System.Drawing.Point(28, 22);
            this.loginTB.Name = "loginTB";
            this.loginTB.ReadOnly = true;
            this.loginTB.Size = new System.Drawing.Size(260, 27);
            this.loginTB.TabIndex = 2;
            this.loginTB.TabStop = false;
            this.loginTB.Text = " Username";
            this.loginTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginTB.Leave += new System.EventHandler(this.loginTB_Leave);
            // 
            // passwordTB_repeat
            // 
            this.passwordTB_repeat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.passwordTB_repeat.ForeColor = System.Drawing.Color.Gray;
            this.passwordTB_repeat.Location = new System.Drawing.Point(28, 156);
            this.passwordTB_repeat.Name = "passwordTB_repeat";
            this.passwordTB_repeat.Size = new System.Drawing.Size(260, 27);
            this.passwordTB_repeat.TabIndex = 15;
            this.passwordTB_repeat.Text = " Repeat password ★";
            this.passwordTB_repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB_repeat.TextChanged += new System.EventHandler(this.passwordTB_repeat_TextChanged);
            this.passwordTB_repeat.Enter += new System.EventHandler(this.passwordTB_repeat_Enter);
            this.passwordTB_repeat.Leave += new System.EventHandler(this.passwordTB_repeat_Leave);
            // 
            // passwordTB_create
            // 
            this.passwordTB_create.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.passwordTB_create.ForeColor = System.Drawing.Color.Gray;
            this.passwordTB_create.Location = new System.Drawing.Point(28, 126);
            this.passwordTB_create.Name = "passwordTB_create";
            this.passwordTB_create.Size = new System.Drawing.Size(260, 27);
            this.passwordTB_create.TabIndex = 14;
            this.passwordTB_create.Text = " Enter password ★";
            this.passwordTB_create.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB_create.TextChanged += new System.EventHandler(this.passwordTB_create_TextChanged);
            this.passwordTB_create.Enter += new System.EventHandler(this.passwordTB_create_Enter);
            this.passwordTB_create.Leave += new System.EventHandler(this.passwordTB_create_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(-7, -12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(696, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new account";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topLabel2
            // 
            this.topLabel2.BackColor = System.Drawing.Color.Transparent;
            this.topLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel2.Location = new System.Drawing.Point(-8, 45);
            this.topLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.topLabel2.Name = "topLabel2";
            this.topLabel2.Size = new System.Drawing.Size(697, 27);
            this.topLabel2.TabIndex = 1;
            this.topLabel2.Text = "Fields marked with a ★ are mandatory.";
            this.topLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(39, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 137);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A few checkboxes";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.checkBox3.ForeColor = System.Drawing.Color.Gray;
            this.checkBox3.Location = new System.Drawing.Point(28, 99);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(369, 23);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "I have read the checkboxes above and accept my fate.";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.checkBox2.ForeColor = System.Drawing.Color.Gray;
            this.checkBox2.Location = new System.Drawing.Point(28, 46);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(367, 51);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "I realise this app has no safety features and any leak of personal data is my own" +
    " problem.";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.checkBox1.ForeColor = System.Drawing.Color.Gray;
            this.checkBox1.Location = new System.Drawing.Point(28, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(406, 23);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "I hereby confirm I\'m old enough to order stuff and pay for it.";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // form_CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 696);
            this.Controls.Add(this.topLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.personalBox);
            this.Controls.Add(this.createAccountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stern-Geschäft: New Account";
            this.Load += new System.EventHandler(this.form_CreateAccount_Load);
            this.personalBox.ResumeLayout(false);
            this.personalBox.PerformLayout();
            this.addressBox.ResumeLayout(false);
            this.addressBox.PerformLayout();
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.GroupBox personalBox;
        private System.Windows.Forms.GroupBox addressBox;
        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label topLabel2;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.TextBox companyNameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox postcodeTB;
        private System.Windows.Forms.TextBox buildingTB;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB_repeat;
        private System.Windows.Forms.TextBox passwordTB_create;
        private System.Windows.Forms.Label dividerLabel_Login;
        private System.Windows.Forms.Label usernameInfoLabel;
        private System.Windows.Forms.Button generateUsernameButton;
        private System.Windows.Forms.Button clearPasswordButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}