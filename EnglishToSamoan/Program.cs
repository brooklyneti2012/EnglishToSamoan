using System;
using System.Collections.Generic;
using System.Linq;

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
                Console.WriteLine("Welcome to level 1/5 of the Samoan tutorial");
                Console.WriteLine("In this tutorial you will be learning a simple conversation starter");
                Console.WriteLine("Press ENTER to continue");
                Console.ReadLine();
                Console.WriteLine("The greeting used most of is 'Talofa'(tah - loh - fah)");
                Console.WriteLine("An simple example of this greeting used in a sentence is...");
                Console.WriteLine("");
                Console.WriteLine("Talofa, my name is John.");
                Console.WriteLine("___________________________________________________________");
                Console.WriteLine("Press ENTER to continue to excercise");
                Console.ReadLine();
                Console.WriteLine("This time write the example sentence but with your name");
                Console.WriteLine("Talofa, my name is"); 
                string eg = Console.ReadLine();


                Console.ReadKey();
                
            }
            
        }
    }
}
