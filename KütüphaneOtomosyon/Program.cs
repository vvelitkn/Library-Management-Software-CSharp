using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace KütüphaneOtomosyon
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

          //DataImport();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }


        private static  void  DataImport()
        {

            var lineNumber = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=VELI-PC;Initial Catalog = KütüphaneOtomasyon; Integrated Security= true"))
            {
                conn.Open();
                //Put your file location here:
                using (StreamReader reader = new StreamReader(@"C:\Users\vveli\Downloads\MOCK_DATA.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (lineNumber != 0)
                        {
                            var values = line.Split(',');

                            SqlCommand command = new SqlCommand("insert into Uye(idnum,name, surname,age, gender,phone,email,totalread) values(@idnum,@name, @surname,@age,@gender,@phone,@email,@totalread)", conn);
                            command.Parameters.AddWithValue("@idnum", values[0]);
                            command.Parameters.AddWithValue("@name", values[1]);
                            command.Parameters.AddWithValue("@surname", values[2]);
                            command.Parameters.AddWithValue("@age", values[3]);
                            command.Parameters.AddWithValue("@gender", values[4]);
                            command.Parameters.AddWithValue("@phone", values[5]);
                            command.Parameters.AddWithValue("@email", values[6]);
                            command.Parameters.AddWithValue("@totalread", values[7]);
                            command.ExecuteNonQuery();
                        }
                        lineNumber++;
                    }
                }
                conn.Close();
            }


        }
    }
}
