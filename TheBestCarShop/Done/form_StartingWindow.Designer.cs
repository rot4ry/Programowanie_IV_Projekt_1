namespace TheBestCarShop
{
    partial class form_StartingWindow
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
            this.loginButton = new System.Windows.Forms.Button();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.githubLabel = new System.Windows.Forms.Label();
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Snow;
            this.loginButton.Enabled = false;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.loginButton.Location = new System.Drawing.Point(80, 305);
            this.loginButton.MaximumSize = new System.Drawing.Size(350, 50);
            this.loginButton.MinimumSize = new System.Drawing.Size(200, 50);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 50);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Sign in";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // createAccountButton
            // 
            this.createAccountButton.BackColor = System.Drawing.Color.Snow;
            this.createAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccountButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.createAccountButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.createAccountButton.Location = new System.Drawing.Point(90, 380);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(180, 40);
            this.createAccountButton.TabIndex = 1;
            this.createAccountButton.Text = "Create new account";
            this.createAccountButton.UseVisualStyleBackColor = false;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // githubLabel
            // 
            this.githubLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.githubLabel.Enabled = false;
            this.githubLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.githubLabel.Location = new System.Drawing.Point(135, 445);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(90, 13);
            this.githubLabel.TabIndex = 2;
            this.githubLabel.Text = "github.com/rot4ry";
            this.githubLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginTextbox
            // 
            this.loginTextbox.Location = new System.Drawing.Point(60, 206);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(240, 20);
            this.loginTextbox.TabIndex = 3;
            this.loginTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginTextbox.TextChanged += new System.EventHandler(this.loginTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(60, 249);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.Size = new System.Drawing.Size(240, 20);
            this.passwordTextbox.TabIndex = 4;
            this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::TheBestCarShop.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(80, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 140);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // orLabel
            // 
            this.orLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.orLabel.Location = new System.Drawing.Point(140, 357);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(80, 21);
            this.orLabel.TabIndex = 6;
            this.orLabel.Text = "———  OR  ———";
            this.orLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.usernameLabel.Location = new System.Drawing.Point(80, 181);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(200, 24);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordLabel.Location = new System.Drawing.Point(130, 229);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(100, 19);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.passwordLabel.Click += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // form_StartingWindow
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 461);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_StartingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stern-Geschäft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.Label githubLabel;
        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label orLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}

