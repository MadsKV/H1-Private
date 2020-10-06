using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Net.Sockets;
using System.Xml.XPath;

namespace LagersystemH1
{
    public class Database
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
                Console.ReadLine();
                return "0 rows affected.\n";
            }
        }
        //Insert a new Item into the database.
        public static void insertItems(string itemName, int itemQuantity, double itemPrice, SqlConnection connection)
        {
            string sql = @"
        INSERT INTO Items (Item_Name, Item_Quantity, Item_Price)
        VALUES ('{0}', {1}, {2})";
            string formatted = string.Format(sql, itemName, itemQuantity, itemPrice);
            SqlCommand command = new SqlCommand(formatted, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }
        }
        //Delete a specific Customer with the Customer_ID
        public static void deleteCustomer(int ID, SqlConnection connection)
        {
            string sql = @"
            DELETE FROM Customers WHERE Customer_ID = {0}";
            string formatted = string.Format(sql, ID);
            SqlCommand command = new SqlCommand(formatted, connection);
            command.ExecuteNonQuery();
        }
        //Delete a specific item with the Item_ID
        public static void deleteItem(int ID, SqlConnection connection)
        {
            string sql = @"
            DELETE FROM Items WHERE Item_ID = {0}";
            string formatted = string.Format(sql, ID);
            SqlCommand command = new SqlCommand(formatted, connection);
            command.ExecuteNonQuery();
        }
        //Updates a current customers information
        public static void updateCustomer(int ID, string firstName, string lastName, string address, int zip, string city , SqlConnection connection)
        {
            string sql = @"
            UPDATE Customers SET First_Name = '{1}', Last_Name = '{2}', Address = '{3}', Zip_Code = {4}, City = '{5}' WHERE Customer_ID = {0} ";
            string formatted = string.Format(sql, ID, firstName, lastName, address, zip, city);
            SqlCommand command = new SqlCommand(formatted, connection);
            command.ExecuteNonQuery();
        }
        //Updates a current items information
        public static void updateItem(int ID, string itemName, int itemQuantity, double itemPrice, SqlConnection connection)
        {
            string sql = @"
            UPDATE Items SET Item_Name = '{1}', Item_Quantity = {2}, Item_Price = {3} WHERE Item_ID = {0} ";
            string formatted = string.Format(sql, ID, itemName, itemQuantity, itemPrice);
            SqlCommand command = new SqlCommand(formatted, connection);
            command.ExecuteNonQuery();
        }
        //Displays a list of all current items in stock.
        public static void SelectAllItems(SqlConnection connection)
        {
            string sql = @"
            SELECT * FROM Items
            ORDER BY Item_ID DESC";
            string formatted = string.Format(sql);
            SqlCommand command = new SqlCommand(formatted, connection);
            command.ExecuteNonQuery();
            Console.WriteLine(formatted);
            Console.ReadLine();

        }
        //Displays a list of all current customers.
        public static void SelectAllCustomers(SqlConnection connection)
        {
            string sql = @"
            SELECT * FROM Customers
            ORDER BY Customer_ID DESC";
            string formatted = string.Format(sql);
            SqlCommand command = new SqlCommand(formatted, connection);
            command.ExecuteNonQuery();
            Console.WriteLine(formatted);
            Console.ReadLine();
        }
        public static void ShowProducts(SqlConnection conn)
        {
            string SQL = (@"SELECT Item_ID, Item_Name, Item_Quantity, Item_Price FROM Items");
                          //left join SubCategories on Products.ProductSubCategoryID=SubCategories.SubCategoryID
                          //left join Employees on Products.ProductEmployeeID=Employees.EmployeeID");
            SqlCommand command = new SqlCommand(SQL, conn);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15}", sdr[0], sdr[1], sdr[2], sdr[3]);
            }
            Console.ReadKey();
            sdr.Close();
        }
        public static void ShowCustomers(SqlConnection conn)
        {
            string SQL = (@"SELECT Customer_ID, First_Name, Last_Name, Address, Zip_Code, City FROM Customers");
            //left join SubCategories on Products.ProductSubCategoryID=SubCategories.SubCategoryID
            //left join Employees on Products.ProductEmployeeID=Employees.EmployeeID");
            SqlCommand command = new SqlCommand(SQL, conn);
            SqlDataReader sdr = command.ExecuteReader();
            while (sdr.Read())
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-10} {3,-15} {4,-15} {5,-15}", sdr[0], sdr[1], sdr[2], sdr[3], sdr[4], sdr[5]);
            }
            Console.ReadKey();
            sdr.Close();
        }
    }
}
