using System;
using System.Data.SqlClient;
using Xunit;
namespace LagersystemH1
{
    public class Program
    {

        public static SqlConnection Connection()
        {
            SqlConnectionStringBuilder builder =
            new SqlConnectionStringBuilder();

            builder.DataSource = @"MADS-V-KLAUSEN\MSSQLSERVER01";
            //builder.DataSource = @"DESKTOP-CHHJASV\SQLEXPRESS";
            builder.InitialCatalog = "Lager(H1)";
            builder.IntegratedSecurity = true;

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            return connection;
        }
        static void Main(string[] args)
        {
            /*string sqlInsert = @"INSERT INTO Customers (First_Name, Last_Name, Address, Zip_Code, City)
            VALUES ('Mads', 'Klausen', 'Ditlev Bergs vej 71,3,9', 9000, 'Aalborg')";
            connection.Open();
            SqlCommand command = new SqlCommand(sqlInsert, connection);
            command.ExecuteNonQuery();*/
            SqlConnection connection = Connection();


            const ConsoleKey keyInfo1 = ConsoleKey.D1;
            const ConsoleKey keyInfo2 = ConsoleKey.D2;
            const ConsoleKey keyInfo3 = ConsoleKey.D3;
            const ConsoleKey keyInfo4 = ConsoleKey.D4;
            const ConsoleKey keyInfo5 = ConsoleKey.D5;

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor
                = ConsoleColor.DarkGray;
                Console.WriteLine("" +
                    "Press 1 :For Customer Management.\n" +
                    "Press 2 :For Item Management.\n" +
                    "Press 3 :To EXIT.\n");

                ConsoleKey pressedKey = PressedKey();

                switch (pressedKey)
                {
                    case keyInfo1:
                        Console.ForegroundColor
                        = ConsoleColor.Blue;

                        switch (pressedKey)
                        {
                            case keyInfo1:
                                Console.ForegroundColor
                                = ConsoleColor.Blue;
                                Console.Clear();
                                Console.WriteLine("" +
                                "Press 1 :To Create a new Customer account.\n" +
                                "Press 2 :To Delete a current Customer account.\n" +
                                "Press 3 :To Update a current Customer account.\n" +
                                "Press 4 :To View the current list of Customers.\n" +
                                "Press 5 :To EXIT.\n");

                                pressedKey = PressedKey();

                                switch (pressedKey)
                                {
                                    case keyInfo1:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.WriteLine("Enter the credentials of the customer in this format : \n\n" +
                                            ">First name, Last name, Address, Zip Code and their City<");
                                        string CInput = Console.ReadLine();
                                        string CInput2 = Console.ReadLine();
                                        string CInput3 = Console.ReadLine();
                                        int CInput4 = int.Parse(Console.ReadLine());
                                        string CInput5 = Console.ReadLine();
                                        Database.insertCustomer(CInput, CInput2, CInput3, CInput4, CInput5, connection);
                                        //string sqlInsertC = @"INSERT INTO Customers (First_Name, Last_Name, Address, Zip_Code, City)
                                        //VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                                        connection.Open();
                                        SqlCommand commandNC = new SqlCommand(CInput, connection);
                                        commandNC.ExecuteNonQuery();
                                        break;

                                    case keyInfo2:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.WriteLine("Enter the Customer ID of the Customer you would like to Delete : \n\n");
                                        string CDelete = Console.ReadLine();
                                        Database.deleteCustomer(CDelete ,connection);
                                        //string sqlDeleteC = @"DELETE FROM Customers WHERE Customer_ID = { 0 }";
                                        connection.Open();
                                        SqlCommand commandDC = new SqlCommand(CDelete, connection);
                                        commandDC.ExecuteNonQuery();
                                        break;

                                    case keyInfo3:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.WriteLine("Enter the Customer ID of the Customer you would like to Update : \n\n");
                                        string CUpdate = Console.ReadLine();
                                        Database.deleteCustomer(CUpdate, connection);
                                        //string sqlDeleteC = @"UPDATE Customer SET First_Name = '{1}', Last_Name = '{2}', Address = '{3}', Zip_Code = {4}, City = '{5}' WHERE Customer_ID = {0} ";
                                        connection.Open();
                                        SqlCommand commandUC = new SqlCommand(CUpdate, connection);
                                        commandUC.ExecuteNonQuery();
                                        break;

                                    case keyInfo4:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Database.SelectAllCustomers(connection);
                                        //string sqlDeleteC = @"SELECT * FROM Customer ORDER BY Customer_ID DESC";
                                        connection.Open();
                                        SqlCommand commandVC = new SqlCommand("Deap", connection);
                                        commandVC.ExecuteNonQuery();
                                        break;

                                    case keyInfo5:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;
                                }
                                break;
                        }
                        break;

                    case keyInfo2:
                        Console.ForegroundColor
                        = ConsoleColor.Blue;
                        Console.Clear();
                        Console.WriteLine("" +
                        "Press 1 :To Create a new Item.\n" +
                        "Press 2 :To Delete a current Item in stock.\n" +
                        "Press 3 :To Update a current Item in stock.\n" +
                        "Press 4 :To View the current list of Items in stock.\n" +
                        "Press 5 :To EXIT.\n");

                        pressedKey = PressedKey();

                        switch (pressedKey)
                        {
                            case keyInfo1:

                                switch (pressedKey)
                                {
                                    case keyInfo1:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.WriteLine("Enter the Information about the item in this format : \n\n" +
                                            ">Item name, Item quantity, Item price, Item Order date<");
                                        string IInput = Console.ReadLine();
                                        int IInput2 = int.Parse(Console.ReadLine());
                                        double IInput3 = double.Parse(Console.ReadLine());
                                        int IInput4 = int.Parse(Console.ReadLine());
                                        Database.insertItems(IInput, IInput2, IInput3, IInput4, connection);
                                        //string sqlInsert = @"INSERT INTO Items (Item_Name, Item_Quantity, Item,Price, Item_Order_ID)
                                        //VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                                        connection.Open();
                                        SqlCommand commandII = new SqlCommand(IInput, connection);
                                        commandII.ExecuteNonQuery();
                                        break;

                                    case keyInfo2:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.WriteLine("Enter the item ID you want to Delete : \n\n");
                                        string IDelete = Console.ReadLine();
                                        Database.deleteItem(IDelete, connection);
                                        //string sqlInsert = @"INSERT INTO Items (Item_Name, Item_Quantity, Item,Price, Item_Order_ID)
                                        //VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                                        connection.Open();
                                        SqlCommand commandID = new SqlCommand(IDelete, connection);
                                        commandID.ExecuteNonQuery();
                                        break;

                                    case keyInfo3:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.WriteLine("Enter the item ID you want to Update : \n\n");
                                        string IUpdate = Console.ReadLine();
                                        Database.deleteItem(IUpdate, connection);
                                        //string sqlInsert = @"INSERT INTO Items (Item_Name, Item_Quantity, Item,Price, Item_Order_ID)
                                        //VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                                        connection.Open();
                                        SqlCommand commandIU = new SqlCommand(IUpdate, connection);
                                        commandIU.ExecuteNonQuery();
                                        break;

                                    case keyInfo4:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Database.SelectAllItems(connection);
                                        connection.Open();
                                        SqlCommand commandIV = new SqlCommand("deap", connection);
                                        commandIV.ExecuteNonQuery();
                                        break;

                                    case keyInfo5:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;
                                }
                                break;
                        }
                        break;

                    case keyInfo3:
                        break;
                }
            }
            ConsoleKey PressedKey()
            {
                do
                {
                    while (!Console.KeyAvailable) ;
                    ConsoleKey pressed = Console.ReadKey(true).Key;
                    if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3 || pressed == keyInfo4 || pressed == keyInfo5)
                        return pressed;
                    Console.Clear();
                } while (true);
            }
        }
    }
}
