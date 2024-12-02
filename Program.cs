using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSqlConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person6 = new Person();
            person6.Name = "Rob";
            person6.Surname = "Gabe";

            string connString = "Data Source=Room5320\\SQLEXPRESS; Initial Catalog=Trial; Integrated Security=True";
            // string retrieveQuery = "select top 3 * from People";
            string insertQuery = "insert into People (name, surname) values (@name, @sname)";

            using (SqlConnection connect = new SqlConnection(connString))
            {
                connect.Execute(insertQuery, new { name = person6.Name, sname = person6.Surname });
                
            }
        }
    }
}
