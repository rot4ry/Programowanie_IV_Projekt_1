namespace TheBestCarShop
{
    partial class form_ShoppingKart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeButton = new System.Windows.Forms.Button();
            this.kartLabel = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.valueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearKartButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.shoppingKartView = new System.Windows.Forms.DataGridView();
            this.stylingButtonSK = new System.Windows.Forms.Button();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsEmpty = new System.Windows.Forms.DataGridViewButtonColumn();
            this.removeEmpty = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingKartView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Snow;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.closeButton.Location = new System.Drawing.Point(958, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(123, 44);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // kartLabel
            // 
            this.kartLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.kartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.kartLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.kartLabel.Location = new System.Drawing.Point(-7, -1);
            this.kartLabel.Name = "kartLabel";
            this.kartLabel.Size = new System.Drawing.Size(1102, 63);
            this.kartLabel.TabIndex = 4;
            this.kartLabel.Text = "            Your shopping kart";
            this.kartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.BackgroundImage = global::TheBestCarShop.Properties.Resources.logo_small_color;
            this.logoBox.Location = new System.Drawing.Point(2, 3);
            this.logoBox.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(72, 56);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 3;
            this.logoBox.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightGray;
            this.panel.Controls.Add(this.valueLabel);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.clearKartButton);
            this.panel.Controls.Add(this.placeOrderButton);
            this.panel.Controls.Add(this.shoppingKartView);
            this.panel.Location = new System.Drawing.Point(-1, 65);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1096, 413);
            this.panel.TabIndex = 10;
            // 
            // valueLabel
            // 
            this.valueLabel.BackColor = System.Drawing.Color.Azure;
            this.valueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valueLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.valueLabel.Location = new System.Drawing.Point(247, 351);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(351, 44);
            this.valueLabel.TabIndex = 14;
            this.valueLabel.Text = "cost";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(26, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order value : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearKartButton
            // 
            this.clearKartButton.BackColor = System.Drawing.Color.Snow;
            this.clearKartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearKartButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.clearKartButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clearKartButton.Location = new System.Drawing.Point(700, 351);
            this.clearKartButton.Name = "clearKartButton";
            this.clearKartButton.Size = new System.Drawing.Size(188, 44);
            this.clearKartButton.TabIndex = 12;
            this.clearKartButton.Text = "Clear kart";
            this.clearKartButton.UseVisualStyleBackColor = false;
            this.clearKartButton.Click += new System.EventHandler(this.clearKartButton_Click);
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.Color.Snow;
            this.placeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.placeOrderButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.placeOrderButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.placeOrderButton.Location = new System.Drawing.Point(894, 351);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(188, 44);
            this.placeOrderButton.TabIndex = 11;
            this.placeOrderButton.Text = "Place order";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // shoppingKartView
            // 
            this.shoppingKartView.AllowUserToAddRows = false;
            this.shoppingKartView.AllowUserToDeleteRows = false;
            this.shoppingKartView.AllowUserToResizeColumns = false;
            this.shoppingKartView.AllowUserToResizeRows = false;
            this.shoppingKartView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.shoppingKartView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.shoppingKartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoppingKartView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partName,
            this.Quantity,
            this.partPrice,
            this.detailsEmpty,
            this.removeEmpty});
            this.shoppingKartView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.shoppingKartView.Location = new System.Drawing.Point(30, 15);
            this.shoppingKartView.Margin = new System.Windows.Forms.Padding(30, 20, 30, 50);
            this.shoppingKartView.Name = "shoppingKartView";
            this.shoppingKartView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.shoppingKartView.RowHeadersVisible = false;
            this.shoppingKartView.RowTemplate.Height = 30;
            this.shoppingKartView.Size = new System.Drawing.Size(1035, 326);
            this.shoppingKartView.TabIndex = 8;
            this.shoppingKartView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.shoppingKartView_CellClick);
            this.shoppingKartView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.shoppingKartView_CellValidated);
            // 
            // stylingButtonSK
            // 
            this.stylingButtonSK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stylingButtonSK.Enabled = false;
            this.stylingButtonSK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stylingButtonSK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.stylingButtonSK.ForeColor = System.Drawing.Color.SteelBlue;
            this.stylingButtonSK.Location = new System.Drawing.Point(619, 12);
            this.stylingButtonSK.Name = "stylingButtonSK";
            this.stylingButtonSK.Size = new System.Drawing.Size(123, 38);
            this.stylingButtonSK.TabIndex = 26;
            this.stylingButtonSK.Text = "stylingButton";
            this.stylingButtonSK.UseVisualStyleBackColor = false;
            this.stylingButtonSK.Visible = false;
            // 
            // partID
            // 
            this.partID.HeaderText = "";
            this.partID.Name = "partID";
            this.partID.Visible = false;
            // 
            // partName
            // 
            this.partName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.partName.FillWeight = 509.3365F;
            this.partName.HeaderText = "Name";
            this.partName.Name = "partName";
            this.partName.Width = 470;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // partPrice
            // 
            this.partPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.partPrice.FillWeight = 9.496284F;
            this.partPrice.HeaderText = "Price";
            this.partPrice.Name = "partPrice";
            this.partPrice.Width = 140;
            // 
            // detailsEmpty
            // 
            this.detailsEmpty.HeaderText = "";
            this.detailsEmpty.Name = "detailsEmpty";
            this.detailsEmpty.Width = 150;
            // 
            // removeEmpty
            // 
            this.removeEmpty.HeaderText = "";
            this.removeEmpty.Name = "removeEmpty";
            this.removeEmpty.Width = 150;
            // 
            // form_ShoppingKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 481);
            this.ControlBox = false;
            this.Controls.Add(this.stylingButtonSK);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.kartLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_ShoppingKart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stern-Geschäft: Shopping kart";
            this.Load += new System.EventHandler(this.form_ShoppingKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shoppingKartView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label kartLabel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView shoppingKartView;
        private System.Windows.Forms.Button clearKartButton;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Button stylingButtonSK;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
        private System.Windows.Forms.DataGridViewButtonColumn detailsEmpty;
        private System.Windows.Forms.DataGridViewButtonColumn removeEmpty;
    }
}