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

            //Finds and Uses the correct Database
            builder.DataSource = @"MADS-V-KLAUSEN\MSSQLSERVER01";
            //builder.DataSource = @"DESKTOP-CHHJASV\SQLEXPRESS";
            builder.InitialCatalog = "Lager(H1)";
            builder.IntegratedSecurity = true;

            //Opens the database's connection
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
            return connection;
        }
        static void Main(string[] args)
        {
            SqlConnection connection = Connection();

            //Assigns the keys from 1 to 6
            const ConsoleKey keyInfo1 = ConsoleKey.D1;
            const ConsoleKey keyInfo2 = ConsoleKey.D2;
            const ConsoleKey keyInfo3 = ConsoleKey.D3;
            const ConsoleKey keyInfo4 = ConsoleKey.D4;
            const ConsoleKey keyInfo5 = ConsoleKey.D5;
            const ConsoleKey keyInfo6 = ConsoleKey.D6;

            //While loops makes sure the menu's always stay open for continues use
            while (true)
            {
                //Clears the screen everytime it goes back to the menu after use
                Console.Clear();
                Console.ForegroundColor
                = ConsoleColor.DarkGray;
                Console.WriteLine("" +
                    "Press 1 :For Customer Management.\n" +
                    "Press 2 :For Item Management.\n" +
                    "Press 3 :To EXIT.\n");

                ConsoleKey pressedKey = PressedKey();

                // Gives the user the option to go to the desired place (Key 1-6)
                switch (pressedKey)
                {
                    case keyInfo1:
                        Console.ForegroundColor
                        = ConsoleColor.Blue;

                        switch (pressedKey)
                        {
                            // The Second menu
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
                                    //Gives the user the option to Insert a new customer to the database
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

                                    //Gives the user the option to Delete a customer from the database
                                    case keyInfo2:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        Console.WriteLine("Enter the Customer ID of the Customer you would like to Delete : \n\n");
                                        int CDelete = int.Parse(Console.ReadLine());
                                        Database.deleteCustomer(CDelete ,connection);
                                        break;

                                    //Gives the user the option to update a existing users credentiels
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

                                    //Gives the user the option to display all the current users in the database
                                    case keyInfo4:
                                        Console.ForegroundColor
                                        = ConsoleColor.Green;
                                        Console.WriteLine("All the current Customers :");
                                        Database.ShowCustomers(connection);
                                        break;

                                    //Gives the user the option to display specific users from the database
                                    case keyInfo5:
                                        Console.ForegroundColor
                                        = ConsoleColor.Green;
                                        Console.Write("What are you looking for? (Customer Name) > ");
                                        string Search = Console.ReadLine();
                                        Database.SearchCustomer(connection, Search);
                                        break;

                                    //Gives the user the option to go back a step (To the previous menu)
                                    case keyInfo6:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;
                                }
                                break;
                        }
                        break;

                        //The third menu
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
                                //Gives the user the option to Insert a new item into the Database
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

                                //Gives the user the option to Delete an item from the Database
                                case keyInfo2:
                                    Console.ForegroundColor
                                    = ConsoleColor.Blue;
                                    Console.WriteLine("Enter the item ID you want to Delete : \n\n");
                                    int IDelete = int.Parse(Console.ReadLine());
                                    Database.deleteItem(IDelete, connection);
                                    break;

                                //Gives the user the option to Update an item from the Database
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

                                //Gives the user the option to Display all the current items in the Database
                                case keyInfo4:
                                    Console.ForegroundColor
                                    = ConsoleColor.Green;
                                    Console.WriteLine("All the current Items in stock :");
                                    Database.ShowProducts(connection);
                                    break;

                                //Gives the user the option to Display specific items from the Database
                                case keyInfo5:
                                    Console.ForegroundColor
                                    = ConsoleColor.Green;
                                    Console.Write("What are you looking for? (Item Name) > ");
                                    string Search = Console.ReadLine();
                                    Database.SearchItem(connection, Search);
                                    break;

                                //Gives the user the option to go back a step (To the previous menu)
                                case keyInfo6:
                                    Console.ForegroundColor
                                    = ConsoleColor.Blue;
                                    break;
                            }
                            break;

                        //Terminates the program.
                        case keyInfo3:
                            Environment.Exit(0);
                            break;
                }
            }

            //Assigns the keys and continues the loop (Keeps asking for a pressed key)
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
