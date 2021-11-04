using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PaymentDB
{
    public class PayAppDAL
    {
        private readonly string _connectionString;

        public PayAppDAL():
            this(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BEZAODAL;Integrated Security=True;")
        {

        }

        public PayAppDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        private SqlConnection _sqlConnection = null;
        private void OpenConnection()
        {
            _sqlConnection = new SqlConnection { ConnectionString = _connectionString };
            _sqlConnection.Open();
        }
        private void CloseConnection()
        {
            if (_sqlConnection?.State != ConnectionState.Closed)
                _sqlConnection?.Close();
        }
        
    }
}
