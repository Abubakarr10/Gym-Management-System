using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Step 1
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Homepage
{
    class SQLconnection
    {
        public static SqlConnection Connection()
        {
            // Connection String
            string str = @"Data Source=ABUBAKAR\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True;";

            // SqlConnection --> Object Create
            SqlConnection connection = new SqlConnection(str);

            try
            {
                // Connection-->Open()
                connection.Open();
               // MessageBox.Show("Connected Successfully ...");
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection to DB Failed!!!");
            }

            // Return Connection
            return connection;
        }


        //Add Record
        public static void AddRecord(string GymNo, string MemberName)
        {


        }




    }
}
