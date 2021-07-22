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
                    Console.WriteLine("");
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

                    switch (a)
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
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        que4();

                    }
                    else if (c != "c")
                    {
                        Console.WriteLine("That is incorrect.");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadLine();
                        que3();
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid input.");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadLine();
                        que3();
                    }
                }
                static void que4()
                {
                    Console.Clear();
                    Console.WriteLine("Q4. Written answer.");
                    Console.WriteLine("How do you say the number 4 in Samoan.");
                    Console.WriteLine("Hint. this was the easy one in the tutorial.");
                    string F4 = Console.ReadLine();
                    F4 = F4.ToLower();

                    while(F4 == "fa")
                    {
                        Console.WriteLine("That is correct.");
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        que5();
                        break;
                    }
                    while(F4 != "fa")
                    {
                        Console.WriteLine("That is incorrect :(");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadLine();
                        que4();
                        break;
                    }
                }
                static void que5()
                {
                    Console.Clear();
                    Console.WriteLine("Q5. Multichoice.");
                    Console.WriteLine("Which of the following means 1 in Samoan");
                    Console.WriteLine("A. Fitu");
                    Console.WriteLine("B. Valu");
                    Console.WriteLine("C. Iva");
                    Console.WriteLine("D. Ono");
                    Console.WriteLine("E. Tasi");
                    Console.WriteLine("Type a letter from the choices here");
                    Console.WriteLine("Press enter after making your choice.");
                    string e = Console.ReadLine();
                    e = e.ToLower();

                    switch(e)
                    {
                        case "e":
                            Console.WriteLine("That is correct press enter to continue.");
                            Console.ReadLine();
                            que6();
                            break;

                        case "a":
                            Console.WriteLine("That is incorrect.");
                            Console.WriteLine("Press enter to try again.");
                            Console.ReadLine();
                            que5();
                            break;

                        case "b":
                            Console.WriteLine("That is incorrect.");
                            Console.WriteLine("Press enter to try again.");
                            Console.ReadLine();
                            que5();
                            break;

                        case "c":
                            Console.WriteLine("That is incorrect.");
                            Console.WriteLine("Press enter to try again.");
                            Console.ReadLine();
                            que5();
                            break;

                        case "d":
                            Console.WriteLine("That is incorrect.");
                            Console.WriteLine("Press enter to try again.");
                            Console.ReadLine();
                            que5();
                            break;

                        default:
                            Console.WriteLine("That is an invalid input.");
                            Console.WriteLine("Press enter to try again.");
                            Console.ReadLine();
                            que5();
                            break;
                    }
                }
                static void que6()
                {
                    Console.Clear();
                    Console.WriteLine("Q6. Written answer.");
                    Console.WriteLine("How do you say the number 8 in Samoan?");
                    Console.WriteLine("Type your answer then press enter after typing your answer.");
                    string eight = Console.ReadLine();
                    eight = eight.ToLower();

                    if (eight == "valu")
                    {
                        Console.WriteLine("That is correct.");
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        que7();
                    }
                    else
                    {
                        Console.WriteLine("That is incorrect.");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadLine();
                        que6();
                    }
                }
                static void que7()
                {
                    Console.Clear();
                    Console.WriteLine("Q7. Multichoice.");
                    Console.WriteLine("Which of the following means the number 3");
                    Console.WriteLine("A. Lua");
                    Console.WriteLine("B. Fa");
                    Console.WriteLine("C. Sefulu");
                    Console.WriteLine("D. Tolu");
                    Console.WriteLine("E. Tasi");
                    Console.WriteLine("Type in a letter as your answer.");
                    Console.WriteLine("Press enter after making a choice.");
                    string d = Console.ReadLine();
                    d = d.ToLower();

                   while (d == "d")
                    {
                        Console.WriteLine("That is correct");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        que8();
                        break;
                    }

                    while (d != "d")
                    {
                        Console.WriteLine("That is incorrect");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        que7();
                        break;
                    }
                }
                static void que8()
                {
                    Console.Clear();
                    Console.WriteLine("Q8. Written answer.");
                    Console.WriteLine("How do you say the number 2 in Samoan.");
                    Console.WriteLine("type your answer and press enter after.");
                    string lua = Console.ReadLine();
                    lua = lua.ToLower();

                    switch(lua)
                    {
                        case "lua":
                            Console.WriteLine("That is correct.");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            que9();
                            break;
                        default:
                            Console.WriteLine("That is incorrect.");
                            Console.WriteLine("Press enter to try again.");
                            Console.ReadLine();
                            que8();
                            break;
                    }

                }
                static void que9()
                {
                    Console.Clear();
                    Console.WriteLine("Q9. Multichoice");
                    Console.WriteLine("Which of the following means the number 5 in Samoan.");
                    Console.WriteLine("A. tasi");
                    Console.WriteLine("B. Lua");
                    Console.WriteLine("C. Lima");
                    Console.WriteLine("D. iva");
                    Console.WriteLine("E. tolu");
                    Console.WriteLine("Type a letter from above and press enter after making your choice.");
                    string c = Console.ReadLine();
                    c = c.ToLower();
                    
                    if(c == "c")
                    {
                        Console.WriteLine("That is correct.");
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        que10();
                    }
                    else
                    {
                        Console.WriteLine("That is incorrect.");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadLine();
                        que9();
                    }
                }
                static void que10()
                {
                    Console.Clear();
                    Console.WriteLine("FINAL QUESTION");
                    Console.WriteLine("Q10. Written Answer.");
                    Console.WriteLine("How do you say the number 10 in Samoan.");
                    Console.WriteLine("Type your answer.");
                    Console.WriteLine("Press enter after typing your answer.");
                    string sefulu = Console.ReadLine();
                    sefulu = sefulu.ToLower();

                    while (sefulu == "sefulu")
                    {
                        Console.WriteLine("That is correct.");
                        Console.WriteLine("Press enter to finish the quiz.");
                        Console.ReadLine();
                        EndOfQuiz();
                        break;
                    }
                    while (sefulu != "sefulu")
                    {
                        Console.WriteLine("That is incorrect.");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadLine();
                        que10();
                        break;
                    }
                }
                static void EndOfQuiz()
                {
                    Console.Clear();
                    Console.WriteLine("Congrats on finishing the End Of Tutorial Quiz for Tutorial 4.");
                    Console.WriteLine("You have officialy learnt numbers 1 - 10 in Samoan.");
                    Console.WriteLine("Type yes if you want to continue to tutorial 5.");
                    Console.WriteLine("Or type no if you want to end the Samoan Tutorials Point program.");
                    Console.WriteLine("Press enter after making your choice.");
                    string YesOrNo = Console.ReadLine();
                    YesOrNo = YesOrNo.ToLower();

                    if(YesOrNo == "yes")
                    {
                        LVLFIVE L5 = new LVLFIVE();
                    }
                    else if(YesOrNo == "no")
                    {
                        Console.WriteLine("Goodbye.");
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid input.");
                        Console.WriteLine("Press enter to pick again.");
                        Console.ReadLine();
                        EndOfQuiz();
                    }
                }
            }
        }
    }
}