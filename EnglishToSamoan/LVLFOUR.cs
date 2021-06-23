using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLFOUR
    {
        public LVLFOUR()
        {
            Console.Title = "Level 4";
            Console.Clear();
            Console.WriteLine("Welcome to tutorial 4/5 of the Samoan Tutorials Point");
            Console.WriteLine("In this tutorial we will be learning about numbers 1 - 10");
            Console.WriteLine("After you have completed the tutorial you will be taking part in the 'End Of Tutorial Quiz'");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            tasi();

            static void tasi()
            {
                Console.Clear();
                Console.WriteLine("In the Samoan language, to say the number 'one' \nWe say 'Tasi' (Tah - See)");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

                static void ONE()
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Try typing 'tasi' yourself");
                    string one = Console.ReadLine();
                    one = one.ToLower();

                    if (one == "tasi")
                    {
                        Console.WriteLine("INPUT: " + one);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("That is correct :)");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is incorrect :(");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to try again");
                        ONE();
                    }
                }
            }
        }
    }
}
