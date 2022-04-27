using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ClosedXML.Excel;
using System.IO;

namespace KütüphaneOtomosyon
{

    public partial class ExportUser : Form
    {
        SQLiteConnection connection = new SQLiteConnection(@"Data Source=Database\KütüphaneOtomasyon.db; Version=3;");

        public ExportUser()
        {
            InitializeComponent();
        }

        private void ExportUserButton_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("ÜYELER");
                ws.Range("A1:h1").Merge();
                ws.Cell(1, 1).Value = "Kütüphane Üyeleri";
                ws.Cell(1, 1).Style.Font.Bold = true;
                ws.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell(1, 1).Style.Font.FontSize = 30;

                ws.Cell(4, 1).Value = "TC NO ";
                ws.Cell(4, 2).Value = "İsim";
                ws.Cell(4, 3).Value = "Soyisim";
                ws.Cell(4, 4).Value = "Yaş";
                ws.Cell(4, 5).Value = "Cinsiyet";
                ws.Cell(4, 6).Value = "Tel. No";
                ws.Cell(4, 7).Value = "Email";
                ws.Cell(4, 8).Value = "Okunmuş";
                ws.Range("A4:H4").Style.Fill.BackgroundColor = XLColor.Alizarin;

                //SQL connection

                DataTable dt = new DataTable();
                SQLiteCommand cmd = new SQLiteCommand();

                connection.Open();
                SQLiteDataReader dr = new SQLiteCommand("SELECT * FROM Uye", connection).ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                connection.Close();
                int i = 5;

                foreach (DataRow row in dt.Rows)
                {
                    ws.Cell(i, 1).Value = row[0].ToString();
                    ws.Cell(i, 2).Value = row[1].ToString();
                    ws.Cell(i, 3).Value = row[2].ToString(); ;
                    ws.Cell(i, 4).Value = row[3].ToString();
                    ws.Cell(i, 5).Value = row[4].ToString();
                    ws.Cell(i, 6).Value = row[5].ToString();
                    ws.Cell(i, 7).Value = row[6].ToString();
                    ws.Cell(i, 8).Value = row[7].ToString();
                    i++;
                }

                i--;
                ws.Cells("A4:H" + i).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                ws.Cells("A4:H" + i).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                ws.Cells("A4:H" + i).Style.Border.RightBorder = XLBorderStyleValues.Thin;
                ws.Cells("A4:H" + i).Style.Border.LeftBorder = XLBorderStyleValues.Thin;

                ws.Cells("A4:H" + i).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;


                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = @"C:\Users\%userprofile%\Documents\";      
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    FileInfo filename = new FileInfo(saveFileDialog1.FileName);

                    try
                    {
                        Stream excelStream = File.Create(saveFileDialog1.FileName);
                        workbook.SaveAs(excelStream);
                        excelStream.Dispose();

                    }
                    catch
                    {
                        MessageBox.Show(filename.Name + " dosyası başka bir uygulama üzerinde açık, lütfen kapatıp tekrar deneyiniz.");

                    }


                }


            }
        }

        private void buttonGetFile_Click(object sender, EventArgs e)
        {
            bool codebreak = false;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt/csv files (*.txt/*.csv)|*.txt;*.csv|All files (*.*)|*.*"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                var lineNumber = 0;
                using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=Database\KütüphaneOtomasyon.db; Version=3;"))
                {
                    conn.Open();
                    using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                        while (!reader.EndOfStream && codebreak == false)
                        {
                            var line = reader.ReadLine();
                            if (lineNumber != 0)
                            {
                                var values = line.Split(',');

                                SQLiteCommand command = new SQLiteCommand("insert into Uye(idnum,name, surname,age, gender,phone,email,totalread) values(@idnum,@name, @surname,@age,@gender,@phone,@email,@totalread)", conn);
                                command.Parameters.AddWithValue("@idnum", values[0]);
                                command.Parameters.AddWithValue("@name", values[1]);
                                command.Parameters.AddWithValue("@surname", values[2]);
                                command.Parameters.AddWithValue("@age", values[3]);
                                command.Parameters.AddWithValue("@gender", values[4]);
                                command.Parameters.AddWithValue("@phone", values[5]);
                                command.Parameters.AddWithValue("@email", values[6]);
                                command.Parameters.AddWithValue("@totalread", values[7]);

                                try
                                {
                                    command.ExecuteNonQuery();

                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show("Bir sorun var, admin'e ulaşın. Klasördeki Log dosyasını iletin.");
                                    string logname = "Log.txt";
                                    using (StreamWriter sr = new StreamWriter(Application.StartupPath + @"\Log\" + logname, true))
                                    {


                                        sr.WriteLine("=>" + DateTime.Now + "\n" + " An Error occurred: \n" + ex.StackTrace +
                " Message: " + ex.Message + "\n\n");
                                        sr.Flush();

                                    }
                                    codebreak = true;
                                }



                            }
                            lineNumber++;
                        }
                    }
                    conn.Close();
                }
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            new Anasayfa().Show();
            this.Hide();
        }
    }
}
