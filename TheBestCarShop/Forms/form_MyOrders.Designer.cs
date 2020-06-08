namespace TheBestCarShop.In_progress
{
    partial class form_MyOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.sumLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.historyView = new System.Windows.Forms.DataGridView();
            this.recDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Snow;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.closeButton.Location = new System.Drawing.Point(942, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(130, 44);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // topLabel
            // 
            this.topLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.topLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.topLabel.Location = new System.Drawing.Point(-8, -3);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(1091, 68);
            this.topLabel.TabIndex = 4;
            this.topLabel.Text = "            My shopping history";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.LightGray;
            this.panel.Controls.Add(this.sumLabel);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.historyView);
            this.panel.Location = new System.Drawing.Point(-2, 73);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1100, 391);
            this.panel.TabIndex = 11;
            // 
            // sumLabel
            // 
            this.sumLabel.BackColor = System.Drawing.Color.Azure;
            this.sumLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sumLabel.Location = new System.Drawing.Point(331, 341);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(743, 38);
            this.sumLabel.TabIndex = 14;
            this.sumLabel.Text = "cost";
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(3, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 38);
            this.label2.TabIndex = 13;
            this.label2.Text = "You paid us : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // historyView
            // 
            this.historyView.AllowUserToAddRows = false;
            this.historyView.AllowUserToDeleteRows = false;
            this.historyView.AllowUserToResizeColumns = false;
            this.historyView.AllowUserToResizeRows = false;
            this.historyView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.historyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recDate,
            this.sentDate,
            this.delDate,
            this.productName,
            this.price,
            this.productQuantity});
            this.historyView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.historyView.Location = new System.Drawing.Point(7, 6);
            this.historyView.Margin = new System.Windows.Forms.Padding(30, 20, 30, 50);
            this.historyView.Name = "historyView";
            this.historyView.ReadOnly = true;
            this.historyView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.historyView.RowHeadersVisible = false;
            this.historyView.RowTemplate.Height = 30;
            this.historyView.Size = new System.Drawing.Size(1067, 326);
            this.historyView.TabIndex = 8;
            // 
            // recDate
            // 
            this.recDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recDate.HeaderText = "Received on";
            this.recDate.Name = "recDate";
            this.recDate.ReadOnly = true;
            // 
            // sentDate
            // 
            this.sentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sentDate.HeaderText = "Sent on";
            this.sentDate.Name = "sentDate";
            this.sentDate.ReadOnly = true;
            // 
            // delDate
            // 
            this.delDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delDate.HeaderText = "Delivered on";
            this.delDate.Name = "delDate";
            this.delDate.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "Product name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Product price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // productQuantity
            // 
            this.productQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productQuantity.HeaderText = "Product quantity";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            // 
            // form_MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form_MyOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stern-Geschäft: My shopping history";
            this.Load += new System.EventHandler(this.form_MyOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView historyView;
        private System.Windows.Forms.DataGridViewTextBoxColumn recDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn delDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
    }
}