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
                Console.WriteLine("Welcome to the Samoan tutorial.");
                Console.WriteLine("You will be starting from the first tutorial and move onto the levels after once completing the tutorial.");
                Console.WriteLine("At the end of each tutorial you will be participating in the 'End Of Tutorial Quiz' to test your skills from the tutorial.");
                Console.WriteLine("And after completing the quiz you will move onto the next tutorial until you get to Tutorial 5 which is the final tutorial.");
                Console.WriteLine("You may now press enter to start with Tutorial 1.");
                string q = Console.ReadLine();
                if(q == "2")
                {
                    LVLTWO L2 = new LVLTWO();
                }
                LVLONE L1 = new LVLONE();
               
            }            
        }
    }
}
