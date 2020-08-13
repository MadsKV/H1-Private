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

            if (Console.ReadKey().Key == ConsoleKey.Enter) {

                Random r = new Random();
                int num = r.Next(1, 8);

                System.Threading.Thread.Sleep(num*1000);
                Console.WriteLine("O");
                SetTimer();

                DateTime startTid = DateTime.Now;
                Console.WriteLine("HURRY! Game Started at {0:HH:mm:ss.fff}", startTid);
                Console.ReadLine();

                DateTime slutTid = DateTime.Now;
                aTimer.Stop();
                aTimer.Dispose();
                Console.Clear();
                Console.WriteLine("HURRY! Game Started at {0:HH:mm:ss.fff}", startTid);
                Console.WriteLine("Woah your fast! Time passed {0:HH:mm:ss.fff}", slutTid);
                Console.WriteLine("\nWooah! \nThat was pretty Fast, want to try again or are you done for now? \nto start again press (Y) if not press (N) ");


                //Console.ReadKey().Key == ConsoleKey.Y;
                //Console.ReadKey().Key == ConsoleKey.N;
            }
            else
            {
                
                Console.WriteLine("Closing Game!"); 
            }
            
        }
        static void SetTimer()
        {
            aTimer = new System.Timers.Timer(10);
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
