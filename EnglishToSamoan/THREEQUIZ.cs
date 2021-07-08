using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class THREEQUIZ
    {
        public THREEQUIZ()
        {
            Console.Title = "Quiz 3";
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
                Console.WriteLine("Which of the following answers stands for Monday in Samoan?");
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
                else
                {
                    Console.WriteLine("That is an invalid input.");
                    Console.WriteLine("Press enter to try again");
                }
            }

            static void Q2()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Q2. Written answer");
                Console.WriteLine("Type the definition of the word 'Tuesday' in Samoan?");
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
                    Console.WriteLine("Do you want a hint?");
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
                Console.WriteLine("Which of the following is the definition of 'Aso sa'?");
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
                while (answer3 != "c")
                {
                    Console.WriteLine("That is incorrect.");
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                    Q3();
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
                Console.WriteLine("Type the Samoan definition of 'Wednesday'?");
                Console.WriteLine("Press enter after typing your answer");
                string Q4answer = Console.ReadLine();
                Q4answer = Q4answer.ToLower();

                do
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("INPUT: " + Q4answer + " that is correct");
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    Q5();
                    break;
                } while (Q4answer == "aso lulu");

                if (Q4answer == "aso gafua")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else if (Q4answer == "aso lua")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else if (Q4answer == "aso tofi")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else if (Q4answer == "aso faraile")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else if (Q4answer == "aso tonai" && Q4answer == "aso tona'i")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else if (Q4answer == "aso sa")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INPUT: " + Q4answer + " that is incorrect, press enter to try again");
                    Console.ReadLine();
                    Q4();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("That is an invalid input, press enter to try again.");
                    Console.ReadLine();
                    Q4();
                }
            }
            static void Q5()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("Q5. Multichoice");
                Console.WriteLine("Which of the following is the definition of 'Aso Tona'i'?");
                Console.WriteLine("A. Sunday");
                Console.WriteLine("B. Saturday");
                Console.WriteLine("C. Thursady");
                Console.WriteLine("D. Monday");
                Console.WriteLine("Type a letter out of A, B, C, D, then press enter to confirm your answer.");
                string answer = Console.ReadLine();
                answer = answer.ToLower();

                while (answer ==  "b")
                {                    
                    Console.WriteLine("INPUT " + answer);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("That is correct.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("press enter to consintue");
                    Console.ReadLine();
                    Q6();
                    break;
                }

                if (answer == "a")
                {
                    Console.WriteLine("INPUT " + answer);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is inccorect.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to try again.");
                    Q4();
                }
                else if (answer == "c")
                {
                    Console.WriteLine("INPUT " + answer);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is inccorect.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to try again.");
                    Q4();
                }
                else if (answer == "d")
                {
                    Console.WriteLine("INPUT " + answer);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is inccorect.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to try again.");
                    Q4();
                }
                else
                {
                    Console.WriteLine(answer + " is an invalid input");
                    Console.WriteLine("Press enter to try again");
                    Q4();
                }
            }
            static void Q6()
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Q6. Written answer");
                Console.WriteLine("How do you write thursday in Samoan?");
                Console.WriteLine("Press enter after typing your answer.");
                string thursday = Console.ReadLine();
                thursday = thursday.ToLower();


                switch(thursday)
                {
                    case "aso tofi":
                        Console.WriteLine("INPUT " + thursday);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("That is correct");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Q7();
                        break;                    
                }
                if (thursday == "aso gafua")
                {
                    Console.WriteLine("INPUT " + thursday);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect.");
                    Console.ResetColor();
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                    Q6();
                }
                else if (thursday == "aso lua")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                    Q6();
                }
                else if (thursday == "aso lulu")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                    Q6();
                }
                else if (thursday == "aso sa")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                    Q6();
                }
                else if (thursday == "aso tonai")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                    Q6();
                }
                else if (thursday == "aso faraile")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                    Q6();
                }
                else
                {
                    Console.WriteLine("That is an invalid input.");
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                    Q6();
                }
            }
            static void Q7()
            {
                Console.Clear();
                Console.WriteLine("Q7. Multichoice");
                Console.WriteLine("Which of the following stands for 'Friday' in Samoan?");
                Console.WriteLine("A. Aso Sa");
                Console.WriteLine("B. Aso Gafua");
                Console.WriteLine("C. Aso Faraile");
                Console.WriteLine("D. Aso Tona'i");
                Console.WriteLine("Type a letter as your answer and press enter after making your choice.");
                string c = Console.ReadLine();
                c = c.ToLower();

                if (c == "c")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("INPUT: " + c + " that is correct.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    learnt();
                }
                else if (c == "a" || c == "b" || c =="d")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INPUT: " + c + " that is incorrect.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                    Q7();
                }
                else
                {
                    Console.WriteLine("INPUT: " + c + "that is an invalid input.");
                    Console.WriteLine("Press enter to try again.");
                    Console.ReadLine();
                    Q7();
                }
                
            }

            static void learnt()
            {
                Console.Clear();
                DateTime now = DateTime.Now;
                Console.WriteLine("You have Finished level 3 at " + now.ToString());
                Console.WriteLine("Today you have learnt these words.");
                string[] learn;
                learn = new string[] {"Aso Gafua", "Aso Lua", "Aso Lulu", "Aso Tofi", "Aso Faraile", "Aso Tona'i", "Aso Sa" };
                Console.WriteLine(learn[0] + " = Monday");
                Console.WriteLine(learn[1] + " = Tuesday");
                Console.WriteLine(learn[2] + " = Wednesday");
                Console.WriteLine(learn[3] + " = Thursday");
                Console.WriteLine(learn[4] + " = Friday");
                Console.WriteLine(learn[5] + " = Saturday");
                Console.WriteLine(learn[6] + " = Sunday");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                done();

                static void done()
                {
                    Console.Clear();
                    Console.WriteLine("You have official finished 'Level 3' of the Samoan Tutorials Point.");
                    Console.WriteLine("Type 'yes' to continue to the next tutorial.");
                    Console.WriteLine("Or type 'no' if you wish to exit Samoan Tutorials point.");
                    Console.WriteLine("Or if you want to pick another level, type 'menu' to go to the main menu");
                    Console.WriteLine("Press enter after making your choice");
                    string CarryOn = Console.ReadLine();
                    CarryOn = CarryOn.ToLower();

                    if (CarryOn == "yes")
                    {
                        LVLFOUR L4 = new LVLFOUR();
                    }
                    else if (CarryOn == "no")
                    {
                        Console.Clear();
                    }
                    else if (CarryOn == "menu")
                    {
                        Program P1 = new Program();
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid input");
                        Console.WriteLine("Press enter.");
                        Console.ReadLine();
                        done();
                    }
                }
            }
        }
    }
}
