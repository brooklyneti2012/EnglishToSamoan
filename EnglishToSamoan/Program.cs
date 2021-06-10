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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to the Samoan tutorial");
            Console.WriteLine("Pick a number between 1 and 5 depending on your skill with the Samoan language, and then press enter to continue");

            int answer;
            int.TryParse(Console.ReadLine(), out answer);

            switch (answer)
            {
                case 5:
                    ();
                    break;
                case 4:
                   LVLFOUR L4 = new LVLFOUR();
                    break;
                case 3:
                    LVLTHREE L3 = new LVLTHREE();
                    break;
                case 2:
                    LVLTWO L2 = new LVLTWO();
                    break;
                case 1:
                    LVLONE L1 = new LVLONE();
                    break;
                    

            }
                

                Console.ReadKey();
                
            
            
        }
    }
}
