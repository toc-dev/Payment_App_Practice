using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PaymentDB;

namespace PaymentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Log");
            Console.WriteLine("Reading the connection string");
            string dataProvider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.ConnectionStrings["ApplicationDB"].ConnectionString;
            var db = new PayAppDAL(connectionString);
        }
    }
}
