using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLFOUR
    {
        public LVLFOUR()
        {
            static void correct()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("That is correct :)");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
            }
            static void incorrect()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That is incorrect :(");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press enter to try again");
                Console.ReadLine();
            }
            Console.Title = "Level 4";
            Console.Clear();
            Console.WriteLine("Welcome to tutorial 4/5 of the Samoan Tutorials Point");
            Console.WriteLine("In this tutorial we will be learning about numbers 1 - 10");
            Console.WriteLine("After you have completed the tutorial you will be taking part in the 'End Of Tutorial Quiz'");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            tasi();

            static void tasi()
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("In the Samoan language, to say the number 'one' \nWe say 'Tasi' (Tah - See)");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                ONE();

                static void ONE()
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Try typing 'tasi' yourself");
                    Console.WriteLine("Press enter after typing your answer");
                    string one = Console.ReadLine();
                    one = one.ToLower();

                    if (one == "tasi")
                    {
                        Console.WriteLine("INPUT: " + one);
                        correct();                        
                        TWO();
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.WriteLine("INPUT: " + one);
                        incorrect();
                        ONE();
                    }
                }
                static void TWO()
                {
                    Console.Clear();
                    Console.WriteLine("In the Samoan language \nTo say the number '2'");
                    Console.WriteLine("We say 'Lua' (loo - wah)");               
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    lua();

                    static void lua()
                    {
                        Console.Clear();
                        Console.WriteLine("Try typing 'Lua' yourself.");
                        Console.WriteLine("Press enter after typing your answer");
                        string LUA = Console.ReadLine();
                        LUA = LUA.ToLower();

                        while (LUA == "lua") 
                        {
                            Console.Clear();
                            correct();
                            THREE();
                            break;
                        }

                        while (LUA != "lua") 
                        {
                            Console.Clear();
                            incorrect();
                            lua();
                            break;

                        }
                    }
                }
                static void THREE()
                {
                    Console.Clear();
                    Console.WriteLine("So far you have learnt the words...");
                    string[] words;
                    words = new string[] { "Tasi", "Lua", "tolu", "fa", "Lima", "Ono", "fitu", "Valu", "Iva", "Sefulu" };
                    string[] RightOrWrong;
                    RightOrWrong = new string[] { "That is correct :)", "That is incorrect :(" };
                    Console.WriteLine(words[0] + " and " + words[1]);
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("We will now learn how to say the number three in Samoan");
                    Console.WriteLine("To say '3' in Samoan");
                    Console.WriteLine("We say 'Tolu' (Toh - loo)");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Try typing '" + words[2] + "' yourself");
                    Console.WriteLine("Press enter after typing your answer");
                    string three = Console.ReadLine();
                    three = three.ToLower();
                    while (three == "tolu")
                    {
                        Console.WriteLine("INPUT: " + three);
                        correct();
                        fa();
                        break;
                    }
                    while (three != "tolu")
                    {
                        Console.WriteLine("INPUT: " + three);
                        incorrect();
                        THREE();
                        break;
                    }
                    static void fa()
                    {
                        Console.Clear();
                        Console.WriteLine("In Samoan, To say the Number 4");
                        Console.WriteLine("We say 'Fa'");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Four();
                        static void Four()
                        {
                            Console.Clear();
                            Console.WriteLine("How do you say the number 4 in Samoan.");
                            Console.WriteLine("ps. this is really easy.");
                            Console.WriteLine("Press enter after typing your answer");
                            string four = Console.ReadLine();
                            four = four.ToLower();

                            if (four == "fa")
                            {
                                Console.WriteLine("INPUT: " + four);
                                Console.WriteLine("CORRECT");
                                Console.WriteLine("WOOOOOW, that was really easy wasn't it?");
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                                five();
                            }
                            else
                            {
                                Console.WriteLine("HOW DID YOU GET THAT WRONG.");
                                Console.WriteLine("ITS LITERALLY 2 LETTERS");
                                Console.WriteLine("press enter to try again");
                                Console.ReadLine();
                                Four();
                            }
                        }
                    }
                    static void five()
                    {
                        Console.Clear();
                        Console.WriteLine("We will now be learning how to say the number Five");
                        Console.WriteLine("To say Five in Samoan, we say 'Lima' (Lee - Mah)");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Five();
                        static void Five()
                        {
                            Console.Clear();
                            Console.WriteLine("Try typing Lima yourself.");
                            Console.WriteLine("Press enter after typing your answer.");
                            string f5 = Console.ReadLine();
                            f5 = f5.ToLower();

                            while (f5 == "lima")
                            {
                                Console.WriteLine("INPUT " + f5);
                                correct();
                                six();
                                break;
                            }
                            while (f5 != "lima")
                            {
                                Console.WriteLine("INPUT " + f5);
                                incorrect();
                                Five();
                                break;
                            }

                        }
                        static void six()
                        {
                            Console.Clear();
                            Console.WriteLine("We will now be learning how to say the number Six");
                            Console.WriteLine("To say Five in Samoan, we say 'ono' (oh - no)");
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Six();
                            static void Six()
                            {
                                Console.Clear();
                                Console.WriteLine("Try typing Ono yourself.");
                                Console.WriteLine("Press enter after typing your answer.");
                                string s6 = Console.ReadLine();
                                s6 = s6.ToLower();

                                while (s6 == "ono")
                                {
                                    Console.WriteLine("INPUT " + s6);
                                    correct();
                                    seven();
                                    break;
                                }
                                while (s6 != "ono")
                                {
                                    Console.WriteLine("INPUT " + s6);
                                    incorrect();
                                    Six();
                                    break;
                                }

                            }
                            static void seven()
                            {
                                Console.Clear();
                                Console.WriteLine("We will now be learning how to say the number Seven");
                                Console.WriteLine("To say Five in Samoan, we say 'fitu' (fee - two)");
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                                Seven();
                                static void Seven()
                                {
                                    Console.Clear();
                                    Console.WriteLine("Try typing fitu yourself.");
                                    Console.WriteLine("Press enter after typing your answer.");
                                    string s7 = Console.ReadLine();
                                    s7 = s7.ToLower();

                                    while (s7 == "fitu")
                                    {
                                        Console.WriteLine("INPUT " + s7);
                                        correct();
                                        Eight();
                                        break;
                                    }
                                    while (s7 != "fitu")
                                    {
                                        Console.WriteLine("INPUT " + s7);
                                        incorrect();
                                        Seven();
                                        break;
                                    }

                                }
                            }
                            static void Eight()
                            {
                                Console.Clear();
                                Console.WriteLine("We will now be learning how to say the number Eight");
                                Console.WriteLine("To say Eight in Samoan, we say 'valu' (vah - loo)");
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                                eight();

                                static void eight()
                                {
                                    Console.Clear();
                                    Console.WriteLine("Try typing Valu Yourself.");
                                    Console.WriteLine("Press enter aftere typing your answer.");
                                    string e8 = Console.ReadLine();
                                    e8 = e8.ToLower();

                                    if(e8 == "valu")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("INPUT: " + e8);
                                        correct();
                                        nine();
                                    }
                                    else if (e8 != "valu")
                                    {
                                        Console.WriteLine("INPUT = " + e8);
                                        incorrect();
                                        eight();
                                    }
                                }
                            }
                            static void nine()
                            {
                                Console.WriteLine("We will learn how to say the number Nine.");
                                Console.WriteLine("To say Nine in Samoan, we say 'Iva' (EE - vah)");
                                Console.WriteLine("Press enter to continue.");
                                Console.ReadLine();
                                Nine();
                                static void Nine()
                                {
                                    Console.Clear();
                                    Console.WriteLine("Try typing 'Iva' Yourself.");
                                    Console.WriteLine("Press enter after typing your answer");
                                }
                            }

                        }
                    }
                }
                
            }
        }
    }
}
