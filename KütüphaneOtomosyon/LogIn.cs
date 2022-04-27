using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomosyon
{
    public partial class LogIn : Form
    {
       private Timer x = new Timer();
        public LogIn()
        {
            InitializeComponent();

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
            this.AcceptButton = LoginButton;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "vvelitkn" && txtUserPass.Text == "admin")
            {
                new Anasayfa().Show();
                this.Hide();
            }
            else
            {
                errorImg1.Visible = true;
                errorImg2.Visible = true;

                x.Interval = (3000);  //1 second = 1000
                x.Tick += new EventHandler(TimerTask);
                x.Start();

                txtUsername.Clear();
                txtUserPass.Clear();
                txtUsername.Focus();

            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtUserPass.Clear();
            txtUsername.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void TimerTask(object sender, EventArgs e)
        {
            errorImg1.Visible = false;
            errorImg2.Visible = false;
        }
    }
}
