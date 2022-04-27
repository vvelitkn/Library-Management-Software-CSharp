using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KütüphaneOtomosyon
{

    public partial class UserAdd : Form
    {
        private Timer x = new Timer();
        public UserAdd()
        {
            InitializeComponent();
        }
        SQLiteConnection connection = new SQLiteConnection(@"Data Source=Database\KütüphaneOtomasyon.db; Version=3;");

        private void ÜyeEkle_Click(object sender, EventArgs e)
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

                    if (item.Text == "")
                    {
                        imgArray[i].Visible = true;
                        //  Console.WriteLine(item.Name + " " +  "i: "+i+ " j: "+ j);
                        j++;
                    }
                    i++;
                }
            }


            if (j == 0)
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("insert into Uye(idnum,name, surname,age, gender,phone,email,totalread) values(@idnum,@name, @surname,@age,@gender,@phone,@email,@totalread)", connection);
                command.Parameters.AddWithValue("@idnum", txtIdNum.Text);
                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@surname", txtSurname.Text);
                command.Parameters.AddWithValue("@age", txtAge.Text);
                command.Parameters.AddWithValue("@gender", txtGender.Text);
                command.Parameters.AddWithValue("@phone", txtPhone.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);
                command.Parameters.AddWithValue("@totalread", txtTotalRead.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Üye kaydı tamamlandı.");
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
                    if (item != txtTotalRead)
                    {
                        item.Text = "";
                    }
                    else item.Text = "0";

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

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new Anasayfa().Show();
            this.Hide();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
