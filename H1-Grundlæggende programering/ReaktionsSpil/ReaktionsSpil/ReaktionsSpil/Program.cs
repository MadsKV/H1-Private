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
                //SetTimer();

                Console.WriteLine("HURRY! Game Started at {0:HH:mm:ss.fff}", DateTime.Now);
                Console.ReadLine();
                aTimer.Stop();
                aTimer.Dispose();
            }
            else
            {
               Console.WriteLine("Closing Game!"); 
            }
        }
        ////static void SetTimer()
        //{
        //    aTimer = new System.Timers.Timer(10);
        //    aTimer.Elapsed += OnTimedEvent;
        //    aTimer.AutoReset = true;
        //    aTimer.Enabled = true;
        //}

        //static void OnTimedEvent(object source, ElapsedEventArgs e)
        //{
        //    Console.WriteLine("Timer elapsed at {0:HH:mm:ss.fff}", e.SignalTime);
        //}
    }
    
}
