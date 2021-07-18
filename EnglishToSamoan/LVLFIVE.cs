using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLFIVE
    {
        public LVLFIVE()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the FINAL tutorial for the Samoan Tutorials Point.");
            Console.WriteLine("In this tutorial you will learn how to say the words...");
            Console.WriteLine("Big");
            Console.WriteLine("Small");
            Console.WriteLine("Wide");
            Console.WriteLine("Skinny");
            Console.WriteLine("Tall");
            Console.WriteLine("Short.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            BIG();

            static void BIG()
            {
                Console.Clear();
                Console.WriteLine("In Samoan, to say the word 'Big' we say. \n 'Lapo'a'");
                Console.WriteLine("Pronounciation: Lah - poh - ah");
                Console.WriteLine("Try typing 'Lapo'a' yourself.");
                string big = Console.ReadLine();
                big = big.ToLower();

                if (big == "lapo'a" || big == "lapoa")
                {
                    Console.Clear();
                    Console.WriteLine("INPUT: " + big);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nice job, Press enter to continue.");
                    Console.ResetColor();
                    Console.ReadLine();
                    smol();
                }
                else if (big != "lapo'a" || big != "lapoa")
                {
                    Console.Clear();
                    Console.WriteLine("INPUT: " + big);
                    Console.WriteLine("That is incorrect. Press enter to try again");
                    Console.ReadLine();
                    BIG();
                }    
            }
            static void smol()
            {
                Console.Clear();
                Console.WriteLine("In Samoan, to say the word 'Small.'");
                Console.WriteLine("");
            }
        }
    }
}
