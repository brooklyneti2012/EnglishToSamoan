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
                    retry();
                }

                static void retry ()
                {
                  Console.WriteLine("Try writing 'Talofa' yourself.");

                    string talofa = Console.ReadLine();

                    if (talofa == "talofa" && talofa == "TALOFA")
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
                        Console.WriteLine("PRESS ENTER TO TRY AGAIN");
                        retry();
                    }

                   
                    

                    
                }
                Console.WriteLine("The next word we will try to learn is Goodbye");
                Console.WriteLine("press any key to continue");
                Console.ReadLine();
                Console.WriteLine("The Samoan way to say Goodbye is 'Tofa' (toh - fah)");
                Console.WriteLine("Try typing Tofa yourself");

                string tofa = Console.ReadLine();

                if (tofa == "Tofa" && tofa == "tofa" && tofa == "TOFA")
                {
                    Console.WriteLine("Nice job our next word we will be learning is good morning");
                }
                else
                {
                    Console.WriteLine("Ooh, try again remeber the word is 'TOFA' ");
                    retry1();
                }
                static void retry1 ()
                {
                    string tofa = Console.ReadLine();

                    if (tofa == "Tofa" && tofa == "tofa" && tofa == "TOFA")
                    {
                        Console.WriteLine("Nice job our next words we will be learning is boy and girl");
                    }
                    else
                    {
                        Console.WriteLine("Ooh, try again remeber the word is 'TOFA' ");
                        retry1();
                    }
                }

                Console.WriteLine("The last words we will be learning in level one is 'TAMA and TEINE' which means boy and girl");
                Console.WriteLine("Tama means boy");
                Console.WriteLine("Teine means girl");
                Console.WriteLine("Press enter to continue to excercise");
                Console.ReadLine();
                Console.WriteLine("Try type 'Tama' yourself");

                string Tama = Console.ReadLine();

                if (Tama == "tama" && Tama == "Tama")
                {
                    Console.WriteLine("Congratulations, we will now move onto the end of tutorial quiz");
                }
                else
                {
                    Console.WriteLine("That is incorrect, try again");
                    tama();
                }

                static void tama ()
                {
                    string Tama = Console.ReadLine();

                    if (Tama == "tama" && Tama == "Tama")
                    {
                        Console.WriteLine("Congratulations, we will now move onto the end of tutorial quiz");
                    }
                    else
                    {
                        Console.WriteLine("That is incorrect, try again");
                        tama();
                    }
                }






                Console.ReadKey();
                
            }
            
        }
    }
}
