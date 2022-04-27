namespace KütüphaneOtomosyon
{
    partial class ExportUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportUser));
            this.ExportUserButton = new System.Windows.Forms.Button();
            this.ImportUserButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GoBackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportUserButton
            // 
            this.ExportUserButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExportUserButton.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.ExportUserButton.ForeColor = System.Drawing.Color.White;
            this.ExportUserButton.Location = new System.Drawing.Point(169, 65);
            this.ExportUserButton.Name = "ExportUserButton";
            this.ExportUserButton.Size = new System.Drawing.Size(255, 179);
            this.ExportUserButton.TabIndex = 0;
            this.ExportUserButton.Text = "Verileri Dışarı Aktar\r\n(.xlxs)";
            this.ExportUserButton.UseVisualStyleBackColor = false;
            this.ExportUserButton.Click += new System.EventHandler(this.ExportUserButton_Click);
            // 
            // ImportUserButton
            // 
            this.ImportUserButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ImportUserButton.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.ImportUserButton.ForeColor = System.Drawing.Color.White;
            this.ImportUserButton.Location = new System.Drawing.Point(169, 250);
            this.ImportUserButton.Name = "ImportUserButton";
            this.ImportUserButton.Size = new System.Drawing.Size(255, 179);
            this.ImportUserButton.TabIndex = 1;
            this.ImportUserButton.Text = "Verileri İçeri Aktar\r\n*.txt / *.csv";
            this.ImportUserButton.UseVisualStyleBackColor = false;
            this.ImportUserButton.Click += new System.EventHandler(this.buttonGetFile_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.Transparent;
            this.GoBackButton.Image = ((System.Drawing.Image)(resources.GetObject("GoBackButton.Image")));
            this.GoBackButton.Location = new System.Drawing.Point(24, 23);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(40, 40);
            this.GoBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoBackButton.TabIndex = 26;
            this.GoBackButton.TabStop = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ExportUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.ImportUserButton);
            this.Controls.Add(this.ExportUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportUser";
            ((System.ComponentModel.ISupportInitialize)(this.GoBackButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportUserButton;
        private System.Windows.Forms.Button ImportUserButton;
        private System.Windows.Forms.PictureBox GoBackButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}