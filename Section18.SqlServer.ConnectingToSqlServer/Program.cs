
using System;
using System.Data;
using System.Data.SqlClient;

namespace Section18.SqlServer.ConnectingToSqlServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NETBeginnerBootCamp;Data Source=."))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Student",connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Console.WriteLine($"Student ID: {dataSet.Tables[0].Rows[i]["Id"]}, Student Name: {dataSet.Tables[0].Rows[i]["StudentName"]}");
                }
                SqlCommand command = new SqlCommand("UpdateStudentName");
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentId", 1);
                command.Parameters.AddWithValue("@StudentName", "Update from C#");
                command.ExecuteNonQuery();
            }

            Console.ReadLine();
        }
    }
}
