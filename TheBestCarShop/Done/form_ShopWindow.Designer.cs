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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.topBarsPanel = new System.Windows.Forms.Panel();
            this.stylingButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButtons = new System.Windows.Forms.Button();
            this.priceToCBox = new System.Windows.Forms.ComboBox();
            this.priceFromCBox = new System.Windows.Forms.ComboBox();
            this.manufacturerCBox = new System.Windows.Forms.ComboBox();
            this.categoryCBox = new System.Windows.Forms.ComboBox();
            this.lastYearCBox = new System.Windows.Forms.ComboBox();
            this.firstYearCBox = new System.Windows.Forms.ComboBox();
            this.modelCBox = new System.Windows.Forms.ComboBox();
            this.brandCBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shoppingKartButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchResultView = new System.Windows.Forms.DataGridView();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partManufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsEmpty = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kartEmpty = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.topBarsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Snow;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.closeButton.Location = new System.Drawing.Point(1252, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(108, 44);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.titleLabel.Location = new System.Drawing.Point(-6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1392, 64);
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
            this.topBarsPanel.Controls.Add(this.stylingButton);
            this.topBarsPanel.Controls.Add(this.searchButton);
            this.topBarsPanel.Controls.Add(this.clearButtons);
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
            this.topBarsPanel.Size = new System.Drawing.Size(1386, 197);
            this.topBarsPanel.TabIndex = 7;
            // 
            // stylingButton
            // 
            this.stylingButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stylingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stylingButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.stylingButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.stylingButton.Location = new System.Drawing.Point(847, 12);
            this.stylingButton.Name = "stylingButton";
            this.stylingButton.Size = new System.Drawing.Size(123, 38);
            this.stylingButton.TabIndex = 25;
            this.stylingButton.Text = "stylingButton";
            this.stylingButton.UseVisualStyleBackColor = false;
            this.stylingButton.Visible = false;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Snow;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.searchButton.Location = new System.Drawing.Point(1111, 139);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(249, 42);
            this.searchButton.TabIndex = 24;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButtons
            // 
            this.clearButtons.BackColor = System.Drawing.Color.Snow;
            this.clearButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButtons.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.clearButtons.ForeColor = System.Drawing.SystemColors.Highlight;
            this.clearButtons.Location = new System.Drawing.Point(1111, 78);
            this.clearButtons.Name = "clearButtons";
            this.clearButtons.Size = new System.Drawing.Size(249, 42);
            this.clearButtons.TabIndex = 23;
            this.clearButtons.Text = "Clear fields";
            this.clearButtons.UseVisualStyleBackColor = false;
            this.clearButtons.Click += new System.EventHandler(this.clearButtons_Click);
            // 
            // priceToCBox
            // 
            this.priceToCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.priceToCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.priceToCBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceToCBox.FormattingEnabled = true;
            this.priceToCBox.Location = new System.Drawing.Point(844, 160);
            this.priceToCBox.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.priceToCBox.Name = "priceToCBox";
            this.priceToCBox.Size = new System.Drawing.Size(233, 24);
            this.priceToCBox.TabIndex = 22;
            // 
            // priceFromCBox
            // 
            this.priceFromCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.priceFromCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.priceFromCBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceFromCBox.FormattingEnabled = true;
            this.priceFromCBox.ItemHeight = 16;
            this.priceFromCBox.Location = new System.Drawing.Point(571, 160);
            this.priceFromCBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.priceFromCBox.Name = "priceFromCBox";
            this.priceFromCBox.Size = new System.Drawing.Size(233, 24);
            this.priceFromCBox.TabIndex = 21;
            this.priceFromCBox.SelectedIndexChanged += new System.EventHandler(this.priceFromCBox_SelectedIndexChanged);
            this.priceFromCBox.TextChanged += new System.EventHandler(this.priceFromCBox_TextChanged);
            this.priceFromCBox.Leave += new System.EventHandler(this.priceFromCBox_Leave);
            // 
            // manufacturerCBox
            // 
            this.manufacturerCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.manufacturerCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.manufacturerCBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturerCBox.FormattingEnabled = true;
            this.manufacturerCBox.ItemHeight = 16;
            this.manufacturerCBox.Location = new System.Drawing.Point(298, 160);
            this.manufacturerCBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.manufacturerCBox.Name = "manufacturerCBox";
            this.manufacturerCBox.Size = new System.Drawing.Size(233, 24);
            this.manufacturerCBox.TabIndex = 20;
            // 
            // categoryCBox
            // 
            this.categoryCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.categoryCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoryCBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCBox.FormattingEnabled = true;
            this.categoryCBox.ItemHeight = 16;
            this.categoryCBox.Location = new System.Drawing.Point(25, 160);
            this.categoryCBox.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.categoryCBox.Name = "categoryCBox";
            this.categoryCBox.Size = new System.Drawing.Size(233, 24);
            this.categoryCBox.TabIndex = 19;
            this.categoryCBox.SelectedIndexChanged += new System.EventHandler(this.categoryCBox_SelectedIndexChanged);
            this.categoryCBox.TextChanged += new System.EventHandler(this.categoryCBox_TextChanged);
            this.categoryCBox.Leave += new System.EventHandler(this.categoryCBox_Leave);
            // 
            // lastYearCBox
            // 
            this.lastYearCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lastYearCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.lastYearCBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastYearCBox.FormattingEnabled = true;
            this.lastYearCBox.Location = new System.Drawing.Point(844, 99);
            this.lastYearCBox.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.lastYearCBox.MaxDropDownItems = 5;
            this.lastYearCBox.MaxLength = 4;
            this.lastYearCBox.Name = "lastYearCBox";
            this.lastYearCBox.Size = new System.Drawing.Size(233, 24);
            this.lastYearCBox.TabIndex = 18;
            // 
            // firstYearCBox
            // 
            this.firstYearCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.firstYearCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.firstYearCBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstYearCBox.FormattingEnabled = true;
            this.firstYearCBox.ItemHeight = 16;
            this.firstYearCBox.Location = new System.Drawing.Point(571, 99);
            this.firstYearCBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.firstYearCBox.MaxLength = 4;
            this.firstYearCBox.Name = "firstYearCBox";
            this.firstYearCBox.Size = new System.Drawing.Size(233, 24);
            this.firstYearCBox.TabIndex = 17;
            this.firstYearCBox.SelectedIndexChanged += new System.EventHandler(this.firstYearCBox_SelectedIndexChanged);
            this.firstYearCBox.TextChanged += new System.EventHandler(this.firstYearCBox_TextChanged);
            this.firstYearCBox.Leave += new System.EventHandler(this.firstYearCBox_Leave);
            // 
            // modelCBox
            // 
            this.modelCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.modelCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.modelCBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelCBox.FormattingEnabled = true;
            this.modelCBox.ItemHeight = 16;
            this.modelCBox.Location = new System.Drawing.Point(298, 99);
            this.modelCBox.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.modelCBox.Name = "modelCBox";
            this.modelCBox.Size = new System.Drawing.Size(233, 24);
            this.modelCBox.TabIndex = 16;
            this.modelCBox.SelectedIndexChanged += new System.EventHandler(this.modelCBox_SelectedIndexChanged);
            this.modelCBox.TextChanged += new System.EventHandler(this.modelCBox_TextChanged);
            this.modelCBox.Leave += new System.EventHandler(this.modelCBox_Leave);
            // 
            // brandCBox
            // 
            this.brandCBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.brandCBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.brandCBox.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandCBox.FormattingEnabled = true;
            this.brandCBox.ItemHeight = 16;
            this.brandCBox.Location = new System.Drawing.Point(25, 99);
            this.brandCBox.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.brandCBox.Name = "brandCBox";
            this.brandCBox.Size = new System.Drawing.Size(233, 24);
            this.brandCBox.TabIndex = 9;
            this.brandCBox.SelectedIndexChanged += new System.EventHandler(this.brandCBox_SelectedIndexChanged);
            this.brandCBox.TextUpdate += new System.EventHandler(this.brandCBox_TextUpdate);
            this.brandCBox.Leave += new System.EventHandler(this.brandCBox_Leave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Azure;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(844, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Price up to";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Azure;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(571, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price from";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Azure;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(298, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Part manufacturer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Azure;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(25, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Part category";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Azure;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(571, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "First year of production";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(298, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Car model";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 3, 20, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Car brand";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shoppingKartButton
            // 
            this.shoppingKartButton.BackColor = System.Drawing.Color.Snow;
            this.shoppingKartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shoppingKartButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.shoppingKartButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.shoppingKartButton.Location = new System.Drawing.Point(1111, 12);
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
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(844, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 3, 10, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last year of production";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchResultView
            // 
            this.searchResultView.AllowUserToAddRows = false;
            this.searchResultView.AllowUserToDeleteRows = false;
            this.searchResultView.AllowUserToResizeColumns = false;
            this.searchResultView.AllowUserToResizeRows = false;
            this.searchResultView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.searchResultView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.searchResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.partCategory,
            this.partName,
            this.partManufacturer,
            this.partPrice,
            this.detailsEmpty,
            this.kartEmpty});
            this.searchResultView.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.searchResultView.Location = new System.Drawing.Point(21, 16);
            this.searchResultView.Margin = new System.Windows.Forms.Padding(30, 20, 30, 50);
            this.searchResultView.Name = "searchResultView";
            this.searchResultView.ReadOnly = true;
            this.searchResultView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.searchResultView.RowHeadersVisible = false;
            this.searchResultView.RowTemplate.Height = 30;
            this.searchResultView.Size = new System.Drawing.Size(1335, 478);
            this.searchResultView.TabIndex = 8;
            this.searchResultView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResultView_CellClick);
            // 
            // partID
            // 
            this.partID.HeaderText = "";
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            this.partID.Visible = false;
            // 
            // partCategory
            // 
            this.partCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.partCategory.FillWeight = 39.78316F;
            this.partCategory.HeaderText = "Category";
            this.partCategory.Name = "partCategory";
            this.partCategory.ReadOnly = true;
            this.partCategory.Width = 175;
            // 
            // partName
            // 
            this.partName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.partName.FillWeight = 509.3365F;
            this.partName.HeaderText = "Name";
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
            this.partName.Width = 470;
            // 
            // partManufacturer
            // 
            this.partManufacturer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.partManufacturer.FillWeight = 16.72323F;
            this.partManufacturer.HeaderText = "Manufacturer";
            this.partManufacturer.Name = "partManufacturer";
            this.partManufacturer.ReadOnly = true;
            this.partManufacturer.Width = 225;
            // 
            // partPrice
            // 
            this.partPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.partPrice.FillWeight = 9.496284F;
            this.partPrice.HeaderText = "Price";
            this.partPrice.Name = "partPrice";
            this.partPrice.ReadOnly = true;
            this.partPrice.Width = 140;
            // 
            // detailsEmpty
            // 
            this.detailsEmpty.HeaderText = "";
            this.detailsEmpty.Name = "detailsEmpty";
            this.detailsEmpty.ReadOnly = true;
            this.detailsEmpty.Width = 150;
            // 
            // kartEmpty
            // 
            this.kartEmpty.HeaderText = "";
            this.kartEmpty.Name = "kartEmpty";
            this.kartEmpty.ReadOnly = true;
            this.kartEmpty.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.searchResultView);
            this.panel1.Location = new System.Drawing.Point(-6, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 517);
            this.panel1.TabIndex = 9;
            // 
            // form_ShopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 729);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.searchResultView)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButtons;
        private System.Windows.Forms.DataGridView searchResultView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partManufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn partPrice;
        private System.Windows.Forms.DataGridViewButtonColumn detailsEmpty;
        private System.Windows.Forms.DataGridViewButtonColumn kartEmpty;
        private System.Windows.Forms.Button stylingButton;
    }
}