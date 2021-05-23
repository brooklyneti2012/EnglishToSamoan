using System;
using System.Collections.Generic;
using System.Linq;

namespace EnglishToSamoan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the English to Samoan translator");

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
            }
          
        }
    }
}
