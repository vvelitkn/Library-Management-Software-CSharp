namespace KütüphaneOtomosyon
{
    partial class LoanBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanBook));
            this.label9 = new System.Windows.Forms.Label();
            this.BookSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AuthorSearchLabel = new System.Windows.Forms.Label();
            this.AuthorSearch = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.txtIdSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdNum = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.GoBackButton = new System.Windows.Forms.PictureBox();
            this.LoanButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoBackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(215, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 24);
            this.label9.TabIndex = 51;
            this.label9.Text = "Kitap ismi ile arama";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookSearch
            // 
            this.BookSearch.BackColor = System.Drawing.Color.White;
            this.BookSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.BookSearch.ForeColor = System.Drawing.Color.Black;
            this.BookSearch.Location = new System.Drawing.Point(219, 91);
            this.BookSearch.Multiline = true;
            this.BookSearch.Name = "BookSearch";
            this.BookSearch.Size = new System.Drawing.Size(173, 24);
            this.BookSearch.TabIndex = 52;
            this.BookSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BookSearch.TextChanged += new System.EventHandler(this.BookSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(23, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 103);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // AuthorSearchLabel
            // 
            this.AuthorSearchLabel.AutoSize = true;
            this.AuthorSearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AuthorSearchLabel.ForeColor = System.Drawing.Color.White;
            this.AuthorSearchLabel.Location = new System.Drawing.Point(20, 64);
            this.AuthorSearchLabel.Name = "AuthorSearchLabel";
            this.AuthorSearchLabel.Size = new System.Drawing.Size(152, 24);
            this.AuthorSearchLabel.TabIndex = 53;
            this.AuthorSearchLabel.Text = "Kitap Id ile arama";
            this.AuthorSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorSearch
            // 
            this.AuthorSearch.BackColor = System.Drawing.Color.White;
            this.AuthorSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.AuthorSearch.ForeColor = System.Drawing.Color.Black;
            this.AuthorSearch.Location = new System.Drawing.Point(23, 91);
            this.AuthorSearch.Multiline = true;
            this.AuthorSearch.Name = "AuthorSearch";
            this.AuthorSearch.Size = new System.Drawing.Size(173, 24);
            this.AuthorSearch.TabIndex = 54;
            this.AuthorSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AuthorSearch.TextChanged += new System.EventHandler(this.AuthorSearch_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(676, 64);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(124, 24);
            this.NameLabel.TabIndex = 56;
            this.NameLabel.Text = "İsim ile arama";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "TC ile arama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.BackColor = System.Drawing.Color.White;
            this.txtNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.txtNameSearch.ForeColor = System.Drawing.Color.Black;
            this.txtNameSearch.Location = new System.Drawing.Point(680, 91);
            this.txtNameSearch.Multiline = true;
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(173, 24);
            this.txtNameSearch.TabIndex = 58;
            this.txtNameSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
            // 
            // txtIdSearch
            // 
            this.txtIdSearch.BackColor = System.Drawing.Color.White;
            this.txtIdSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.txtIdSearch.ForeColor = System.Drawing.Color.Black;
            this.txtIdSearch.Location = new System.Drawing.Point(485, 91);
            this.txtIdSearch.Multiline = true;
            this.txtIdSearch.Name = "txtIdSearch";
            this.txtIdSearch.Size = new System.Drawing.Size(173, 24);
            this.txtIdSearch.TabIndex = 59;
            this.txtIdSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdSearch.TextChanged += new System.EventHandler(this.txtIdSearch_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(485, 136);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(369, 103);
            this.dataGridView2.TabIndex = 55;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(149, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 24);
            this.label8.TabIndex = 61;
            this.label8.Text = "Kitap";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(154, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "Stok";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Yazar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.Color.White;
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.txtBookName.ForeColor = System.Drawing.Color.Black;
            this.txtBookName.Location = new System.Drawing.Point(219, 254);
            this.txtBookName.Multiline = true;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(173, 24);
            this.txtBookName.TabIndex = 64;
            this.txtBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStok
            // 
            this.txtStok.BackColor = System.Drawing.Color.White;
            this.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.txtStok.ForeColor = System.Drawing.Color.Black;
            this.txtStok.Location = new System.Drawing.Point(219, 314);
            this.txtStok.Multiline = true;
            this.txtStok.Name = "txtStok";
            this.txtStok.ReadOnly = true;
            this.txtStok.Size = new System.Drawing.Size(173, 24);
            this.txtStok.TabIndex = 65;
            this.txtStok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.White;
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.txtAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtAuthor.Location = new System.Drawing.Point(219, 284);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(173, 24);
            this.txtAuthor.TabIndex = 60;
            this.txtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(605, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 67;
            this.label3.Text = "TC No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(629, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 24);
            this.label7.TabIndex = 68;
            this.label7.Text = "Yaş";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(557, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 70;
            this.label6.Text = "İsim Soyisim";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdNum
            // 
            this.txtIdNum.BackColor = System.Drawing.Color.White;
            this.txtIdNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.txtIdNum.ForeColor = System.Drawing.Color.Black;
            this.txtIdNum.Location = new System.Drawing.Point(680, 254);
            this.txtIdNum.Multiline = true;
            this.txtIdNum.Name = "txtIdNum";
            this.txtIdNum.ReadOnly = true;
            this.txtIdNum.Size = new System.Drawing.Size(173, 24);
            this.txtIdNum.TabIndex = 73;
            this.txtIdNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.White;
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Location = new System.Drawing.Point(681, 316);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(173, 24);
            this.txtAge.TabIndex = 72;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(680, 284);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(173, 24);
            this.txtName.TabIndex = 66;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.Color.Transparent;
            this.GoBackButton.Image = ((System.Drawing.Image)(resources.GetObject("GoBackButton.Image")));
            this.GoBackButton.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(40, 40);
            this.GoBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GoBackButton.TabIndex = 74;
            this.GoBackButton.TabStop = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // LoanButton
            // 
            this.LoanButton.BackColor = System.Drawing.Color.Transparent;
            this.LoanButton.FlatAppearance.BorderSize = 0;
            this.LoanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoanButton.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Bold);
            this.LoanButton.ForeColor = System.Drawing.Color.White;
            this.LoanButton.Location = new System.Drawing.Point(345, 374);
            this.LoanButton.Name = "LoanButton";
            this.LoanButton.Size = new System.Drawing.Size(252, 44);
            this.LoanButton.TabIndex = 75;
            this.LoanButton.Text = "ÖDÜNÇ VER";
            this.LoanButton.UseVisualStyleBackColor = false;
            this.LoanButton.Click += new System.EventHandler(this.LoanButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)), true);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(66, 284);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(51, 24);
            this.textBox1.TabIndex = 76;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoanBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LoanButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdNum);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.txtIdSearch);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.AuthorSearchLabel);
            this.Controls.Add(this.AuthorSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BookSearch);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoanBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoanBook";
            this.Load += new System.EventHandler(this.LoanBook_Load);
            this.Click += new System.EventHandler(this.LoanBook_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoBackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BookSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label AuthorSearchLabel;
        private System.Windows.Forms.TextBox AuthorSearch;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.TextBox txtIdSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdNum;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox GoBackButton;
        private System.Windows.Forms.Button LoanButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}