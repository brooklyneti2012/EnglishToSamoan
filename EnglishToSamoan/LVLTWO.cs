using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLTWO
    {
        public LVLTWO()
        {
            Console.Title = "Level 2";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Clear();
            Console.WriteLine("Welcome to Leve 2/5 of the Samoan Tutorial");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("We will be learning some ways of how to say 'Good' and 'Bad', and ways to say 'Sorry' and 'Please' in Samoan");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            string[] words;
            words = new string[] { "Lelei", "Manaia" };
            Console.Clear();
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
                Console.ForegroundColor = ConsoleColor.Green;                
                Console.WriteLine("Nice job :), press enter to continue ");
                Console.ReadLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is incorrect, press enter to try again.");
                Console.ReadLine();
                lelei();
            }

            static void lelei()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("try typing Lelei.");
                Console.WriteLine("press enter when done typing");
                string good1 = Console.ReadLine();
                good1 = good1.ToLower();

                if (good1 == "lelei" || good1 == "manaia")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Nice job :), press enter to continue ");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect, press enter to try again.");
                    Console.ReadLine();
                    lelei();
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("The way that we say 'Bad' in Samoan is 'Leaga' (Leh - ya - nga)");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            ain();
            

            static void ain()
            {
                
                Console.Clear();
                Console.WriteLine("Try typing 'Leaga' yourself");
                string leaga = Console.ReadLine().ToLower();
                

                
                string spaces = " correct press enter to continue";
                for (int i = 0; i > leaga.Length; i++)
                {
                    if (leaga == "leaga")
                    {
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("That is incorrect, press enter to try again.");
                        Console.ReadLine();
                        ain();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("your answer was" + spaces + "Press enter to continue");
                Console.ReadLine();
                Q3();
            }
            static void Q3()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("You will now learn how to say please");
                Console.WriteLine("Please in Samoan is 'Fa'amolemole' (Fah - ah - moh - leh - moh - leh)");
                Console.WriteLine("press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Try typing 'Fa'amolemole' yourself.");
                Console.WriteLine("Press enter when you're done with your answer.");
                string please = Console.ReadLine();
                please = please.ToLower();


                for (please = "fa'amolemole"; ;)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("that is correct press enter to continue.");
                    Console.ReadLine();
                    sorry();
                    break;                    
                }
                if(please == "fa'amolemole")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct press enter to continue.");
                    Console.ReadLine();
                    sorry();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect, press enter to try again.");
                    Console.ReadLine();
                    Q3();
                }

            }
            static void sorry()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("We will now learn how to say sorry.");
                Console.WriteLine("press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("The common way to say 'Sorry' in Samoan is 'Malie' (mah - lee - ye)");
                Console.WriteLine("Press enter to continue.");
                Console.ReadKey();
                sorry2();

                static void sorry2()
                {
                    Console.Clear();
                    
                    Console.Clear();
                    Console.WriteLine("Try typing Malie yourself");
                    string malie = Console.ReadLine();

                    while (malie == "malie")
                    {
                        if (malie == "malie")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("That is correct press enter to continue to the end of tutorial quiz");
                            Console.ReadLine();
                            TWOQUIZ T1 = new TWOQUIZ();
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("that is incorrect, press enter to try again");
                            Console.ReadLine();
                            sorry2();
                            break;
                        }

                    }
                }

                
            }
            
                 
               



        }
                
    }
}

          
    


