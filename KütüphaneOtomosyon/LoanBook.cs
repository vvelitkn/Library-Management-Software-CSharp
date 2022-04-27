using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KütüphaneOtomosyon
{
    public partial class LoanBook : Form
    {
        DataSet daset = new DataSet();
        SQLiteConnection connection = new SQLiteConnection(@"Data Source=Database\KütüphaneOtomasyon.db; Version=3;");

        public LoanBook()
        {
            InitializeComponent();
            booklist();
            userlist();
        }
        private void userlist()
        {
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Uye", connection);
            adtr.Fill(daset, "Uye");
            dataGridView2.DataSource = daset.Tables["Uye"];
            connection.Close();

        }
        private void booklist()
        {
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Kitap", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            connection.Close();

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
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Kitap where id like'%" + AuthorSearch.Text + "%'", connection);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            connection.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBookName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStok.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new Anasayfa().Show();
            this.Hide();
        }

        private void txtIdSearch_TextChanged(object sender, EventArgs e)
        {
            txtNameSearch.Clear();
            daset.Tables["Uye"].Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Uye where idnum like'%" + txtIdSearch.Text + "%'", connection);
            adtr.Fill(daset, "Uye");
            dataGridView2.DataSource = daset.Tables["Uye"];
            connection.Close();
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            txtIdSearch.Clear();
            daset.Tables["Uye"].Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Uye where name like'%" + txtNameSearch.Text + "%'", connection);
            adtr.Fill(daset, "Uye");
            dataGridView2.DataSource = daset.Tables["Uye"];
            connection.Close();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtIdNum.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAge.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void LoanButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("insert into Loan(userid, bookid, date) values(@userid, @bookid, @date)", connection);
            command.Parameters.AddWithValue("@bookid", textBox1.Text);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            command.Parameters.AddWithValue("@userid", txtIdNum.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Ödünç kaydı tamamlandı.");

        }

        private void LoanBook_Load(object sender, EventArgs e)
        {

        }

        private void LoanBook_Click(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
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
