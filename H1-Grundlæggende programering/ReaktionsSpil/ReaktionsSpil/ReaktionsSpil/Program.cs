using System;
using System.Timers;

namespace ReaktionsSpil
{
    class Program
    {
        private static System.Timers.Timer aTimer;
        static void Main(string[] args)
        {
            Console.WriteLine("When you see an 'O', press Enter as fast as possible!");
            Console.WriteLine("Press 'Enter' to start the game!");
            Console.WriteLine("---------------------------------------------------------");
            {
                bool restartGame = false;
                do
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Console.WriteLine("Game Started press C to restart when finished!");
                        Random r = new Random();
                        int num = r.Next(1, 8);

                        System.Threading.Thread.Sleep(num * 1000);

                        Console.WriteLine(" -");
                        Console.WriteLine("|O|");
                        Console.WriteLine(" -");

                        SetTimer();

                        DateTime startTid = DateTime.Now;
                        Console.WriteLine("HURRY! Game Started at {0:HH:mm:ss.fff}", startTid);

                        if (Console.ReadKey().Key == ConsoleKey.C)
                        {
                            aTimer.Stop();
                            aTimer.Dispose();
                            Console.Clear();
                            DateTime slutTid = DateTime.Now;
                            Console.WriteLine("Fast Enough? Game Started at {0:HH:mm:ss.fff}", startTid);
                            Console.WriteLine("Woah your fast! Time from start to end {0:HH:mm:ss.fff}", slutTid);


                            Console.WriteLine("---------------------------------------------------------");
                            TimeSpan duration = startTid - slutTid;
                            Console.WriteLine("\nFrom start to end you spent " + duration);
                            Console.WriteLine("---------------------------------------------------------");
                            Console.WriteLine("\nWooah! \nThat was pretty Fast, want to try again or are you done for now? \nto start again press (ENTER) or press ANY other key to exit");
                            Console.WriteLine("---------------------------------------------------------");
                        }
                    }


                    //Console.ReadKey().Key == ConsoleKey.Y;
                    //Console.ReadKey().Key == ConsoleKey.N;

                    else
                    {
                        Console.WriteLine("\nClosing Game!");
                        Environment.Exit(0);
                    }
                } while (restartGame != true);
            }

        }
        static void SetTimer()
        {
            aTimer = new System.Timers.Timer(10000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Timer elapsed at {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }

}
