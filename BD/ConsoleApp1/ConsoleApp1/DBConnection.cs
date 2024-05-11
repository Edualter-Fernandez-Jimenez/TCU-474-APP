using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DBConnection
    {

        string connectionString = "Persist Security Info=False;Integrated Security=true;Initial Catalog = Demo; Server=DESKTOP-C962NTH;TrustServerCertificate=true;";



        public void InsertData(string table, int id, string name)
        {
            Console.WriteLine(id +" " + name);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO dbo." + table + " (Id_" + table + ", Nombre) VALUES (" + id + ", '" + name + "');", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
