using ClosedXML.Excel;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KütüphaneOtomosyon
{
    public partial class BookExport : Form
    {
        SQLiteConnection connection = new SQLiteConnection(@"Data Source=Database\KütüphaneOtomasyon.db; Version=3;");

        public BookExport()
        {
            InitializeComponent();
        }

        private void ExportBookButton_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("KİTAPLAR");
                ws.Range("A1:H1").Merge();
                ws.Range("A1:C1").Merge();
                ws.Cell(1, 1).Value = "Kütüphanedeki Kitaplar";
                ws.Cell(1, 1).Style.Font.Bold = true;
                ws.Cell(1, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                ws.Cell(1, 1).Style.Font.FontSize = 30;



                ws.Cell(4, 1).Value = "Kitap Id";
                ws.Cell(4, 2).Value = "Kitap Adı";
                ws.Cell(4, 3).Value = "Yazarı";
                ws.Cell(4, 4).Value = "Barkod No";
                ws.Cell(4, 5).Value = "Sayfa Sayısı";
                ws.Cell(4, 6).Value = "Kategori";
                ws.Cell(4, 7).Value = "Yayın Yılı";
                ws.Cell(4, 8).Value = "Stok";
                ws.Cell(4, 9).Value = "Cilt";
                ws.Range("A4:I4").Style.Fill.BackgroundColor = XLColor.Alizarin;

                //SQL connection

                DataTable dt = new DataTable();
                SQLiteCommand cmd = new SQLiteCommand();

                connection.Open();
                SQLiteDataReader dr = new SQLiteCommand("SELECT * FROM Kitap", connection).ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);
                connection.Close();
                int i = 5;

                foreach (DataRow row in dt.Rows)
                {
                    ws.Cell(i, 1).Value = row[0].ToString();
                    ws.Cell(i, 2).Value = row[1].ToString();
                    ws.Cell(i, 3).Value = row[2].ToString();
                    ws.Cell(i, 4).Value = row[3].ToString();
                    ws.Cell(i, 5).Value = row[4].ToString();
                    ws.Cell(i, 6).Value = row[5].ToString();
                    ws.Cell(i, 7).Value = row[6].ToString();
                    ws.Cell(i, 8).Value = row[7].ToString();
                    ws.Cell(i, 9).Value = row[8].ToString();
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
                saveFileDialog1.OverwritePrompt = true;
                saveFileDialog1.CreatePrompt = false;
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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt/csv files (*.txt/*.csv)|*.txt;*.csv|All files (*.*)|*.*"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time

            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                var lineNumber = 0;
                bool codebreak = false;
                using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=Database\KütüphaneOtomasyon.db; Version=3;"))
                {
                    conn.Open();
                    //Put your file location here:
                    using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                    {
                        while (!reader.EndOfStream && codebreak == false)
                        {
                            var line = reader.ReadLine();
                            if (lineNumber != 0)
                            {
                                var values = line.Split(',');

                                SQLiteCommand command = new SQLiteCommand("insert into Kitap(book, author, barkod, page,category, publish, stok, cilt) values(@book, @author, @barkod, @page,@category, @publish, @stok, @cilt)", conn);
                                command.Parameters.AddWithValue("@book", values[0]);
                                command.Parameters.AddWithValue("@author", values[1]);
                                command.Parameters.AddWithValue("@barkod", values[2]);
                                command.Parameters.AddWithValue("@page", values[3]);
                                command.Parameters.AddWithValue("@category", values[4]);
                                command.Parameters.AddWithValue("@publish", values[5]);
                                command.Parameters.AddWithValue("@stok", values[6]);
                                command.Parameters.AddWithValue("@cilt", values[7]);


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
                if (codebreak != true)
                {
                    MessageBox.Show("Aktarım tamamlandı.");
                }
            }
        }

        private void GoBackButton_Click_1(object sender, EventArgs e)
        {
            new Anasayfa().Show();
            this.Hide();
        }

    }
}
