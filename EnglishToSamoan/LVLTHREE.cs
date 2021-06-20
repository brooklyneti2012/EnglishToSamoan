using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLTHREE
    {
        public LVLTHREE()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Welcome to level 3/5 of the Samoan Tutorials Point.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("In this tutorial you will be learning how to say the days of the week");
            Console.WriteLine("Hint: 'Aso' means 'Day'.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("To say 'Monday' in Samoan we say 'Aso Gafua'");
            Console.WriteLine("Pronounciation: (Ah - soh, Nga - Foo - Wah)");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Monday();

            static void Monday()
            {
                Console.Clear();
                Console.WriteLine("Q1. Monday");
                Console.WriteLine("ASO GAFUA");
                Console.WriteLine("Try typing 'Aso Gafua' yourself");
                string monday = Console.ReadLine();
                monday = monday.ToLower();

                if (monday == "aso gafua")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct, press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect press enter to try again");
                    Console.ReadLine();
                    Monday();
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("The Samoan way to say 'Tuesday' is 'Aso Lua'");
            Console.WriteLine("Pronounciation: (Ah - soh, loo - wah)");
            Console.WriteLine("press enter to continue.");
            Console.ReadLine();
            Tuesday();

            static void Tuesday()
            {
                Console.Clear();
                Console.WriteLine("Q2. tuesday");
                Console.WriteLine("Try typing Aso Lua yourself");
                string tuesday = Console.ReadLine();
                tuesday = tuesday.ToLower();

                if (tuesday == "aso lua")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct, press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That was incorrect, press enter to try again.");
                    Console.ReadLine();
                    Tuesday();
                }
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();
            Console.WriteLine("The Samoan way to say 'Wednesday' is 'Aso Lulu'");
            Console.WriteLine("Pronounciation: (Ah - soh, loo - loo)");
            Console.WriteLine("press enter to continue.");
            Console.ReadLine();
            Wednesday();

            static void Wednesday()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Q3. wednesday");
                Console.WriteLine("Try typing Aso Lulu yourself");
                string wednesday = Console.ReadLine();
                wednesday = wednesday.ToLower();

                if (wednesday == "aso lulu")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct, press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That was incorrect, press enter to try again.");
                    Console.ReadLine();
                    Wednesday();
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("The Samoan way to say 'Thursday' is 'Aso tofi'");
            Console.WriteLine("Pronounciation: (Ah - soh, Toh - fee)");
            Console.WriteLine("press enter to continue.");
            Console.ReadLine();
            Thursday();

            static void Thursday()
            {
                Console.Clear();
                Console.WriteLine("Q4. thursday");
                Console.WriteLine("Try typing Aso tofi yourself");
                string thursday = Console.ReadLine();
                thursday = thursday.ToLower();

                if (thursday == "aso tofi")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct, press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That was incorrect, press enter to try again.");
                    Console.ReadLine();
                    Thursday();
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("The Samoan way to say 'Friday' is 'Aso faraile'");
            Console.WriteLine("Pronounciation: (Ah - soh, fah - ry - leh)");
            Console.WriteLine("press enter to continue.");
            Console.ReadLine();
            Friday();

            static void Friday()
            {
                Console.Clear();
                Console.WriteLine("Q5. friday");
                Console.WriteLine("Try typing Aso faraile yourself");
                string friday = Console.ReadLine();
                friday = friday.ToLower();

                if (friday == "aso faraile")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct, press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That was incorrect, press enter to try again.");
                    Console.ReadLine();
                    Thursday();
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("The Samoan way to say 'Saturday' is 'Aso tofi'");
            Console.WriteLine("Pronounciation: (Ah - soh, Toh - fee)");
            Console.WriteLine("press enter to continue.");
            Console.ReadLine();
            Saturday();

            static void Saturday()
            {
                Console.Clear();
                Console.WriteLine("Q5. friday");
                Console.WriteLine("Try typing Aso tona'i yourself");
                string saturday = Console.ReadLine();
                saturday = saturday.ToLower();

                if (saturday == "aso tona'i" && saturday == "aso tonai")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct, press enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That was incorrect, press enter to try again.");
                    Console.ReadLine();
                    Saturday();
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("The Samoan way to say 'Saturday' is 'Aso Sa'");
            Console.WriteLine("Pronounciation: (Ah - soh, Sah)");
            Console.WriteLine("press enter to continue.");
            Console.ReadLine();
            Sunday();

            static void Sunday()
            {
                Console.Clear();
                Console.WriteLine("Q6. Sunday");
                Console.WriteLine("Try typing Aso sa yourself");
                string sunday = Console.ReadLine();
                sunday = sunday.ToLower();

                if (sunday == "aso sa")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct, press enter to continue to the end of tutorial quiz");
                    Console.ReadLine();
                    THREEQUIZ Q3 = new THREEQUIZ();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That was incorrect, press enter to try again.");
                    Console.ReadLine();
                    Sunday();
                }
            }


        }
    }
}
