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


            /*string sqlInsert = @"INSERT INTO Customers (First_Name, Last_Name, Address, Zip_Code, City)
            VALUES ('Mads', 'Klausen', 'Ditlev Bergs vej 71,3,9', 9000, 'Aalborg')";
            connection.Open();
            SqlCommand command = new SqlCommand(sqlInsert, connection);
            command.ExecuteNonQuery();*/

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
                                        string sqlInsert = @"INSERT INTO Customers (First_Name, Last_Name, Address, Zip_Code, City)
                                        VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                                        connection.Open();
                                        SqlCommand command = new SqlCommand(sqlInsert, connection);
                                        command.ExecuteNonQuery();
                                        break;

                                    case keyInfo2:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;

                                    case keyInfo3:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;

                                    case keyInfo4:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;

                                    case keyInfo5:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;
                                }
                                /*Console.Write("Create New Customer > ");
                                string input = Console.ReadLine();
                                Console.Write("Enter the customer credentials > ");*/
                                string firstName = (Console.ReadLine());
                                string lastName = (Console.ReadLine());
                                string address = (Console.ReadLine());
                                int zip = (Console.Read());
                                string city = (Console.ReadLine());

                                SqlCommand customercommand = new SqlCommand();
                                customercommand.ExecuteNonQuery();
                                //Database.insertCusotmer(firstName, lastName, address, zip, city);
                                break;
                        }
                        /*Console.Write("Enter new message > ");
                        string input = Console.ReadLine();
                        Console.Write("What author ID is this message connected to? > ");

                        int messagesauthor = int.Parse(Console.ReadLine());
                        Database.insertMessage(input, messagesauthor);*/
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
                                        string sqlInsert = @"INSERT INTO Items (Item_Name, Item_Quantity, Item,Price, Item_Order_ID)
                                        VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                                        connection.Open();
                                        SqlCommand command = new SqlCommand(sqlInsert, connection);
                                        command.ExecuteNonQuery();
                                        break;

                                    case keyInfo2:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;

                                    case keyInfo3:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;

                                    case keyInfo4:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;

                                    case keyInfo5:
                                        Console.ForegroundColor
                                        = ConsoleColor.Blue;
                                        break;
                                }
                                /*Console.Write("Create New Customer > ");
                                string input = Console.ReadLine();
                                Console.Write("Enter the customer credentials > ");*/
                                string firstName = (Console.ReadLine());
                                string lastName = (Console.ReadLine());
                                string address = (Console.ReadLine());
                                int zip = (Console.Read());
                                string city = (Console.ReadLine());

                                SqlCommand customercommand = new SqlCommand();
                                customercommand.ExecuteNonQuery();
                                //Database.insertCusotmer(firstName, lastName, address, zip, city);
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
