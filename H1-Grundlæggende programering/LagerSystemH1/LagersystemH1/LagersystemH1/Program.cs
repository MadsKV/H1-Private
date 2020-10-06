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
            connection.Open();
            return connection;
        }
        static void Main(string[] args)
        {
            SqlConnection connection = Connection();

            const ConsoleKey keyInfo1 = ConsoleKey.D1;
            const ConsoleKey keyInfo2 = ConsoleKey.D2;
            const ConsoleKey keyInfo3 = ConsoleKey.D3;
            const ConsoleKey keyInfo4 = ConsoleKey.D4;
            const ConsoleKey keyInfo5 = ConsoleKey.D5;
            const ConsoleKey keyInfo6 = ConsoleKey.D6;

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
                                "Press 5 :To Search for a Customer. \n" +
                                "Press 6 :To EXIT.\n");

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
                                        break;

                                    case keyInfo2:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.WriteLine("Enter the Customer ID of the Customer you would like to Delete : \n\n");
                                        int CDelete = int.Parse(Console.ReadLine());
                                        Database.deleteCustomer(CDelete ,connection);
                                        break;

                                    case keyInfo3:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.Write("Enter the Customer ID of the Customer you would like to Update > ");
                                        int CUpdate = int.Parse(Console.ReadLine());
                                        Console.Write("Enter the First Name of the Customer > ");
                                        string CUpdate2 = Console.ReadLine();
                                        Console.Write("Enter the Last Name of the Customer > ");
                                        string CUpdate3 = Console.ReadLine();
                                        Console.Write("Enter the Address of the Customer > ");
                                        string CUpdate4 = Console.ReadLine();
                                        Console.Write("Enter the Zip Code of the Customer > ");
                                        int CUpdate5 = int.Parse(Console.ReadLine());
                                        Console.Write("Enter the City of the Customer > ");
                                        string CUpdate6 = Console.ReadLine();
                                        Database.updateCustomer(CUpdate, CUpdate2, CUpdate3, CUpdate4, CUpdate5, CUpdate6, connection);
                                        break;

                                    case keyInfo4:
                                        Console.ForegroundColor
                                        = ConsoleColor.Green;
                                        Console.WriteLine("All the current Customers :");
                                        Database.ShowCustomers(connection);
                                        break;

                                    case keyInfo5:
                                        Console.ForegroundColor
                                        = ConsoleColor.Green;
                                        Console.Write("What are you looking for? (Customer Name) > ");
                                        string Search = Console.ReadLine();
                                        Database.SearchCustomer(connection, Search);
                                        break;

                                    case keyInfo6:
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
                        "Press 5 :To Search for a Item.\n" +
                        "Press 6 :To EXIT.\n");

                        pressedKey = PressedKey();

                            switch (pressedKey)
                            {
                                case keyInfo1:
                                    Console.ForegroundColor
                                    = ConsoleColor.Blue;
                                    Console.WriteLine("Enter the Information about the item in this format : \n\n" +
                                        ">Item name, Item quantity, Item price<");
                                    string IInput = Console.ReadLine();
                                    int IInput2 = int.Parse(Console.ReadLine());
                                    double IInput3 = double.Parse(Console.ReadLine());
                                    Database.insertItems(IInput, IInput2, IInput3, connection);
                                    break;

                                case keyInfo2:
                                    Console.ForegroundColor
                                    = ConsoleColor.Blue;
                                    Console.WriteLine("Enter the item ID you want to Delete : \n\n");
                                    int IDelete = int.Parse(Console.ReadLine());
                                    Database.deleteItem(IDelete, connection);
                                    break;

                                case keyInfo3:
                                    Console.ForegroundColor
                                    = ConsoleColor.Blue;
                                    Console.Write("Enter the item ID you want to Update > ");
                                    int IUpdate = int.Parse(Console.ReadLine());
                                    Console.Write("Enter the item Name of the item > ");
                                    string IUpdate2 = Console.ReadLine();
                                    Console.Write("Enter the item Quantity of the item > ");
                                    int IUpdate3 = int.Parse(Console.ReadLine());
                                    Console.Write("Enter the item Price of the item > ");
                                    double IUpdate4 = double.Parse(Console.ReadLine());
                                    Database.updateItem(IUpdate, IUpdate2, IUpdate3, IUpdate4, connection);
                                    break;

                                case keyInfo4:
                                    Console.ForegroundColor
                                    = ConsoleColor.Green;
                                    Console.WriteLine("All the current Items in stock :");
                                    Database.ShowProducts(connection);
                                    break;

                                case keyInfo5:
                                    Console.ForegroundColor
                                    = ConsoleColor.Green;
                                    Console.Write("What are you looking for? (Item Name) > ");
                                    string Search = Console.ReadLine();
                                    Database.SearchItem(connection, Search);
                                    break;

                                case keyInfo6:
                                    Console.ForegroundColor
                                    = ConsoleColor.Blue;
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
                    if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3 || pressed == keyInfo4 || pressed == keyInfo5 || pressed == keyInfo6)
                        return pressed;
                    Console.Clear();
                } while (true);
            }
        }
    }
}
