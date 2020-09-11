using System;

namespace Objekter_know_how
{
    class Program
    {

        //Punkt_i_2D p1 = new Punkt_i_2D(5, 3);
        //Punkt_i_2D p2 = new Punkt_i_2D(7, 10);
        //Console.WriteLine(p1.Distance(p2));

        static void Main(string[] args)
        {

            const ConsoleKey keyInfo1 = ConsoleKey.D1;
            const ConsoleKey keyInfo2 = ConsoleKey.D2;
            const ConsoleKey keyInfo3 = ConsoleKey.D3;
            Console.ForegroundColor =
                ConsoleColor.Blue;
            Bank_account Mads = new Bank_account(3000);

            Console.Write("Welcome to the ¨Bank of Coding¨ \n" +
                          "You're bank balance is: ");
            Mads.Print();

            Console.WriteLine("\nPress 1: Withdraw.\n" +
                              "Press 2: Deposit.\n" +
                              "Press 3: Show balance\n");

            ConsoleKey pressedKey = PressedKey();

            switch (pressedKey)
            {
                case keyInfo1:
                    Console.Write("How much do you want to withdraw > ");
                    double moneyWithdrawn = double.Parse(Console.ReadLine());
                    try
                    { 
                        Console.WriteLine();
                        Console.WriteLine(Mads.Withdraw(moneyWithdrawn));                     
                    }
                    catch (Exception Error)
                    {
                        Console.WriteLine(Error);
                    }
                    break;

                case keyInfo2:
                    Console.Write("How much do you want to deposit > ");
                    double moneyDeposit = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(Mads.Deposit(moneyDeposit));
                    break;

                case keyInfo3:
                    Mads.Print();
                    break;
            }

            ConsoleKey PressedKey()
            {
                do
                {
                    while (!Console.KeyAvailable) ;
                    ConsoleKey pressed = Console.ReadKey(true).Key;
                    if (pressed == keyInfo1 || pressed == keyInfo2 || pressed == keyInfo3)
                        return pressed;
                    Console.Clear();
                } while (true);

            }
        }
    }
}
