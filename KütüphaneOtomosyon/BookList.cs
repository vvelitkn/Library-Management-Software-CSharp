using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KütüphaneOtomosyon
{
    public partial class BookList : Form
    {
        private Timer x = new Timer();
        DataSet daset = new DataSet();
        SQLiteConnection connection = new SQLiteConnection(@"Data Source=Database\KütüphaneOtomasyon.db; Version=3;");

        public BookList()
        {
            InitializeComponent();
            booklist();
        }

        private void BookSearch_TextChanged(object sender, EventArgs e)
        {
            AuthorSearch.Clear();
            daset.Tables["Kitap"].Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Kitap where book like'%" + BookSearch.Text + "%'", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            connection.Close();
        }

        private void AuthorSearch_TextChanged(object sender, EventArgs e)
        {
            BookSearch.Clear();
            daset.Tables["Kitap"].Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Kitap where author like'%" + AuthorSearch.Text + "%'", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            connection.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBookName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBarkod.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPage.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtYear.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "Female")
            {
                txtCategory.SelectedIndex = 0;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "Male")
            {
                txtCategory.SelectedIndex = 1;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "None")
            {
                txtCategory.SelectedIndex = 3;
            }

            txtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCilt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new Anasayfa().Show();
            this.Hide();
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            var imgArray = new System.Windows.Forms.PictureBox[10];
            imgArray[0] = errorImg4;
            imgArray[1] = errorImg7;
            imgArray[2] = errorImg3;
            imgArray[3] = errorImg6;
            imgArray[4] = errorImg5;
            imgArray[5] = errorImg1;
            imgArray[6] = errorImg2;


            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item.Name != "BookSearch" && item.Name != "AuthorSearch")
                    {
                        if (item.Text == "")
                        {
                            imgArray[i].Visible = true;
                            Console.WriteLine(item.Name + " " + "i: " + i + " j: " + j);
                            j++;
                        }
                        i++;
                    }
                }
            }


            if (j == 0)
            {

                connection.Open();
                SQLiteCommand command = new SQLiteCommand("insert into Kitap(book, author, barkod, page,category, publish, stok, cilt) values(@book, @author, @barkod, @page,@category, @publish, @stok, @cilt)", connection);
                command.Parameters.AddWithValue("@book", txtBookName.Text);
                command.Parameters.AddWithValue("@author", txtAuthor.Text);
                command.Parameters.AddWithValue("@barkod", txtBarkod.Text);
                command.Parameters.AddWithValue("@page", txtPage.Text);
                command.Parameters.AddWithValue("@category", txtCategory.Text);
                command.Parameters.AddWithValue("@publish", txtYear.Text);
                command.Parameters.AddWithValue("@stok", txtStok.Text);
                command.Parameters.AddWithValue("@cilt", txtCilt.Text);
                command.ExecuteNonQuery();

                connection.Close();
                daset.Tables["Kitap"].Clear();
                connection.Open();
                SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Kitap where idnum like'%" + txtBookName.Text + "%'", connection);
                adtr.Fill(daset, "Kitap");
                dataGridView1.DataSource = daset.Tables["Kitap"];
                connection.Close();
                MessageBox.Show("Kitap kaydı güncellendi.");
            }
            else
            {
                x.Interval = (4000);  //1 second = 1000
                x.Tick += new EventHandler(TimerTask);
                x.Start();
            }



            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";


                }
                if (item is ComboBox)
                {
                    ;
                    txtCategory.SelectedIndex = -1;

                }
            }
        }
        private void TimerTask(object sender, EventArgs e)
        {
            errorImg1.Visible = false;
            errorImg2.Visible = false;
            errorImg3.Visible = false;
            errorImg4.Visible = false;
            errorImg5.Visible = false;
            errorImg6.Visible = false;
            errorImg7.Visible = false;
        }

        private void booklist()
        {
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Kitap", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            connection.Close();

        }
        private void buttonSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kitabı silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("delete from Kitap where book=@book", connection);
                command.Parameters.AddWithValue("@book", dataGridView1.CurrentRow.Cells["book"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();

                daset.Tables["Kitap"].Clear();
                booklist();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        ;
                        txtCategory.SelectedIndex = -1;

                    }
                }

                MessageBox.Show("Kitap silindi.");
            }


        }

        private void BookList_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }

            }
        }
    }
}
