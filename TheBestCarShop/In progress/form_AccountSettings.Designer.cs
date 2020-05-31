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
            this.updatePasswordButton = new System.Windows.Forms.Button();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordRepeatTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.postcodeNumberTB = new System.Windows.Forms.TextBox();
            this.buildingNumberTB = new System.Windows.Forms.TextBox();
            this.streetNameTB = new System.Windows.Forms.TextBox();
            this.cityNameTB = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.GroupBox();
            this.buildingUpdateButton = new System.Windows.Forms.Button();
            this.postcodeUpdateButton = new System.Windows.Forms.Button();
            this.steetUpdateButton = new System.Windows.Forms.Button();
            this.cityUpdateButton = new System.Windows.Forms.Button();
            this.countryUpdateButton = new System.Windows.Forms.Button();
            this.countryNameTB = new System.Windows.Forms.TextBox();
            this.phoneNumberTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.compNameTB = new System.Windows.Forms.TextBox();
            this.secondnameTB = new System.Windows.Forms.TextBox();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.personalBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneUpdateButton = new System.Windows.Forms.Button();
            this.emailUpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox.SuspendLayout();
            this.addressBox.SuspendLayout();
            this.personalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updatePasswordButton
            // 
            this.updatePasswordButton.BackColor = System.Drawing.Color.Snow;
            this.updatePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePasswordButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.updatePasswordButton.Location = new System.Drawing.Point(283, 55);
            this.updatePasswordButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.updatePasswordButton.Name = "updatePasswordButton";
            this.updatePasswordButton.Size = new System.Drawing.Size(132, 57);
            this.updatePasswordButton.TabIndex = 3;
            this.updatePasswordButton.TabStop = false;
            this.updatePasswordButton.Text = "Update";
            this.updatePasswordButton.UseVisualStyleBackColor = false;
            this.updatePasswordButton.Click += new System.EventHandler(this.updatePasswordButton_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.usernameTB.ForeColor = System.Drawing.Color.Gray;
            this.usernameTB.Location = new System.Drawing.Point(28, 22);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.ReadOnly = true;
            this.usernameTB.Size = new System.Drawing.Size(232, 27);
            this.usernameTB.TabIndex = 2;
            this.usernameTB.TabStop = false;
            this.usernameTB.Text = " Username";
            this.usernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordRepeatTB
            // 
            this.passwordRepeatTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.passwordRepeatTB.ForeColor = System.Drawing.Color.Gray;
            this.passwordRepeatTB.Location = new System.Drawing.Point(28, 85);
            this.passwordRepeatTB.Name = "passwordRepeatTB";
            this.passwordRepeatTB.Size = new System.Drawing.Size(232, 27);
            this.passwordRepeatTB.TabIndex = 15;
            this.passwordRepeatTB.Text = " Repeat password ";
            this.passwordRepeatTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordRepeatTB.TextChanged += new System.EventHandler(this.passwordRepeatTB_TextChanged);
            this.passwordRepeatTB.Enter += new System.EventHandler(this.passwordRepeatTB_Enter);
            this.passwordRepeatTB.Leave += new System.EventHandler(this.passwordRepeatTB_Leave);
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.passwordTB.ForeColor = System.Drawing.Color.Gray;
            this.passwordTB.Location = new System.Drawing.Point(28, 55);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(232, 27);
            this.passwordTB.TabIndex = 14;
            this.passwordTB.Text = " Enter password ";
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB.TextChanged += new System.EventHandler(this.passwordTB_TextChanged);
            this.passwordTB.Enter += new System.EventHandler(this.passwordTB_Enter);
            this.passwordTB.Leave += new System.EventHandler(this.passwordTB_Leave);
            // 
            // loginBox
            // 
            this.loginBox.Controls.Add(this.label5);
            this.loginBox.Controls.Add(this.updatePasswordButton);
            this.loginBox.Controls.Add(this.usernameTB);
            this.loginBox.Controls.Add(this.passwordRepeatTB);
            this.loginBox.Controls.Add(this.passwordTB);
            this.loginBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.loginBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginBox.Location = new System.Drawing.Point(39, 459);
            this.loginBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(438, 126);
            this.loginBox.TabIndex = 25;
            this.loginBox.TabStop = false;
            this.loginBox.Text = "Change password";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(280, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Not changable";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postcodeNumberTB
            // 
            this.postcodeNumberTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.postcodeNumberTB.ForeColor = System.Drawing.Color.Gray;
            this.postcodeNumberTB.Location = new System.Drawing.Point(28, 115);
            this.postcodeNumberTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.postcodeNumberTB.Name = "postcodeNumberTB";
            this.postcodeNumberTB.Size = new System.Drawing.Size(232, 27);
            this.postcodeNumberTB.TabIndex = 10;
            this.postcodeNumberTB.Text = " Postcode ";
            this.postcodeNumberTB.Enter += new System.EventHandler(this.postcodeNumberTB_Enter);
            this.postcodeNumberTB.Leave += new System.EventHandler(this.postcodeNumberTB_Leave);
            // 
            // buildingNumberTB
            // 
            this.buildingNumberTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.buildingNumberTB.ForeColor = System.Drawing.Color.Gray;
            this.buildingNumberTB.Location = new System.Drawing.Point(28, 144);
            this.buildingNumberTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.buildingNumberTB.Name = "buildingNumberTB";
            this.buildingNumberTB.Size = new System.Drawing.Size(232, 27);
            this.buildingNumberTB.TabIndex = 11;
            this.buildingNumberTB.Text = " Building number ";
            this.buildingNumberTB.Enter += new System.EventHandler(this.buildingNumberTB_Enter);
            this.buildingNumberTB.Leave += new System.EventHandler(this.buildingNumberTB_Leave);
            // 
            // streetNameTB
            // 
            this.streetNameTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.streetNameTB.ForeColor = System.Drawing.Color.Gray;
            this.streetNameTB.Location = new System.Drawing.Point(28, 86);
            this.streetNameTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.streetNameTB.Name = "streetNameTB";
            this.streetNameTB.Size = new System.Drawing.Size(232, 27);
            this.streetNameTB.TabIndex = 9;
            this.streetNameTB.Text = " Street ";
            this.streetNameTB.Enter += new System.EventHandler(this.streetNameTB_Enter);
            this.streetNameTB.Leave += new System.EventHandler(this.streetNameTB_Leave);
            // 
            // cityNameTB
            // 
            this.cityNameTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.cityNameTB.ForeColor = System.Drawing.Color.Gray;
            this.cityNameTB.Location = new System.Drawing.Point(28, 57);
            this.cityNameTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.cityNameTB.Name = "cityNameTB";
            this.cityNameTB.Size = new System.Drawing.Size(232, 27);
            this.cityNameTB.TabIndex = 8;
            this.cityNameTB.Text = " City ";
            this.cityNameTB.Enter += new System.EventHandler(this.cityNameTB_Enter);
            this.cityNameTB.Leave += new System.EventHandler(this.cityNameTB_Leave);
            // 
            // addressBox
            // 
            this.addressBox.Controls.Add(this.buildingUpdateButton);
            this.addressBox.Controls.Add(this.postcodeUpdateButton);
            this.addressBox.Controls.Add(this.steetUpdateButton);
            this.addressBox.Controls.Add(this.postcodeNumberTB);
            this.addressBox.Controls.Add(this.cityUpdateButton);
            this.addressBox.Controls.Add(this.buildingNumberTB);
            this.addressBox.Controls.Add(this.countryUpdateButton);
            this.addressBox.Controls.Add(this.streetNameTB);
            this.addressBox.Controls.Add(this.cityNameTB);
            this.addressBox.Controls.Add(this.countryNameTB);
            this.addressBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.addressBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addressBox.Location = new System.Drawing.Point(39, 264);
            this.addressBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(438, 189);
            this.addressBox.TabIndex = 24;
            this.addressBox.TabStop = false;
            this.addressBox.Text = "Address Details";
            // 
            // buildingUpdateButton
            // 
            this.buildingUpdateButton.BackColor = System.Drawing.Color.Snow;
            this.buildingUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buildingUpdateButton.Location = new System.Drawing.Point(283, 144);
            this.buildingUpdateButton.Name = "buildingUpdateButton";
            this.buildingUpdateButton.Size = new System.Drawing.Size(132, 27);
            this.buildingUpdateButton.TabIndex = 13;
            this.buildingUpdateButton.Text = "Update";
            this.buildingUpdateButton.UseVisualStyleBackColor = false;
            this.buildingUpdateButton.Click += new System.EventHandler(this.buildingUpdateButton_Click);
            // 
            // postcodeUpdateButton
            // 
            this.postcodeUpdateButton.BackColor = System.Drawing.Color.Snow;
            this.postcodeUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postcodeUpdateButton.Location = new System.Drawing.Point(283, 115);
            this.postcodeUpdateButton.Name = "postcodeUpdateButton";
            this.postcodeUpdateButton.Size = new System.Drawing.Size(132, 27);
            this.postcodeUpdateButton.TabIndex = 12;
            this.postcodeUpdateButton.Text = "Update";
            this.postcodeUpdateButton.UseVisualStyleBackColor = false;
            this.postcodeUpdateButton.Click += new System.EventHandler(this.postcodeUpdateButton_Click);
            // 
            // steetUpdateButton
            // 
            this.steetUpdateButton.BackColor = System.Drawing.Color.Snow;
            this.steetUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.steetUpdateButton.Location = new System.Drawing.Point(283, 85);
            this.steetUpdateButton.Name = "steetUpdateButton";
            this.steetUpdateButton.Size = new System.Drawing.Size(132, 27);
            this.steetUpdateButton.TabIndex = 10;
            this.steetUpdateButton.Text = "Update";
            this.steetUpdateButton.UseVisualStyleBackColor = false;
            this.steetUpdateButton.Click += new System.EventHandler(this.steetUpdateButton_Click);
            // 
            // cityUpdateButton
            // 
            this.cityUpdateButton.BackColor = System.Drawing.Color.Snow;
            this.cityUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cityUpdateButton.Location = new System.Drawing.Point(283, 56);
            this.cityUpdateButton.Name = "cityUpdateButton";
            this.cityUpdateButton.Size = new System.Drawing.Size(132, 27);
            this.cityUpdateButton.TabIndex = 9;
            this.cityUpdateButton.Text = "Update";
            this.cityUpdateButton.UseVisualStyleBackColor = false;
            this.cityUpdateButton.Click += new System.EventHandler(this.cityUpdateButton_Click);
            // 
            // countryUpdateButton
            // 
            this.countryUpdateButton.BackColor = System.Drawing.Color.Snow;
            this.countryUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countryUpdateButton.Location = new System.Drawing.Point(283, 27);
            this.countryUpdateButton.Name = "countryUpdateButton";
            this.countryUpdateButton.Size = new System.Drawing.Size(132, 27);
            this.countryUpdateButton.TabIndex = 8;
            this.countryUpdateButton.Text = "Update";
            this.countryUpdateButton.UseVisualStyleBackColor = false;
            this.countryUpdateButton.Click += new System.EventHandler(this.countryUpdateButton_Click);
            // 
            // countryNameTB
            // 
            this.countryNameTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.countryNameTB.ForeColor = System.Drawing.Color.Gray;
            this.countryNameTB.Location = new System.Drawing.Point(28, 27);
            this.countryNameTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.countryNameTB.Name = "countryNameTB";
            this.countryNameTB.Size = new System.Drawing.Size(232, 27);
            this.countryNameTB.TabIndex = 7;
            this.countryNameTB.Text = " Country ";
            this.countryNameTB.Enter += new System.EventHandler(this.countryNameTB_Enter);
            this.countryNameTB.Leave += new System.EventHandler(this.countryNameTB_Leave);
            // 
            // phoneNumberTB
            // 
            this.phoneNumberTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.phoneNumberTB.ForeColor = System.Drawing.Color.Gray;
            this.phoneNumberTB.Location = new System.Drawing.Point(28, 144);
            this.phoneNumberTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.phoneNumberTB.Name = "phoneNumberTB";
            this.phoneNumberTB.Size = new System.Drawing.Size(232, 27);
            this.phoneNumberTB.TabIndex = 5;
            this.phoneNumberTB.Text = " Phone number ";
            this.phoneNumberTB.Enter += new System.EventHandler(this.phoneNumberTB_Enter);
            this.phoneNumberTB.Leave += new System.EventHandler(this.phoneNumberTB_Leave);
            // 
            // emailTB
            // 
            this.emailTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.emailTB.ForeColor = System.Drawing.Color.Gray;
            this.emailTB.Location = new System.Drawing.Point(28, 115);
            this.emailTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(232, 27);
            this.emailTB.TabIndex = 4;
            this.emailTB.Text = " e-mail address ";
            this.emailTB.Enter += new System.EventHandler(this.emailTB_Enter);
            this.emailTB.Leave += new System.EventHandler(this.emailTB_Leave);
            // 
            // compNameTB
            // 
            this.compNameTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.compNameTB.ForeColor = System.Drawing.Color.Gray;
            this.compNameTB.Location = new System.Drawing.Point(28, 86);
            this.compNameTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.compNameTB.Name = "compNameTB";
            this.compNameTB.ReadOnly = true;
            this.compNameTB.Size = new System.Drawing.Size(232, 27);
            this.compNameTB.TabIndex = 3;
            this.compNameTB.Text = " Company Name";
            // 
            // secondnameTB
            // 
            this.secondnameTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.secondnameTB.ForeColor = System.Drawing.Color.Gray;
            this.secondnameTB.Location = new System.Drawing.Point(28, 57);
            this.secondnameTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.secondnameTB.Name = "secondnameTB";
            this.secondnameTB.ReadOnly = true;
            this.secondnameTB.Size = new System.Drawing.Size(232, 27);
            this.secondnameTB.TabIndex = 2;
            this.secondnameTB.Text = " Second name ";
            // 
            // firstnameTB
            // 
            this.firstnameTB.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTB.ForeColor = System.Drawing.Color.Gray;
            this.firstnameTB.Location = new System.Drawing.Point(28, 27);
            this.firstnameTB.Margin = new System.Windows.Forms.Padding(25, 3, 25, 15);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.ReadOnly = true;
            this.firstnameTB.Size = new System.Drawing.Size(232, 27);
            this.firstnameTB.TabIndex = 1;
            this.firstnameTB.Text = " First name ";
            // 
            // personalBox
            // 
            this.personalBox.BackColor = System.Drawing.Color.White;
            this.personalBox.Controls.Add(this.label4);
            this.personalBox.Controls.Add(this.label3);
            this.personalBox.Controls.Add(this.label2);
            this.personalBox.Controls.Add(this.phoneUpdateButton);
            this.personalBox.Controls.Add(this.emailUpdateButton);
            this.personalBox.Controls.Add(this.phoneNumberTB);
            this.personalBox.Controls.Add(this.emailTB);
            this.personalBox.Controls.Add(this.compNameTB);
            this.personalBox.Controls.Add(this.secondnameTB);
            this.personalBox.Controls.Add(this.firstnameTB);
            this.personalBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.personalBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.personalBox.Location = new System.Drawing.Point(39, 69);
            this.personalBox.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.personalBox.Name = "personalBox";
            this.personalBox.Size = new System.Drawing.Size(438, 189);
            this.personalBox.TabIndex = 22;
            this.personalBox.TabStop = false;
            this.personalBox.Text = "Personal Details";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(280, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Not changable";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(280, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Not changable";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(280, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Not changable";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneUpdateButton
            // 
            this.phoneUpdateButton.BackColor = System.Drawing.Color.Snow;
            this.phoneUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneUpdateButton.Location = new System.Drawing.Point(283, 144);
            this.phoneUpdateButton.Name = "phoneUpdateButton";
            this.phoneUpdateButton.Size = new System.Drawing.Size(132, 27);
            this.phoneUpdateButton.TabIndex = 7;
            this.phoneUpdateButton.Text = "Update";
            this.phoneUpdateButton.UseVisualStyleBackColor = false;
            this.phoneUpdateButton.Click += new System.EventHandler(this.phoneUpdateButton_Click);
            // 
            // emailUpdateButton
            // 
            this.emailUpdateButton.BackColor = System.Drawing.Color.Snow;
            this.emailUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailUpdateButton.Location = new System.Drawing.Point(283, 115);
            this.emailUpdateButton.Name = "emailUpdateButton";
            this.emailUpdateButton.Size = new System.Drawing.Size(132, 27);
            this.emailUpdateButton.TabIndex = 6;
            this.emailUpdateButton.Text = "Update";
            this.emailUpdateButton.UseVisualStyleBackColor = false;
            this.emailUpdateButton.Click += new System.EventHandler(this.emailUpdateButton_Click);
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
            this.label1.Location = new System.Drawing.Point(-8, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 57);
            this.label1.TabIndex = 26;
            this.label1.Text = "Update your account details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_AccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.personalBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "form_AccountSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stern-Geschäft: Settings";
            this.Load += new System.EventHandler(this.form_AccountSettings_Load);
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            this.addressBox.ResumeLayout(false);
            this.addressBox.PerformLayout();
            this.personalBox.ResumeLayout(false);
            this.personalBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button updatePasswordButton;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordRepeatTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.TextBox postcodeNumberTB;
        private System.Windows.Forms.TextBox buildingNumberTB;
        private System.Windows.Forms.TextBox streetNameTB;
        private System.Windows.Forms.TextBox cityNameTB;
        private System.Windows.Forms.GroupBox addressBox;
        private System.Windows.Forms.TextBox countryNameTB;
        private System.Windows.Forms.TextBox phoneNumberTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox compNameTB;
        private System.Windows.Forms.TextBox secondnameTB;
        private System.Windows.Forms.TextBox firstnameTB;
        private System.Windows.Forms.GroupBox personalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buildingUpdateButton;
        private System.Windows.Forms.Button postcodeUpdateButton;
        private System.Windows.Forms.Button steetUpdateButton;
        private System.Windows.Forms.Button cityUpdateButton;
        private System.Windows.Forms.Button countryUpdateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button phoneUpdateButton;
        private System.Windows.Forms.Button emailUpdateButton;
    }
}