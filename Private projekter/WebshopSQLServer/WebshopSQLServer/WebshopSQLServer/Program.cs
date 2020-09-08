using System;
using TECHCOOL;
namespace WebshopSQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLet.ConnectSqlServer("Webshop", @"MADS-V-KLAUSEN\MSSQLSERVER01");

            showBasket();
        }

        static void showBasket()
        {
            string[][] result = SQLet.GetArray("SELECT * FROM Basket");
            foreach (var row in result)
            {
                foreach (var field in row)
                {
                    Console.Write(field + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
