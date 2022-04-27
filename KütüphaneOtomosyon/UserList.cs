using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KütüphaneOtomosyon
{
    public partial class UserList : Form
    {
        private Timer x = new Timer();
        public UserList()
        {
            InitializeComponent();
        }
        SQLiteConnection connection = new SQLiteConnection(@"Data Source=Database\KütüphaneOtomasyon.db; Version=3;");

        private void UserList_Load(object sender, EventArgs e)
        {
            userlist();

        }

        private void txtIdNum_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        DataSet daset = new DataSet();





        private void txtIdSearch_TextChanged(object sender, EventArgs e)
        {
            txtNameSearch.Clear();
            daset.Tables["Uye"].Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Uye where idnum like'%" + txtIdSearch.Text + "%'", connection);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            connection.Close();
        }
        private void userlist()
        {
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Uye", connection);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            connection.Close();

        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtIdNum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Female")
            {
                txtGender.SelectedIndex = 0;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Male")
            {
                txtGender.SelectedIndex = 1;
            }
            else if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "None")
            {
                txtGender.SelectedIndex = 3;
            }

            txtTotalRead.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void txtNameSearch_TextChanged_1(object sender, EventArgs e)
        {
            txtIdSearch.Clear();
            daset.Tables["Uye"].Clear();
            connection.Open();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Uye where name like'%" + txtNameSearch.Text + "%'", connection);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            connection.Close();
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
                    if (item.Name != "txtIdSearch" && item.Name != "txtNameSearch")
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
                SQLiteCommand command = new SQLiteCommand("update Uye set idnum=@idnum,name=@name, surname=@surname,age=@age, gender=@gender,phone=@phone,email=@email,totalread=@totalread WHERE idnum=@idnum", connection);
                command.Parameters.AddWithValue("@idnum", txtIdNum.Text);
                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@surname", txtSurname.Text);
                command.Parameters.AddWithValue("@age", int.Parse(txtAge.Text));
                command.Parameters.AddWithValue("@gender", txtGender.Text);
                command.Parameters.AddWithValue("@phone", txtPhone.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@totalread", int.Parse(txtTotalRead.Text));
                command.ExecuteNonQuery();
                connection.Close();
                daset.Tables["Uye"].Clear();
                connection.Open();
                SQLiteDataAdapter adtr = new SQLiteDataAdapter("select *from Uye where idnum like'%" + txtIdSearch.Text + "%'", connection);
                adtr.Fill(daset, "Uye");
                dataGridView1.DataSource = daset.Tables["Uye"];
                connection.Close();
                MessageBox.Show("Üye kaydı güncellendi.");
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
                    txtGender.SelectedIndex = -1;

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

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DataTable table1 = new DataTable();
            DialogResult dialog;
            dialog = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("delete from Uye where idnum=@idnum", connection);
                command.Parameters.AddWithValue("@idnum", dataGridView1.CurrentRow.Cells["idnum"].Value.ToString());
                command.ExecuteNonQuery();
                connection.Close();

                daset.Tables["Uye"].Clear();
                userlist();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        ;
                        txtGender.SelectedIndex = -1;

                    }
                }

                MessageBox.Show("Kullanıcı silindi.");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserList_Click(object sender, EventArgs e)
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
