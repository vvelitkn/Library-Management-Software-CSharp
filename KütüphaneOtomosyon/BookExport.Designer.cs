namespace KütüphaneOtomosyon
{
    partial class BookExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookExport));
            this.GoBackButton = new System.Windows.Forms.PictureBox();
            this.ImportBookButton = new System.Windows.Forms.Button();
            this.ExportBookButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GoBackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.White;
            this.GoBackButton.Image = ((System.Drawing.Image)(resources.GetObject("GoBackButton.Image")));
            this.GoBackButton.Location = new System.Drawing.Point(36, 19);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(40, 40);
            this.GoBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoBackButton.TabIndex = 29;
            this.GoBackButton.TabStop = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click_1);
            // 
            // ImportBookButton
            // 
            this.ImportBookButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ImportBookButton.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.ImportBookButton.ForeColor = System.Drawing.Color.White;
            this.ImportBookButton.Location = new System.Drawing.Point(181, 246);
            this.ImportBookButton.Name = "ImportBookButton";
            this.ImportBookButton.Size = new System.Drawing.Size(255, 179);
            this.ImportBookButton.TabIndex = 28;
            this.ImportBookButton.Text = "Verileri İçeri Aktar\r\n*.txt / *.csv";
            this.ImportBookButton.UseVisualStyleBackColor = false;
            this.ImportBookButton.Click += new System.EventHandler(this.buttonGetFile_Click);
            // 
            // ExportBookButton
            // 
            this.ExportBookButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ExportBookButton.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold);
            this.ExportBookButton.ForeColor = System.Drawing.Color.White;
            this.ExportBookButton.Location = new System.Drawing.Point(181, 61);
            this.ExportBookButton.Name = "ExportBookButton";
            this.ExportBookButton.Size = new System.Drawing.Size(255, 179);
            this.ExportBookButton.TabIndex = 27;
            this.ExportBookButton.Text = "Verileri Dışarı Aktar\r\n(.xlxs)";
            this.ExportBookButton.UseVisualStyleBackColor = false;
            this.ExportBookButton.Click += new System.EventHandler(this.ExportBookButton_Click);
            // 
            // BookExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.ImportBookButton);
            this.Controls.Add(this.ExportBookButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookExport";
            ((System.ComponentModel.ISupportInitialize)(this.GoBackButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GoBackButton;
        private System.Windows.Forms.Button ImportBookButton;
        private System.Windows.Forms.Button ExportBookButton;
    }
}