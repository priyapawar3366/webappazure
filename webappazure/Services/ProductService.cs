using System.Data.SqlClient;
using webappazure.Model;

namespace webappazure.Services
{
    public class ProductService
    {
        private static string db_source = "sqldemo3366.database.windows.net";
        private static string db_user = "sql";
        private static string db_password = "demouser@1234";
        private static string db_database = "demodb";

        private SqlConnection GetConnection()
        {

            var _builder = new SqlConnectionStringBuilder();
            _builder.DataSource = db_source;
            _builder.UserID = db_user;
            _builder.Password = db_password;
            _builder.InitialCatalog = db_database;
            return new SqlConnection(_builder.ConnectionString);
        }

        public List<Products> GetProducts()
        {
            List<Products> _product_lst = new List<Products>();
            string _statement = "SELECT ProductID,ProductName,Quantity from Products";
            SqlConnection _connection = GetConnection();

            _connection.Open();

            SqlCommand _sqlcommand = new SqlCommand(_statement, _connection);

            using (SqlDataReader _reader = _sqlcommand.ExecuteReader())
            {
                while (_reader.Read())
                {
                    Products _product = new Products()
                    {
                        ProductID = _reader.GetInt32(0),
                        ProductName = _reader.GetString(1),
                        Quantity = _reader.GetInt32(2)
                    };

                    _product_lst.Add(_product);
                }
            }
            _connection.Close();
            return _product_lst;
        }

    }
}
