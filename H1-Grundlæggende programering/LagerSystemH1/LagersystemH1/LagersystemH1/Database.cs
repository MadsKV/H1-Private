using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Xml.XPath;

namespace LagersystemH1
{
    class Database
    {
        //Insert a new customer into the database.
        public static string insertCustomer(string firstName, string lastName, string address, int zip, string city, SqlConnection connection)
        {
            try
            {

        string sql = @"
        INSERT INTO Customers (First_Name, Last_Name, Address, Zip_Code, City)
        VALUES ('{0}', '{1}', '{2}', {3}, '{4}')";
            string formatted = string.Format(sql, firstName, lastName, address, zip, city);
            SqlCommand command = new SqlCommand(formatted, connection);

        int numberOfRowAffected = command.ExecuteNonQuery();
        return numberOfRowAffected + "Rows was affected.\n";
            }
            catch(SqlException e)
            {
                Console.WriteLine("SQL exception caught in DeleteById " + e.ToString());
                return "0 rows affected.\n";
            }
        }
        //Insert a new Item into the database.
        public static void insertItems(string itemName, int itemQuantity, double itemPrice, int customerId, SqlConnection connection)
        {
            string sql = @"
        INSERT INTO Items (Item_Name, Item,Quantity, Item_Price, Customer_ID, Item_Order_Date)
        VALUES ('{0}', {1}, {2}, {3}, '{4}')";
            string formatted = string.Format(sql, itemName, itemQuantity, itemPrice, customerId, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            SqlCommand command = new SqlCommand(formatted, connection);
        }
        //Delete a specific Customer with the Customer_ID
        public static void deleteCustomer(string ID, SqlConnection connection)
        {
            string sql = @"
            DELETE FROM Customers WHERE Customer_ID = {0}";
            string formatted = string.Format(sql, ID);
            SqlCommand command = new SqlCommand(formatted, connection);
        }
        //Delete a specific item with the Item_ID
        public static void deleteItem(string ID, SqlConnection connection)
        {
            string sql = @"
            DELETE FROM Customers WHERE Item_ID = {0}";
            string formatted = string.Format(sql, ID);
            SqlCommand command = new SqlCommand(formatted, connection);
        }
        //Updates a current customers information
        public static void updateCustomer(string ID, string firstName, string lastName, string address, int zip, string city , SqlConnection connection)
        {
            string sql = @"
            UPDATE Customer SET First_Name = '{1}', Last_Name = '{2}', Address = '{3}', Zip_Code = {4}, City = '{5}' WHERE Customer_ID = {0} ";
            string formatted = string.Format(sql, ID, firstName, lastName, address, zip, city);
            SqlCommand command = new SqlCommand(formatted, connection);
        }
        //Updates a current items information
        public static void updateItem(string ID, string itemName, int itemQuantity, double itemPrice, int customerID, string itemOrderDate, SqlConnection connection)
        {
            string sql = @"
            UPDATE Items SET Item_Name = '{1}', Item_Quantity = {2}, Item_Price = {3}, Customer_ID = '{4}', Item_Order_Date = {5} WHERE Item_ID = {0} ";
            string formatted = string.Format(sql, ID, itemName, itemQuantity, itemPrice, customerID, itemOrderDate);
            SqlCommand command = new SqlCommand(formatted, connection);
        }
        //Displays a list of all current items in stock.
        public static void SelectAllItems(SqlConnection connection)
        {
            string sql = @"
            SELECT * FROM Items
            ORDER BY Item_ID DESC";
            string formatted = string.Format(sql);
            SqlCommand command = new SqlCommand(formatted, connection);
            
        }
        //Displays a list of all current customers.
        public static void SelectAllCustomers(SqlConnection connection)
        {
            string sql = @"
            SELECT * FROM Customers
            ORDER BY Customer_ID DESC";
            string formatted = string.Format(sql);
            SqlCommand command = new SqlCommand(formatted, connection);
        }
    }
}
