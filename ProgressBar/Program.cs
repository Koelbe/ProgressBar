using System;
using System.Threading;

namespace ProgressBar
{
    class Program0
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRESS BAR APP");
            Console.WriteLine("-------------------");

            //Console.Write("How many seconds should the progress bar take to load?");
            //int secondsToTakeLoading = int.Parse(Console.ReadLine());

            for (int percent = 0; percent <= 100; percent++)
                {
                    Thread.Sleep(100);
                    Console.Clear();
                Console.Write("{0}%", percent);
                for (int i = 1;i<=percent;i++) { Console.Write("-"); }
                }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("COMPLETED IN {0}",secondsToTakeLoading);
            Console.WriteLine("COMPLETED");
            Console.Read();
        }

       public void setDeltaTime() { }
    }
}
