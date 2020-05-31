namespace TheBestCarShop.In_progress
{
    partial class form_AccountSettings
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
            this.clearPasswordButton = new System.Windows.Forms.Button();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB_repeat = new System.Windows.Forms.TextBox();
            this.passwordTB_create = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.postcodeTB = new System.Windows.Forms.TextBox();
            this.buildingTB = new System.Windows.Forms.TextBox();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.GroupBox();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.companyNameTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.personalBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox.SuspendLayout();
            this.addressBox.SuspendLayout();
            this.personalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearPasswordButton
            // 
            this.clearPasswordButton.BackColor = System.Drawing.Color.Snow;
            this.clearPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearPasswordButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.clearPasswordButton.Location = new System.Drawing.Point(319, 66);
            this.clearPasswordButton.Name = "clearPasswordButton";
            this.clearPasswordButton.Size = new System.Drawing.Size(163, 57);
            this.clearPasswordButton.TabIndex = 3;
            this.clearPasswordButton.TabStop = false;
            this.clearPasswordButton.Text = "Clear password";
            this.clearPasswordButton.UseVisualStyleBackColor = false;
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
            // 
            // passwordTB_repeat
            // 
            this.passwordTB_repeat.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.passwordTB_repeat.ForeColor = System.Drawing.Color.Gray;
            this.passwordTB_repeat.Location = new System.Drawing.Point(28, 96);
            this.passwordTB_repeat.Name = "passwordTB_repeat";
            this.passwordTB_repeat.Size = new System.Drawing.Size(260, 27);
            this.passwordTB_repeat.TabIndex = 15;
            this.passwordTB_repeat.Text = " Repeat password ";
            this.passwordTB_repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTB_create
            // 
            this.passwordTB_create.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.passwordTB_create.ForeColor = System.Drawing.Color.Gray;
            this.passwordTB_create.Location = new System.Drawing.Point(28, 66);
            this.passwordTB_create.Name = "passwordTB_create";
            this.passwordTB_create.Size = new System.Drawing.Size(260, 27);
            this.passwordTB_create.TabIndex = 14;
            this.passwordTB_create.Text = " Enter password ";
            this.passwordTB_create.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginBox
            // 
            this.loginBox.Controls.Add(this.clearPasswordButton);
            this.loginBox.Controls.Add(this.loginTB);
            this.loginBox.Controls.Add(this.passwordTB_repeat);
            this.loginBox.Controls.Add(this.passwordTB_create);
            this.loginBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.loginBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginBox.Location = new System.Drawing.Point(39, 459);
            this.loginBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(495, 138);
            this.loginBox.TabIndex = 25;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Login Details";
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
            this.postcodeTB.Text = " Postcode ";
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
            this.buildingTB.Text = " Building number ";
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
            this.streetTB.Text = " Street ";
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
            this.cityTB.Text = " City ";
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
            this.addressBox.Location = new System.Drawing.Point(39, 264);
            this.addressBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(495, 189);
            this.addressBox.TabIndex = 24;
            this.addressBox.TabStop = false;
            this.addressBox.Text = "Address Details";
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
            this.countryTB.Text = " Country ";
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
            this.phoneTB.Text = " Phone number ";
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
            this.mailTB.Text = " e-mail address ";
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
            this.surnameTB.Text = " Second name ";
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
            this.nameTB.Text = " First name ";
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
            this.personalBox.Location = new System.Drawing.Point(39, 69);
            this.personalBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.personalBox.Name = "personalBox";
            this.personalBox.Size = new System.Drawing.Size(495, 189);
            this.personalBox.TabIndex = 22;
            this.personalBox.TabStop = false;
            this.personalBox.Text = "Personal Details";
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
            this.label1.Location = new System.Drawing.Point(-7, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 57);
            this.label1.TabIndex = 26;
            this.label1.Text = "Update your account details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.personalBox);
            this.Name = "form_AccountSettings";
            this.Text = "form_AccountSettings";
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.addressBox.ResumeLayout(false);
            this.addressBox.PerformLayout();
            this.personalBox.ResumeLayout(false);
            this.personalBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button clearPasswordButton;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB_repeat;
        private System.Windows.Forms.TextBox passwordTB_create;
        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.TextBox postcodeTB;
        private System.Windows.Forms.TextBox buildingTB;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.GroupBox addressBox;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.TextBox companyNameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.GroupBox personalBox;
        private System.Windows.Forms.Label label1;
    }
}