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
            Console.WriteLine("Welcome to the Samoan tutorial");

            Console.WriteLine("Pick a number between 1 and 5 depending on your skill with the Samoan language");

            int answer;
            int.TryParse(Console.ReadLine(), out answer);

            switch (answer)
            {
                case 5:
                    FVE();
                    break;
                case 4:
                    FOUR();
                    break;
                case 3:
                    THREE();
                    break;
                case 2:
                    TWO();
                    break;
                case 1:
                    ONE();
                    break;
                    

            }
                
            static void FVE()
            {

            }

            static void FOUR()
            {

            }

            static void THREE()
            {

            }

            static void TWO()
            {
                
            }

            static void ONE()
            {
                //welcomes user to tutorial 1
                Console.WriteLine("Welcome to level 1/5 of the Samoan tutorial");
                Console.WriteLine("In this tutorial you will be learning simple Samoan words");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                Console.WriteLine("The greeting used most of is 'Talofa'(tah - loh - fah)");
                Console.WriteLine("");
                Console.WriteLine("Try writing 'Talofa' yourself.");
                string talofa = Console.ReadLine();

                if (talofa == "talofa")
                {
                    Console.WriteLine("Nice job we will now move onto the next word to learn.");   
                }
                else if (talofa == "Talofa")
                {
                    Console.WriteLine("Nice job we will now move onto the next word to learn.");
                }
                else
                {
                    Console.WriteLine("That is incorrect, try again.");
                }







                Console.ReadKey();
                
            }
            
        }
    }
}
