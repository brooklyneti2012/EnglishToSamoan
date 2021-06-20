﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class THREEQUIZ
    {
        public THREEQUIZ()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the end of tutorial 3 quiz");
            Console.WriteLine("There will be 7 qusetions");
            Console.WriteLine("4 multichoice, Eg: (A, B, C, D)");
            Console.WriteLine("And 3 Written answer questions");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Q1();

            static void Q1()
            {
                Console.WriteLine("Q1, multichoice");
                Console.WriteLine("Which of the following answers mean Monday in Samoan");
                Console.WriteLine("A. Aso Gafua");
                Console.WriteLine("B. Aso Lulu");
                Console.WriteLine("C. Aso Lua");
                Console.WriteLine("D. Aso Sa");
                Console.WriteLine("Type a letter and press enter to continue.");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "a")
                {
                    Console.WriteLine("INPUT: A. Aso Gafua");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct :), press enter to continue");
                    Console.ReadLine();
                    Q2();
                }
                else if (answer == "b")
                {
                    Console.WriteLine("INPUT: B. Aso Lulu");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect :(, press enter to try again");
                    Console.ReadLine();
                    Q1();
                }
                else if (answer == "c")
                {
                    Console.WriteLine("INPUT: C. Aso Lua");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect :(, press enter to try again");
                    Console.ReadLine();
                    Q1();
                }
                else if (answer == "d")
                {
                    Console.WriteLine("INPUT: D. Aso Sa");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect :(, press enter to try again");
                    Console.ReadLine();
                    Q1();
                }
            }

            static void Q2()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Q2. Written answer");
                Console.WriteLine("Type the definition of the word 'Tuesday' in Samoan");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                if (answer == "aso lua")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct, press enter to continue.");
                    Console.ReadLine();
                    Q3();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Do you want a hint");
                    Console.WriteLine("Type yes or no, then press enter to continue");
                    string hint1 = Console.ReadLine();
                    hint1 = hint1.ToLower();

                    if (hint1 == "yes")
                    {
                        hint2();
                    }
                    else if (hint1 == "no")
                    {
                        Q2();
                    }                    
                }
            }

            static void hint2()
            {
                Console.Clear();
                Console.WriteLine("These are your options.");
                string[] hint2;
                hint2 = new string[] { "aso lua", "aso lulu", "aso gafua", "aso sa" };
                Console.WriteLine("option 1 = " + hint2[0]);
                Console.WriteLine("option 2 = " + hint2[1]);
                Console.WriteLine("option 3 = " + hint2[2]);
                Console.WriteLine("option 4 = " + hint2[3]);
                Console.WriteLine("Press enter to try the question again.");
                Console.ReadLine();
                Q2();
            }
            static void Q3()
            {
                Console.Clear();
                Console.WriteLine("Q3. Multichoice");
                Console.WriteLine("Which of the following is the definition of 'Aso sa'");
                Console.WriteLine("A. Saturday");
                Console.WriteLine("B. Friday");
                Console.WriteLine("C. Sunday");
                Console.WriteLine("D. Wednesday");
                Console.WriteLine("Input a letter then press enter to continue.");
                string answer3 = Console.ReadLine();
                answer3 = answer3.ToLower();

                while (answer3 == "c")
                {
                    Console.WriteLine("INPUT: C. Sunday");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct, press enter to continue");
                    Console.ReadLine();
                    Q4();
                    break;
                }
                switch (answer3)
                {
                    case "a":
                        Console.WriteLine("INPUT: A. Saturday");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is incorrect, press enter to try again.");
                        Console.ReadLine();
                        Q3();
                        break;

                    case "b":
                        Console.WriteLine("INPUT: B. Friday");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is incorrect, press enter to try again");
                        Console.ReadLine();
                        Q3();
                        break;

                    case "d":
                        Console.WriteLine("INPUT: D. Wednesday");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is incorrect, press enter to try again");
                        Console.ReadLine();
                        Q3();
                        break;
                }
            }
            static void Q4()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Q4. Written answer");
                Console.WriteLine("Type the Samoan definition of 'Wednesday'");
                Console.WriteLine("Press enter after typing your answer");
                string Q4answer = Console.ReadLine();
                Q4answer = Q4answer.ToLower();

                do
                {
                    Console.WriteLine("INPUT: " + Q4answer + " that is correct");
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    break;
                } while (Q4answer == "aso lulu");

                if (Q4answer == "aso gafua")
                {
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else if (Q4answer == "aso lua")
                {
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else if (Q4answer == "aso tofi")
                {
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else if (Q4answer == "aso faraile")
                {
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else if (Q4answer == "aso tonai" && Q4answer == "aso tona'i")
                {
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else if (Q4answer == "aso sa")
                {
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else
                {
                    Console.WriteLine("That is an invalid input, press enter to try again.");
                    Console.ReadLine();
                    Q4();
                }
            }
            static void Q5()
            {
                Console.WriteLine("Q5. Multichoice");
            }
        }
    }
}