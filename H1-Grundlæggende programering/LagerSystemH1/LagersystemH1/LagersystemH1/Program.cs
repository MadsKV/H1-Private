using System;
using System.Data.SqlClient;
namespace LagersystemH1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder builder =
            new SqlConnectionStringBuilder();

            builder.DataSource = @"MADS-V-KLAUSEN\MSSQLSERVER01";
            builder.InitialCatalog = "Lager(H1)";
            builder.IntegratedSecurity = true;

            SqlConnection connection = new SqlConnection(builder.ConnectionString);


            string sqlInsert = @"INSERT INTO Customers (First_Name, Last_Name, Address, Zip_Code, City)
            VALUES ('Mads', 'Klausen', 'Ditlev Bergs vej 71,3,9', 9000, 'Aalborg')";
            connection.Open();
            SqlCommand command = new SqlCommand(sqlInsert, connection);
            command.ExecuteNonQuery();

        }
    }
}
