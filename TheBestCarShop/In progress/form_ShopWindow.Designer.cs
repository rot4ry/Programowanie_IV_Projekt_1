namespace TheBestCarShop
{
    partial class form_ShopWindow
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
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.topBarsPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shoppingKartButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.brandCBox = new System.Windows.Forms.ComboBox();
            this.modelCBox = new System.Windows.Forms.ComboBox();
            this.firstYearCBox = new System.Windows.Forms.ComboBox();
            this.lastYearCBox = new System.Windows.Forms.ComboBox();
            this.categoryCBox = new System.Windows.Forms.ComboBox();
            this.manufacturerCBox = new System.Windows.Forms.ComboBox();
            this.priceFromCBox = new System.Windows.Forms.ComboBox();
            this.priceToCBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.topBarsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Snow;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.closeButton.Location = new System.Drawing.Point(812, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(108, 44);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleLabel.Location = new System.Drawing.Point(-6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(940, 64);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "              Shop";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPicBox.BackgroundImage = global::TheBestCarShop.Properties.Resources.logo_small_color;
            this.logoPicBox.Location = new System.Drawing.Point(7, 8);
            this.logoPicBox.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(68, 51);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPicBox.TabIndex = 3;
            this.logoPicBox.TabStop = false;
            // 
            // topBarsPanel
            // 
            this.topBarsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarsPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.topBarsPanel.Controls.Add(this.priceToCBox);
            this.topBarsPanel.Controls.Add(this.priceFromCBox);
            this.topBarsPanel.Controls.Add(this.manufacturerCBox);
            this.topBarsPanel.Controls.Add(this.categoryCBox);
            this.topBarsPanel.Controls.Add(this.lastYearCBox);
            this.topBarsPanel.Controls.Add(this.firstYearCBox);
            this.topBarsPanel.Controls.Add(this.modelCBox);
            this.topBarsPanel.Controls.Add(this.brandCBox);
            this.topBarsPanel.Controls.Add(this.label8);
            this.topBarsPanel.Controls.Add(this.label7);
            this.topBarsPanel.Controls.Add(this.label6);
            this.topBarsPanel.Controls.Add(this.label5);
            this.topBarsPanel.Controls.Add(this.label3);
            this.topBarsPanel.Controls.Add(this.label2);
            this.topBarsPanel.Controls.Add(this.label1);
            this.topBarsPanel.Controls.Add(this.shoppingKartButton);
            this.topBarsPanel.Controls.Add(this.label4);
            this.topBarsPanel.Controls.Add(this.logoPicBox);
            this.topBarsPanel.Controls.Add(this.closeButton);
            this.topBarsPanel.Controls.Add(this.titleLabel);
            this.topBarsPanel.Location = new System.Drawing.Point(-6, -4);
            this.topBarsPanel.Name = "topBarsPanel";
            this.topBarsPanel.Size = new System.Drawing.Size(934, 203);
            this.topBarsPanel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(687, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Price up to";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(479, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price from";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(254, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Part manufacturer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Location = new System.Drawing.Point(18, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Part category";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(479, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "First year of production";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(254, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Car model";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(18, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Car brand";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shoppingKartButton
            // 
            this.shoppingKartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shoppingKartButton.BackColor = System.Drawing.Color.Snow;
            this.shoppingKartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shoppingKartButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shoppingKartButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.shoppingKartButton.Location = new System.Drawing.Point(671, 8);
            this.shoppingKartButton.Name = "shoppingKartButton";
            this.shoppingKartButton.Size = new System.Drawing.Size(135, 44);
            this.shoppingKartButton.TabIndex = 6;
            this.shoppingKartButton.Text = "Shopping kart";
            this.shoppingKartButton.UseVisualStyleBackColor = false;
            this.shoppingKartButton.Click += new System.EventHandler(this.shoppingKartButton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(687, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last year of production";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brandCBox
            // 
            this.brandCBox.FormattingEnabled = true;
            this.brandCBox.Location = new System.Drawing.Point(18, 99);
            this.brandCBox.Name = "brandCBox";
            this.brandCBox.Size = new System.Drawing.Size(183, 21);
            this.brandCBox.TabIndex = 9;
            // 
            // modelCBox
            // 
            this.modelCBox.FormattingEnabled = true;
            this.modelCBox.Location = new System.Drawing.Point(254, 99);
            this.modelCBox.Name = "modelCBox";
            this.modelCBox.Size = new System.Drawing.Size(183, 21);
            this.modelCBox.TabIndex = 16;
            // 
            // firstYearCBox
            // 
            this.firstYearCBox.FormattingEnabled = true;
            this.firstYearCBox.Location = new System.Drawing.Point(479, 99);
            this.firstYearCBox.Name = "firstYearCBox";
            this.firstYearCBox.Size = new System.Drawing.Size(183, 21);
            this.firstYearCBox.TabIndex = 17;
            // 
            // lastYearCBox
            // 
            this.lastYearCBox.FormattingEnabled = true;
            this.lastYearCBox.Location = new System.Drawing.Point(687, 99);
            this.lastYearCBox.Name = "lastYearCBox";
            this.lastYearCBox.Size = new System.Drawing.Size(183, 21);
            this.lastYearCBox.TabIndex = 18;
            // 
            // categoryCBox
            // 
            this.categoryCBox.FormattingEnabled = true;
            this.categoryCBox.Location = new System.Drawing.Point(18, 160);
            this.categoryCBox.Name = "categoryCBox";
            this.categoryCBox.Size = new System.Drawing.Size(183, 21);
            this.categoryCBox.TabIndex = 19;
            // 
            // manufacturerCBox
            // 
            this.manufacturerCBox.FormattingEnabled = true;
            this.manufacturerCBox.Location = new System.Drawing.Point(254, 160);
            this.manufacturerCBox.Name = "manufacturerCBox";
            this.manufacturerCBox.Size = new System.Drawing.Size(183, 21);
            this.manufacturerCBox.TabIndex = 20;
            // 
            // priceFromCBox
            // 
            this.priceFromCBox.FormattingEnabled = true;
            this.priceFromCBox.Location = new System.Drawing.Point(479, 160);
            this.priceFromCBox.Name = "priceFromCBox";
            this.priceFromCBox.Size = new System.Drawing.Size(183, 21);
            this.priceFromCBox.TabIndex = 21;
            // 
            // priceToCBox
            // 
            this.priceToCBox.FormattingEnabled = true;
            this.priceToCBox.Location = new System.Drawing.Point(687, 160);
            this.priceToCBox.Name = "priceToCBox";
            this.priceToCBox.Size = new System.Drawing.Size(183, 21);
            this.priceToCBox.TabIndex = 22;
            // 
            // form_ShopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.topBarsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_ShopWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stern-Geschäft: Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_ShopWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.topBarsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel topBarsPanel;
        private System.Windows.Forms.Button shoppingKartButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox brandCBox;
        private System.Windows.Forms.ComboBox priceToCBox;
        private System.Windows.Forms.ComboBox priceFromCBox;
        private System.Windows.Forms.ComboBox manufacturerCBox;
        private System.Windows.Forms.ComboBox categoryCBox;
        private System.Windows.Forms.ComboBox lastYearCBox;
        private System.Windows.Forms.ComboBox firstYearCBox;
        private System.Windows.Forms.ComboBox modelCBox;
    }
}