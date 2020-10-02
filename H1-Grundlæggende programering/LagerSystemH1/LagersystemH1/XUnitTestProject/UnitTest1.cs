using System;
using Xunit;
using LagersystemH1;
using System.Data.SqlClient;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SqlConnection connection = Program.Connection();
            Database DB = new Database();
            connection.Open();
            Assert.NotEqual("0 rows affected.\n", Database.insertCustomer("Mads", "Klausen", "Ditlev bergs vej", 9000, "Aalborg", connection));
        }
    }
}
