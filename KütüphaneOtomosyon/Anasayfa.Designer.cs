namespace KütüphaneOtomosyon
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.UyeIslemleri = new System.Windows.Forms.GroupBox();
            this.UserList = new System.Windows.Forms.Button();
            this.UserExport = new System.Windows.Forms.Button();
            this.UserAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BookList = new System.Windows.Forms.Button();
            this.BookExport = new System.Windows.Forms.Button();
            this.BookAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BorrowFollow = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Borrow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UyeIslemleri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UyeIslemleri
            // 
            this.UyeIslemleri.BackColor = System.Drawing.Color.Transparent;
            this.UyeIslemleri.Controls.Add(this.UserList);
            this.UyeIslemleri.Controls.Add(this.UserExport);
            this.UyeIslemleri.Controls.Add(this.UserAdd);
            this.UyeIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UyeIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeIslemleri.ForeColor = System.Drawing.Color.White;
            this.UyeIslemleri.Location = new System.Drawing.Point(31, 55);
            this.UyeIslemleri.Name = "UyeIslemleri";
            this.UyeIslemleri.Size = new System.Drawing.Size(251, 517);
            this.UyeIslemleri.TabIndex = 0;
            this.UyeIslemleri.TabStop = false;
            this.UyeIslemleri.Text = "Üye İşlemleri";
            // 
            // UserList
            // 
            this.UserList.BackColor = System.Drawing.Color.Navy;
            this.UserList.FlatAppearance.BorderSize = 0;
            this.UserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserList.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserList.ForeColor = System.Drawing.Color.White;
            this.UserList.Location = new System.Drawing.Point(38, 207);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(180, 130);
            this.UserList.TabIndex = 0;
            this.UserList.Text = "Üyeleri Listele";
            this.UserList.UseVisualStyleBackColor = false;
            this.UserList.Click += new System.EventHandler(this.UserList_Click);
            // 
            // UserExport
            // 
            this.UserExport.BackColor = System.Drawing.Color.Navy;
            this.UserExport.FlatAppearance.BorderSize = 0;
            this.UserExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserExport.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserExport.ForeColor = System.Drawing.Color.White;
            this.UserExport.Location = new System.Drawing.Point(38, 351);
            this.UserExport.Name = "UserExport";
            this.UserExport.Size = new System.Drawing.Size(180, 130);
            this.UserExport.TabIndex = 0;
            this.UserExport.Text = "İçeri / Dışarı Aktar";
            this.UserExport.UseVisualStyleBackColor = false;
            this.UserExport.Click += new System.EventHandler(this.UserExport_Click);
            // 
            // UserAdd
            // 
            this.UserAdd.BackColor = System.Drawing.Color.Navy;
            this.UserAdd.FlatAppearance.BorderSize = 0;
            this.UserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserAdd.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserAdd.ForeColor = System.Drawing.Color.White;
            this.UserAdd.Location = new System.Drawing.Point(38, 61);
            this.UserAdd.Name = "UserAdd";
            this.UserAdd.Size = new System.Drawing.Size(180, 130);
            this.UserAdd.TabIndex = 0;
            this.UserAdd.Text = "Üye Ekle/Sil";
            this.UserAdd.UseVisualStyleBackColor = false;
            this.UserAdd.Click += new System.EventHandler(this.UserAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BookList);
            this.groupBox1.Controls.Add(this.BookExport);
            this.groupBox1.Controls.Add(this.BookAdd);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(398, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap İşlemleri";
            // 
            // BookList
            // 
            this.BookList.BackColor = System.Drawing.Color.Navy;
            this.BookList.FlatAppearance.BorderSize = 0;
            this.BookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookList.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookList.ForeColor = System.Drawing.Color.White;
            this.BookList.Location = new System.Drawing.Point(38, 207);
            this.BookList.Name = "BookList";
            this.BookList.Size = new System.Drawing.Size(180, 130);
            this.BookList.TabIndex = 0;
            this.BookList.Text = "Kitapları Listele";
            this.BookList.UseVisualStyleBackColor = false;
            this.BookList.Click += new System.EventHandler(this.BookList_Click);
            // 
            // BookExport
            // 
            this.BookExport.BackColor = System.Drawing.Color.Navy;
            this.BookExport.FlatAppearance.BorderSize = 0;
            this.BookExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookExport.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookExport.ForeColor = System.Drawing.Color.White;
            this.BookExport.Location = new System.Drawing.Point(38, 351);
            this.BookExport.Name = "BookExport";
            this.BookExport.Size = new System.Drawing.Size(180, 130);
            this.BookExport.TabIndex = 0;
            this.BookExport.Text = "Kitapları Dışarı Aktar";
            this.BookExport.UseVisualStyleBackColor = false;
            this.BookExport.Click += new System.EventHandler(this.BookExport_Click);
            // 
            // BookAdd
            // 
            this.BookAdd.BackColor = System.Drawing.Color.Navy;
            this.BookAdd.FlatAppearance.BorderSize = 0;
            this.BookAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookAdd.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BookAdd.ForeColor = System.Drawing.Color.White;
            this.BookAdd.Location = new System.Drawing.Point(38, 61);
            this.BookAdd.Name = "BookAdd";
            this.BookAdd.Size = new System.Drawing.Size(180, 130);
            this.BookAdd.TabIndex = 0;
            this.BookAdd.Text = "Kitap Ekle/Sil";
            this.BookAdd.UseVisualStyleBackColor = false;
            this.BookAdd.Click += new System.EventHandler(this.BookAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BorrowFollow);
            this.groupBox2.Controls.Add(this.Exit);
            this.groupBox2.Controls.Add(this.Borrow);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(759, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 517);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diğer İşlemler";
            // 
            // BorrowFollow
            // 
            this.BorrowFollow.BackColor = System.Drawing.Color.Navy;
            this.BorrowFollow.FlatAppearance.BorderSize = 0;
            this.BorrowFollow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowFollow.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BorrowFollow.ForeColor = System.Drawing.Color.White;
            this.BorrowFollow.Location = new System.Drawing.Point(38, 207);
            this.BorrowFollow.Name = "BorrowFollow";
            this.BorrowFollow.Size = new System.Drawing.Size(180, 130);
            this.BorrowFollow.TabIndex = 0;
            this.BorrowFollow.Text = "Ödünç Takip";
            this.BorrowFollow.UseVisualStyleBackColor = false;
            this.BorrowFollow.Click += new System.EventHandler(this.BorrowFollow_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Navy;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(38, 351);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 130);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Çıkış Yap";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Borrow
            // 
            this.Borrow.BackColor = System.Drawing.Color.Navy;
            this.Borrow.FlatAppearance.BorderSize = 0;
            this.Borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrow.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Borrow.ForeColor = System.Drawing.Color.White;
            this.Borrow.Location = new System.Drawing.Point(38, 61);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(180, 130);
            this.Borrow.TabIndex = 0;
            this.Borrow.Text = "Ödünç Ver/Al";
            this.Borrow.UseVisualStyleBackColor = false;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1022, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UyeIslemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.UyeIslemleri.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UyeIslemleri;
        private System.Windows.Forms.Button UserList;
        private System.Windows.Forms.Button UserExport;
        private System.Windows.Forms.Button UserAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BookList;
        private System.Windows.Forms.Button BookExport;
        private System.Windows.Forms.Button BookAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BorrowFollow;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}