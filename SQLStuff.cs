using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plan_B
{
    public class Load
    {
        public static void Loads(Activity[] act, ref int i, ref int n)
        {
            string nam;
            string cat;
            DateTime deet;

            SqlConnection conn = new SqlConnection("Server = LAPTOP-3V8D68B7\\HADI ;Database=Plan B;Integrated Security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name, Category, DateTime FROM [dbo].[Planner]", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                nam = reader.GetString(0).TrimEnd();
                cat = reader.GetString(1).TrimEnd();
                deet = reader.GetDateTime(2);
                Console.WriteLine(nam + cat + Convert.ToString(deet));
                act[i] = new Activity(nam, cat, deet);
                i++;
                n++;
            }
            reader.Close();
            conn.Close();

        }

    }

    public class Delete
    {
        public static void Deletes()
        {
            SqlConnection conn = new SqlConnection("Server = LAPTOP-3V8D68B7\\HADI ;Database=Plan B;Integrated Security=true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM [Planner]", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
    
}
