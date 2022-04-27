using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KütüphaneOtomosyon
{
    public partial class BookOpen : Form
    {
        private Timer x = new Timer();
        public BookOpen()
        {
            InitializeComponent();
        }
        SQLiteConnection connection = new SQLiteConnection(@"Data Source=Database\KütüphaneOtomasyon.db; Version=3;");

        private void BookOpen_Load(object sender, EventArgs e)
        {

        }

        private void KirapEkle_Click(object sender, EventArgs e)
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
                SQLiteCommand command = new SQLiteCommand("insert into Kitap(book, author, barkod, page,category, publish, stok, cilt) values(@book, @author, @barkod, @page,@category, @publish, @stok, @cilt)", connection);
                command.Parameters.AddWithValue("@book", txtBookName.Text);
                command.Parameters.AddWithValue("@author", txtAuthorName.Text);
                command.Parameters.AddWithValue("@barkod", txtBarkod.Text);
                command.Parameters.AddWithValue("@page", txtPage.Text);
                command.Parameters.AddWithValue("@category", txtCategory.Text);
                command.Parameters.AddWithValue("@publish", txtPublish.Text);
                command.Parameters.AddWithValue("@stok", txtStok.Text);
                command.Parameters.AddWithValue("@cilt", txtCiltno.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kitap kaydı tamamlandı.");
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
                    if (item != txtStok)
                    {
                        item.Text = "";
                    }
                    else item.Text = "0";

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

        private void CleanButton_Click(object sender, EventArgs e)
        {
            txtAuthorName.Clear();
            txtBarkod.Clear();
            txtBookName.Clear();
            txtCategory.SelectedIndex = -1;
            txtCiltno.Clear();
            txtPage.Clear();
            txtStok.Clear();
            txtPublish.Clear();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new Anasayfa().Show();
            this.Hide();
        }
    }
}
