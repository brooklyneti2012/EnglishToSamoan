using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLTWO
    {
        public LVLTWO()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();
            Console.WriteLine("Welcome to Leve 2/5 of the Samoan Tutorial");
            Console.WriteLine("We will be learning some ways of how to say 'Good' and 'Bad', and ways to say 'Sorry' and 'Please' in Samoan");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            string[] words;
            words = new string[] { "Lelei", "Manaia" };
            Console.WriteLine("Two ways to say 'Good' in Samoan is " + words[0] + " (Leh - Lay) and " + words[1] + " (Mah - Neye - Ya)");
            Console.WriteLine("Press enter to continue.");
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
                Console.WriteLine("try typing Lelei.");
                Console.WriteLine("press enter when done typing");
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
            Console.WriteLine("The way that we say 'Bad' in Samoan is 'Leaga' (Leh - ya - nga)");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            static void ain()
            {
                
                Console.Clear();
                Console.WriteLine("Try typing 'Leaga' yourself");
                string leaga = Console.ReadLine().ToLower();
                

                
                string spaces = " that is correct press enter to continue";
                for (int i = 0; i < leaga.Length; i++)
                {
                    if (leaga == "leaga")
                    {
                        Console.WriteLine("That is correct");
                    }
                    else
                    {
                        Console.WriteLine("That is incorrect, press enter to try again");
                        Console.ReadLine();
                        ain();
                    }
                }
                Console.WriteLine("LEAGA =" + spaces);
                Console.ReadLine();
                Q3();
            }
            static void Q3()
            {
                Console.WriteLine("You will now learn how to say please");
                Console.WriteLine("Please in Samoan is 'Fa'amolemole' (Fah - ah - moh - leh - moh - leh)");
                Console.WriteLine("press any key to continue");
                Console.ReadKey();
            }
        }

          
    }
}

