using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Net.Sockets;

namespace LagersystemH1
{
    class Database
    {
        //Insert a new customer into the database.
        public static void insertCusotmer(string firstName, string lastName, string address, int zip, string city, SqlConnection connection)
        {
        string sql = @"
        INSERT INTO Customers (First_Name, Last_Name, Address, Zip_Code, City)
        VALUES ('{0}', '{1}', '{2}', {3}, '{4}')";
        string formatted = string.Format(sql, firstName, lastName, address, zip, city);
        //Console.WriteLine(formatted);
        SqlCommand command = new SqlCommand(formatted, connection);
        }
        //Insert a new Item into the database.
        public static void insertItems(string itemName, int itemQuantity, double itemPrice, int customerId, SqlConnection connection)
        {
            string sql = @"
        INSERT INTO Items (Item_Name, Item,Quantity, Item_Price, Customer_ID, Item_Order_Date)
        VALUES ('{0}', {1}, {2}, {3}, '{4}')";
            string formatted = string.Format(sql, itemName, itemQuantity, itemPrice, customerId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            //Console.WriteLine(formatted);
            SqlCommand command = new SqlCommand(formatted, connection);
        }
        //Delete a specific Customer with the Customer_ID
        public static void deleteCustomer(string ID, SqlConnection connection)
        {
            string sql = @"
            DELETE FROM Customers WHERE Customer_ID = {0}";
            string formatted = string.Format(sql, ID);
            //Console.WriteLine(formatted);
            SqlCommand command = new SqlCommand(formatted, connection);
        }
        //Delete a specific item with the Item_ID
        public static void deleteItem(string ID, SqlConnection connection)
        {
            string sql = @"
            DELETE FROM Customers WHERE Item_ID = {0}";
            string formatted = string.Format(sql, ID);
            //Console.WriteLine(formatted);
            SqlCommand command = new SqlCommand(formatted, connection);
        }
        //Updates a current customers information
        public static void updateCustomer(string ID, string firstName, string lastName, string address, int zip, string city , SqlConnection connection)
        {
            string sql = @"
            UPDATE Customer SET First_Name = '{1}', Last_Name = '{2}', Address = '{3}', Zip_Code = {4}, City = '{5}' WHERE Customer_ID = {0} ";
            string formatted = string.Format(sql, ID, firstName, lastName, address, zip, city);
            //Console.WriteLine(formatted);
            SqlCommand command = new SqlCommand(formatted, connection);
        }
        //Updates a current customers information
        public static void updateItem(string ID, string Message, SqlConnection connection)
        {
            string sql = @"
            UPDATE Items SET First_Name = '{1}', Last_Name = '{2}', Address = '{3}', Zip_Code = {4}, City = '{5}' WHERE Customer_ID = {0} ";
            string formatted = string.Format(sql, ID, firstName, lastName, address, zip, city);
            //Console.WriteLine(formatted);
            SqlCommand command = new SqlCommand(formatted, connection);
        }
    }
}
