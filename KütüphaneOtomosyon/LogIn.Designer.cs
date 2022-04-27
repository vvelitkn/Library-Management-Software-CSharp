namespace KütüphaneOtomosyon
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UsernameLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PasswordLogo = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.errorImg1 = new System.Windows.Forms.PictureBox();
            this.errorImg2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorImg2)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(92, 37);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(124, 135);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(40, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 2);
            this.panel1.TabIndex = 2;
            // 
            // UsernameLogo
            // 
            this.UsernameLogo.BackColor = System.Drawing.Color.White;
            this.UsernameLogo.Image = ((System.Drawing.Image)(resources.GetObject("UsernameLogo.Image")));
            this.UsernameLogo.Location = new System.Drawing.Point(40, 240);
            this.UsernameLogo.Name = "UsernameLogo";
            this.UsernameLogo.Size = new System.Drawing.Size(25, 25);
            this.UsernameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsernameLogo.TabIndex = 3;
            this.UsernameLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(40, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 2);
            this.panel2.TabIndex = 2;
            // 
            // PasswordLogo
            // 
            this.PasswordLogo.BackColor = System.Drawing.Color.White;
            this.PasswordLogo.Image = ((System.Drawing.Image)(resources.GetObject("PasswordLogo.Image")));
            this.PasswordLogo.Location = new System.Drawing.Point(40, 288);
            this.PasswordLogo.Name = "PasswordLogo";
            this.PasswordLogo.Size = new System.Drawing.Size(25, 25);
            this.PasswordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordLogo.TabIndex = 3;
            this.PasswordLogo.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(40, 370);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(236, 44);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "GİRİŞ YAP";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUsername.Location = new System.Drawing.Point(84, 240);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.Size = new System.Drawing.Size(192, 24);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtUserPass
            // 
            this.txtUserPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserPass.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtUserPass.Location = new System.Drawing.Point(83, 288);
            this.txtUserPass.Multiline = true;
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserPass.Size = new System.Drawing.Size(192, 24);
            this.txtUserPass.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ExitButton.Location = new System.Drawing.Point(105, 420);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(103, 44);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "ÇIKIŞ YAP";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.BackColor = System.Drawing.Color.White;
            this.CleanButton.FlatAppearance.BorderSize = 0;
            this.CleanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanButton.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CleanButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CleanButton.Location = new System.Drawing.Point(193, 327);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(103, 37);
            this.CleanButton.TabIndex = 3;
            this.CleanButton.Text = "Temizle";
            this.CleanButton.UseVisualStyleBackColor = false;
            this.CleanButton.Click += new System.EventHandler(this.CleanButton_Click);
            // 
            // errorImg1
            // 
            this.errorImg1.Image = ((System.Drawing.Image)(resources.GetObject("errorImg1.Image")));
            this.errorImg1.Location = new System.Drawing.Point(257, 246);
            this.errorImg1.Name = "errorImg1";
            this.errorImg1.Size = new System.Drawing.Size(18, 18);
            this.errorImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorImg1.TabIndex = 6;
            this.errorImg1.TabStop = false;
            this.errorImg1.Visible = false;
            // 
            // errorImg2
            // 
            this.errorImg2.Image = ((System.Drawing.Image)(resources.GetObject("errorImg2.Image")));
            this.errorImg2.Location = new System.Drawing.Point(257, 294);
            this.errorImg2.Name = "errorImg2";
            this.errorImg2.Size = new System.Drawing.Size(18, 18);
            this.errorImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorImg2.TabIndex = 6;
            this.errorImg2.TabStop = false;
            this.errorImg2.Visible = false;
            this.errorImg2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 486);
            this.Controls.Add(this.errorImg2);
            this.Controls.Add(this.errorImg1);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.txtUserPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLogo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UsernameLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logo);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorImg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox UsernameLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PasswordLogo;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.PictureBox errorImg1;
        private System.Windows.Forms.PictureBox errorImg2;
    }
}

