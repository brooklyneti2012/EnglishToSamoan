using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace EnglishToSamoan
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
            static void start()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                DateTime now = DateTime.Now;
                Console.WriteLine("You have started at " + now.ToString());
                Console.Title = "Samoan Tutorials Point";
                Console.WriteLine("Welcome to the Samoan tutorial");
                Console.WriteLine("Pick a number between 1 and 5 depending on your skill with the Samoan language, and then press enter to continue");

                int answer;
                int.TryParse(Console.ReadLine(), out answer);
                if (answer == 1)
                {
                    LVLONE L1 = new LVLONE();
                }
                else if(answer == 2)
                {
                    LVLTWO L2 = new LVLTWO();
                }
                else if (answer == 3)
                {
                    LVLTHREE L3 = new LVLTHREE();
                }
                else if (answer == 4)
                {
                    LVLFOUR L4 = new LVLFOUR();
                }
                else if (answer == 5)
                {
                    LVLFIVE L5 = new LVLFIVE();
                }
                else
                {
                    Console.WriteLine("That is an invalid input");
                    Console.WriteLine("Press enter to pick again");
                    Console.ReadLine();
                    start();
                }
            }
                

                Console.ReadKey();
                
            
            
        }
    }
}
