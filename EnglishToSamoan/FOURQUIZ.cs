using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class FOURQUIZ
    {
        
        public FOURQUIZ()
        {

            START();
            static void START()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the End Of Tutorial Quiz for tutorial 4");
                Console.WriteLine("In this Quiz you will be answer 10 questions");
                Console.WriteLine("and when you get all the questions right you will move onto the final Tutorial ");
                Console.WriteLine("There will be 5 Multichoice questions, and 5 written answer questions");
                Console.WriteLine("Press enter to start the quiz.");
                Console.ReadLine();
                que1();

                static void que1()
                {
                    Console.Clear();
                    Console.WriteLine("Q1. Multichoice");
                    Console.WriteLine("Which of the following stand for the number 7");
                    Console.WriteLine("A. Fitu");
                    Console.WriteLine("B. Valu");
                    Console.WriteLine("C. Iva");
                    Console.WriteLine("D. Ono");
                    Console.WriteLine("E. Tasi");
                    Console.WriteLine("Type a letter from the choices here");
                    Console.WriteLine("Press enter after making your choice.");
                    string a = Console.ReadLine();
                    a = a.ToLower();

                    switch(a)
                    {
                        case "a":
                            Console.WriteLine("That is correct");
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            que2();
                            break;

                        case "b":
                            Console.WriteLine("That is incorrect");
                            Console.WriteLine("Press enter to try again");
                            Console.ReadLine();
                            que1();
                            break;

                        case "c":
                            Console.WriteLine("That is incorrect.");
                            Console.WriteLine("Press enter to try again.");
                            Console.ReadLine();
                            que1();
                            break;

                        case "d":
                            Console.WriteLine("That is incorrect.");
                            Console.WriteLine("Press enter to try again.");
                            Console.ReadLine();
                            que1();
                            break;

                        default:
                            Console.WriteLine("That is an incorrect input.");
                            Console.WriteLine("Press enter tot try again.");
                            Console.ReadLine();
                            que1();
                            break;
                    }
                }
                static void que2()
                {
                    Console.Clear();
                    Console.WriteLine("Q2. Written answer.");
                    Console.WriteLine("How do you say the number Ten in Samoan.");
                    string TEN = Console.ReadLine();
                    TEN = TEN.ToLower();

                    while (TEN == "sefulu")
                    {
                        Console.WriteLine("That is correct press enter to continue");
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        que3();
                        break;
                    }
                    while (TEN != "sefulu")
                    {
                        Console.WriteLine("That is incorrect.");
                        Console.WriteLine("HINT: Pronounciation: (Seh - Foo - Loo)");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadLine();        
                        que2();
                        break;
                    }
                }
                static void que3()
                {
                    Console.Clear();
                    Console.WriteLine("Q3. Multichoice");
                    Console.WriteLine("Which of the following stands for the number 'Six' in Samoan.");
                    Console.WriteLine("A. Sefulu");
                    Console.WriteLine("B. Tasi");
                    Console.WriteLine("C. Ono");
                    Console.WriteLine("D. Valu");
                    Console.WriteLine("E. Lua");
                    Console.WriteLine("Type a letter from the choice above");
                    Console.WriteLine("Press enter to submit your answer.");
                    string c = Console.ReadLine();
                    c = c.ToLower();

                    if (c == "c")
                    {
                        Console.WriteLine("That is correct.");

                    }
                }


            }
        }
    }
}
