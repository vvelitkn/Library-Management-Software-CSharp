using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace KütüphaneOtomosyon
{
    public partial class LoanFollow : Form
    {
        private Timer x = new Timer();
        DataSet daset = new DataSet();
        SQLiteConnection connection = new SQLiteConnection(@"Data Source=Database\KütüphaneOtomasyon.db; Version=3;");

        public LoanFollow()
        {
            InitializeComponent();
            fillall();
            filllate();
        }
        private void LoanFollow_Load(object sender, EventArgs e)
        {

        } 
        

        private void filllate()
        {
            DataTable datacheck = new DataTable();


            DataTable latedata = new DataTable();
            latedata.Reset();
            datacheck.Reset();
            int datelimit = 3;

            latedata.Columns.Add(new DataColumn("id", typeof(int)));
            latedata.Columns.Add(new DataColumn("userid", typeof(int)));
            latedata.Columns.Add(new DataColumn("bookid", typeof(int)));
            latedata.Columns.Add(new DataColumn("date", typeof(string)));
            latedata.Columns.Add(new DataColumn("late", typeof(int)));

            DateTime now = DateTime.Now;
            now.ToString("dd/MM/yyyy");

            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select * from Loan", connection);
            adtr.Fill(datacheck);
            connection.Close();

            for (int i = 0; i < datacheck.Rows.Count; i++)

            {
                DateTime booktaken = DateTime.Parse(datacheck.Rows[i]["date"].ToString());
                booktaken.ToString("dd/MM/yyyy");
                if (now - booktaken > TimeSpan.FromDays(datelimit))
                {
                    latedata.Rows.Add(datacheck.Rows[i].ItemArray[0], datacheck.Rows[i].ItemArray[1], datacheck.Rows[i].ItemArray[2], datacheck.Rows[i].ItemArray[3], Math.Round((now - booktaken).TotalDays - datelimit));
                }
            }
            dataGridView2.DataSource = latedata;
            dataGridView2.Columns["late"].DefaultCellStyle.BackColor = Color.Red;

        }
        private void fillall()
        {
            daset.Reset();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Loan", connection);
            adtr.Fill(daset, "Loan");
            dataGridView1.DataSource = daset.Tables["Loan"];
            connection.Close();

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new Anasayfa().Show();
            this.Hide();
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Reset();
            string selected;
            connection.Open();
            SQLiteDataAdapter adtr;

            selected = "select *  from Kitap where id= " + dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();

            adtr = new SQLiteDataAdapter(selected, connection);
            dt.Reset();
            adtr.Fill(dt);

            txtBookName.Text = dt.Rows[0][1].ToString();
            txtAuthor.Text = dt.Rows[0][2].ToString();
            ////////////////////////////////////////////////////////////////////////////////////////////
            selected = "select *  from Uye where idnum= " + dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();

            adtr = new SQLiteDataAdapter(selected, connection);
            dt.Reset();
            adtr.Fill(dt);
            txtName.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
            txtIdNum.Text = dt.Rows[0][0].ToString();
            txtEmail.Text = dt.Rows[0][6].ToString();
            txtPhone.Text = dt.Rows[0][5].ToString();

            connection.Close();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataTable dt = new DataTable();
            string selected;
            connection.Open();


            selected = "select *  from Kitap where id= " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            SQLiteDataAdapter adtr = new SQLiteDataAdapter(selected, connection);
            dt.Reset();
            adtr.Fill(dt);

            textBox1.Text = dt.Rows[0][1].ToString();
            textBox2.Text = dt.Rows[0][2].ToString();

            ////////////////////////////////////////////////////////////////////////////////////////////

            selected = "select *  from Uye where idnum= " + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            adtr = new SQLiteDataAdapter(selected, connection);
            dt.Reset();
            adtr.Fill(dt);

            textBox6.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
            textBox3.Text = dt.Rows[0][0].ToString();
            textBox5.Text = dt.Rows[0][5].ToString();
            textBox4.Text = dt.Rows[0][6].ToString();

            connection.Close();

        }

        private void GetBackButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("delete from Loan where bookid=@bookid", connection);
            command.Parameters.AddWithValue("@bookid", dataGridView1.CurrentRow.Cells["bookid"].Value.ToString());
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("İade işlemi tamamlandı.");

            filllate();
            fillall();
            
        }

        private void LoanFollow_Click(object sender, EventArgs e)
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
