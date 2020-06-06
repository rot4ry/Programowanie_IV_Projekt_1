namespace TheBestCarShop
{
    partial class form_MainUserWindow
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
            this.components = new System.ComponentModel.Container();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.shopGroupBox = new System.Windows.Forms.GroupBox();
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.ordersIconPicBox = new System.Windows.Forms.PictureBox();
            this.myOrdersButton = new System.Windows.Forms.Button();
            this.kartPanel = new System.Windows.Forms.Panel();
            this.kartIconPicBox = new System.Windows.Forms.PictureBox();
            this.shoppingKartButton = new System.Windows.Forms.Button();
            this.shopPanel = new System.Windows.Forms.Panel();
            this.shopIconPicBox = new System.Windows.Forms.PictureBox();
            this.shopButton = new System.Windows.Forms.Button();
            this.accountGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsPicBox = new System.Windows.Forms.PictureBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.loggedTIMER = new System.Windows.Forms.Timer(this.components);
            this.othersGroupBox = new System.Windows.Forms.GroupBox();
            this.randomThingButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.measuredTimeLabel = new System.Windows.Forms.Label();
            this.timerDescLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shopGroupBox.SuspendLayout();
            this.ordersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersIconPicBox)).BeginInit();
            this.kartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kartIconPicBox)).BeginInit();
            this.shopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shopIconPicBox)).BeginInit();
            this.accountGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicBox)).BeginInit();
            this.othersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welcomeLabel.Location = new System.Drawing.Point(-8, -3);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(983, 68);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Snow;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.logoutButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.logoutButton.Location = new System.Drawing.Point(680, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(130, 44);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // shopGroupBox
            // 
            this.shopGroupBox.Controls.Add(this.ordersPanel);
            this.shopGroupBox.Controls.Add(this.kartPanel);
            this.shopGroupBox.Controls.Add(this.shopPanel);
            this.shopGroupBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.shopGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.shopGroupBox.Location = new System.Drawing.Point(24, 75);
            this.shopGroupBox.Margin = new System.Windows.Forms.Padding(15, 10, 15, 3);
            this.shopGroupBox.Name = "shopGroupBox";
            this.shopGroupBox.Size = new System.Drawing.Size(434, 451);
            this.shopGroupBox.TabIndex = 3;
            this.shopGroupBox.TabStop = false;
            this.shopGroupBox.Text = "Shop";
            // 
            // ordersPanel
            // 
            this.ordersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ordersPanel.Controls.Add(this.ordersIconPicBox);
            this.ordersPanel.Controls.Add(this.myOrdersButton);
            this.ordersPanel.Location = new System.Drawing.Point(33, 304);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(368, 135);
            this.ordersPanel.TabIndex = 5;
            // 
            // ordersIconPicBox
            // 
            this.ordersIconPicBox.BackgroundImage = global::TheBestCarShop.Properties.Resources.ordersIcon;
            this.ordersIconPicBox.Location = new System.Drawing.Point(10, 10);
            this.ordersIconPicBox.Name = "ordersIconPicBox";
            this.ordersIconPicBox.Size = new System.Drawing.Size(128, 115);
            this.ordersIconPicBox.TabIndex = 3;
            this.ordersIconPicBox.TabStop = false;
            // 
            // myOrdersButton
            // 
            this.myOrdersButton.BackColor = System.Drawing.Color.Snow;
            this.myOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myOrdersButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.myOrdersButton.Location = new System.Drawing.Point(151, 10);
            this.myOrdersButton.Margin = new System.Windows.Forms.Padding(10);
            this.myOrdersButton.Name = "myOrdersButton";
            this.myOrdersButton.Size = new System.Drawing.Size(207, 115);
            this.myOrdersButton.TabIndex = 2;
            this.myOrdersButton.Text = "My orders";
            this.myOrdersButton.UseVisualStyleBackColor = false;
            this.myOrdersButton.Click += new System.EventHandler(this.myOrdersButton_Click);
            // 
            // kartPanel
            // 
            this.kartPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kartPanel.Controls.Add(this.kartIconPicBox);
            this.kartPanel.Controls.Add(this.shoppingKartButton);
            this.kartPanel.Location = new System.Drawing.Point(33, 163);
            this.kartPanel.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.kartPanel.Name = "kartPanel";
            this.kartPanel.Size = new System.Drawing.Size(368, 135);
            this.kartPanel.TabIndex = 4;
            // 
            // kartIconPicBox
            // 
            this.kartIconPicBox.BackgroundImage = global::TheBestCarShop.Properties.Resources.shoppingKart1;
            this.kartIconPicBox.Location = new System.Drawing.Point(231, 10);
            this.kartIconPicBox.Name = "kartIconPicBox";
            this.kartIconPicBox.Size = new System.Drawing.Size(126, 115);
            this.kartIconPicBox.TabIndex = 2;
            this.kartIconPicBox.TabStop = false;
            // 
            // shoppingKartButton
            // 
            this.shoppingKartButton.BackColor = System.Drawing.Color.Snow;
            this.shoppingKartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.shoppingKartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shoppingKartButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.shoppingKartButton.Location = new System.Drawing.Point(10, 10);
            this.shoppingKartButton.Margin = new System.Windows.Forms.Padding(10);
            this.shoppingKartButton.Name = "shoppingKartButton";
            this.shoppingKartButton.Size = new System.Drawing.Size(208, 115);
            this.shoppingKartButton.TabIndex = 1;
            this.shoppingKartButton.Text = "Shopping kart";
            this.shoppingKartButton.UseVisualStyleBackColor = false;
            this.shoppingKartButton.Click += new System.EventHandler(this.shoppingKartButton_Click);
            // 
            // shopPanel
            // 
            this.shopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shopPanel.Controls.Add(this.shopIconPicBox);
            this.shopPanel.Controls.Add(this.shopButton);
            this.shopPanel.Location = new System.Drawing.Point(33, 22);
            this.shopPanel.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.shopPanel.Name = "shopPanel";
            this.shopPanel.Size = new System.Drawing.Size(368, 135);
            this.shopPanel.TabIndex = 3;
            // 
            // shopIconPicBox
            // 
            this.shopIconPicBox.BackgroundImage = global::TheBestCarShop.Properties.Resources.shopIcon_small;
            this.shopIconPicBox.Location = new System.Drawing.Point(10, 10);
            this.shopIconPicBox.Name = "shopIconPicBox";
            this.shopIconPicBox.Size = new System.Drawing.Size(178, 115);
            this.shopIconPicBox.TabIndex = 1;
            this.shopIconPicBox.TabStop = false;
            // 
            // shopButton
            // 
            this.shopButton.BackColor = System.Drawing.Color.Snow;
            this.shopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.shopButton.Location = new System.Drawing.Point(201, 10);
            this.shopButton.Margin = new System.Windows.Forms.Padding(10);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(157, 115);
            this.shopButton.TabIndex = 0;
            this.shopButton.Text = "Shop";
            this.shopButton.UseVisualStyleBackColor = false;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // accountGroupBox
            // 
            this.accountGroupBox.Controls.Add(this.panel1);
            this.accountGroupBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.accountGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.accountGroupBox.Location = new System.Drawing.Point(488, 75);
            this.accountGroupBox.Margin = new System.Windows.Forms.Padding(15, 10, 15, 3);
            this.accountGroupBox.Name = "accountGroupBox";
            this.accountGroupBox.Size = new System.Drawing.Size(310, 120);
            this.accountGroupBox.TabIndex = 4;
            this.accountGroupBox.TabStop = false;
            this.accountGroupBox.Text = "Your account";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.settingsPicBox);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Location = new System.Drawing.Point(13, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 92);
            this.panel1.TabIndex = 1;
            // 
            // settingsPicBox
            // 
            this.settingsPicBox.BackgroundImage = global::TheBestCarShop.Properties.Resources.settingsIcon;
            this.settingsPicBox.Location = new System.Drawing.Point(201, 10);
            this.settingsPicBox.Name = "settingsPicBox";
            this.settingsPicBox.Size = new System.Drawing.Size(72, 70);
            this.settingsPicBox.TabIndex = 1;
            this.settingsPicBox.TabStop = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Snow;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.settingsButton.Location = new System.Drawing.Point(10, 10);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(10);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(188, 70);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // loggedTIMER
            // 
            this.loggedTIMER.Enabled = true;
            this.loggedTIMER.Interval = 10;
            this.loggedTIMER.Tick += new System.EventHandler(this.loggedTimer_Tick);
            // 
            // othersGroupBox
            // 
            this.othersGroupBox.Controls.Add(this.randomThingButton);
            this.othersGroupBox.Controls.Add(this.dateLabel);
            this.othersGroupBox.Controls.Add(this.dateTimePicker1);
            this.othersGroupBox.Controls.Add(this.measuredTimeLabel);
            this.othersGroupBox.Controls.Add(this.timerDescLabel);
            this.othersGroupBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.othersGroupBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.othersGroupBox.Location = new System.Drawing.Point(488, 202);
            this.othersGroupBox.Margin = new System.Windows.Forms.Padding(15, 10, 15, 3);
            this.othersGroupBox.Name = "othersGroupBox";
            this.othersGroupBox.Size = new System.Drawing.Size(310, 324);
            this.othersGroupBox.TabIndex = 5;
            this.othersGroupBox.TabStop = false;
            this.othersGroupBox.Text = "Fun facts";
            // 
            // randomThingButton
            // 
            this.randomThingButton.BackColor = System.Drawing.Color.Red;
            this.randomThingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.randomThingButton.FlatAppearance.BorderSize = 4;
            this.randomThingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomThingButton.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.randomThingButton.ForeColor = System.Drawing.Color.Snow;
            this.randomThingButton.Location = new System.Drawing.Point(13, 214);
            this.randomThingButton.Name = "randomThingButton";
            this.randomThingButton.Padding = new System.Windows.Forms.Padding(20);
            this.randomThingButton.Size = new System.Drawing.Size(284, 89);
            this.randomThingButton.TabIndex = 7;
            this.randomThingButton.Text = "♫ Loose yourself ♫";
            this.randomThingButton.UseVisualStyleBackColor = false;
            this.randomThingButton.Click += new System.EventHandler(this.randomThingButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dateLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dateLabel.Location = new System.Drawing.Point(23, 138);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(264, 28);
            this.dateLabel.TabIndex = 6;
            this.dateLabel.Text = "Today\'s date:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 169);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(10, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // measuredTimeLabel
            // 
            this.measuredTimeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.measuredTimeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.measuredTimeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.measuredTimeLabel.Location = new System.Drawing.Point(34, 55);
            this.measuredTimeLabel.Name = "measuredTimeLabel";
            this.measuredTimeLabel.Size = new System.Drawing.Size(242, 68);
            this.measuredTimeLabel.TabIndex = 1;
            this.measuredTimeLabel.Text = "time";
            this.measuredTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerDescLabel
            // 
            this.timerDescLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.timerDescLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerDescLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.timerDescLabel.Location = new System.Drawing.Point(23, 24);
            this.timerDescLabel.Margin = new System.Windows.Forms.Padding(20, 5, 20, 0);
            this.timerDescLabel.Name = "timerDescLabel";
            this.timerDescLabel.Size = new System.Drawing.Size(264, 28);
            this.timerDescLabel.TabIndex = 0;
            this.timerDescLabel.Text = "You\'ve been logged in for:";
            this.timerDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TheBestCarShop.Properties.Resources.logo_small_color;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // form_MainUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(822, 538);
            this.ControlBox = false;
            this.Controls.Add(this.othersGroupBox);
            this.Controls.Add(this.accountGroupBox);
            this.Controls.Add(this.shopGroupBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_MainUserWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stern-Geschäft: Welcome!";
            this.Load += new System.EventHandler(this.form_MainUserWindow_Load);
            this.shopGroupBox.ResumeLayout(false);
            this.ordersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersIconPicBox)).EndInit();
            this.kartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kartIconPicBox)).EndInit();
            this.shopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shopIconPicBox)).EndInit();
            this.accountGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settingsPicBox)).EndInit();
            this.othersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.GroupBox shopGroupBox;
        private System.Windows.Forms.GroupBox accountGroupBox;
        private System.Windows.Forms.Timer loggedTIMER;
        private System.Windows.Forms.GroupBox othersGroupBox;
        private System.Windows.Forms.Label measuredTimeLabel;
        private System.Windows.Forms.Label timerDescLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button myOrdersButton;
        private System.Windows.Forms.Button shoppingKartButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Panel kartPanel;
        private System.Windows.Forms.Panel shopPanel;
        private System.Windows.Forms.PictureBox ordersIconPicBox;
        private System.Windows.Forms.PictureBox kartIconPicBox;
        private System.Windows.Forms.PictureBox shopIconPicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox settingsPicBox;
        private System.Windows.Forms.Button randomThingButton;
    }
}