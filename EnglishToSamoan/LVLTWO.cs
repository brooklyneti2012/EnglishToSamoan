using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLTWO
    {
        public LVLTWO()
        {

            Console.Clear();
            Console.WriteLine("Welcome to Leve 2/5 of the Samoan Tutorial");
            Console.WriteLine("We will be learning some ways of how to say 'Good' and 'Bad', and ways to say 'Sorry' and 'Please' in Samoan");
            Console.WriteLine("Press enter to continue.");
            string[] words;
            words = new string[] { "Lelei", "Manaia" };
            Console.WriteLine("Two ways to say 'Good' in Samoan is " + words[0] + " and " + words[1]);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("try typing Lelei.");
            Console.WriteLine("press enter when done typing");
            string good1 = Console.ReadLine();
            good1 = good1.ToLower();

            if (good1 == "lelei")
            {
                Console.Clear();
                Console.WriteLine("Nice job :), press enter to continue ");
            }
            else
            {
                Console.WriteLine("That is incorrect, press enter to try again.");
                Console.ReadLine();
                lelei();
            }

            static void lelei()
            {
                string good1 = Console.ReadLine();
                good1 = good1.ToLower();

                if (good1 == "lelei")
                {
                    Console.Clear();
                    Console.WriteLine("Nice job :), press enter to continue ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("That is incorrect, press enter to try again.");
                    Console.ReadLine();
                    lelei();
                }
            }

            Console.Clear();
            Console.WriteLine("The way that we say 'Bad' in Samoan");
        }
    }
}
