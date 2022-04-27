using ClosedXML.Excel;
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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UserAdd_Click(object sender, EventArgs e)
        {
            new UserAdd().Show();
            this.Hide();
        }

        private void UserList_Click(object sender, EventArgs e)
        {
            new UserList().Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void UserExport_Click(object sender, EventArgs e)
        {
            new ExportUser().Show();
            this.Hide();
        }

        private void BookAdd_Click(object sender, EventArgs e)
        {
            new BookOpen().Show();
            this.Hide();
        }

        private void BookList_Click(object sender, EventArgs e)
        {
            new BookList().Show();
            this.Hide();
        }

        private void BookExport_Click(object sender, EventArgs e)
        {
            new BookExport().Show();
            this.Hide();
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            new LoanBook().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new ModernScreen().Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void BorrowFollow_Click(object sender, EventArgs e)
        {
            new LoanFollow().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new About().Show();
        }
    }
}
