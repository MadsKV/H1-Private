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

            builder.DataSource = @"MADS - V - KLAUSEN\MSSQLSERVER";
            builder.InitialCatalog = "Lager(H1)";
            builder.IntegratedSecurity = true;

            SqlConnection Connection = new SqlConnection(builder.ConnectionString);
        }
    }
}
