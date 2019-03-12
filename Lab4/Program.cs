using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4.Model;

using System.Data;
using System.Data.SQLite;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Lab4.Model.Student s = new Model.Student(1,"Lisans",
                "Ali","Male","ali@izu.edu.tr","9998665231");


            
            string connectionString = @"data source =C:\D\Projects\SMS.db";//050658655
            // Making call
            SQLiteConnection con = new SQLiteConnection(connectionString);
            // open the connection
            con.Open();

            string query = "Select * from Student";
            SQLiteCommand cmd = new SQLiteCommand(query,con);
            SQLiteDataAdapter ad = new SQLiteDataAdapter(cmd);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            if(dt.Rows.Count>0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Console.WriteLine(dt.Rows[i][0].ToString() + " " +
                        dt.Rows[i][1].ToString() + " " +
                        dt.Rows[i][2].ToString() + " " +
                        dt.Rows[i][3].ToString() + " " +
                        dt.Rows[i][4].ToString() + " " +
                        dt.Rows[i][5].ToString() );
                }
            }
            Console.ReadLine();
        }
    }
}
