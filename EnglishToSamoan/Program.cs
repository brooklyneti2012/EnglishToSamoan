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
                Console.WriteLine("You will be starting from the first tutorial and move onto\nthe levels after once completing the tutorial.");
                Console.WriteLine("At the end of each tutorial you will be participating in the\n'End Of Tutorial Quiz' to test your skills from the tutorial.");
                Console.WriteLine("And after completing the quiz you will move onto the next\ntutorial until you get to Tutorial 5 which is the final tutorial.");
                Console.WriteLine("After the final tutorial you will be granted 'THE SAMOAN BASIC WORDS CROWN'");
                Console.WriteLine("Also at the end of each quiz you may choose to leave the Samoan Tutorials point");
                Console.WriteLine("Or to stay and carry on with the next tutorial.");
                Console.WriteLine("");
                Console.WriteLine("You may now press enter to start with Tutorial 1.");
                string q = Console.ReadLine();
                if(q == "3")
                {
                    LVLTHREE L2 = new LVLTHREE();
                }
                LVLONE L1 = new LVLONE();
               
            }            
        }
    }
}
