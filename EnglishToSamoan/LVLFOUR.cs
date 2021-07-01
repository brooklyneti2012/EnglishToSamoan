using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLFOUR
    {
        public LVLFOUR()
        {
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
                    string one = Console.ReadLine();
                    one = one.ToLower();

                    if (one == "tasi")
                    {
                        Console.ResetColor();
                        Console.WriteLine("INPUT: " + one);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("That is correct :)");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        TWO();
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.WriteLine("INPUT: " + one);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is incorrect :(");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to try again");
                        Console.ReadLine();
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
                        string LUA = Console.ReadLine();
                        LUA = LUA.ToLower();

                        while (LUA == "lua") 
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("that is correct :)");
                            Console.ResetColor();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            THREE();
                            break;
                        }

                        while (LUA != "lua") 
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is incorrect :(");
                            Console.ResetColor();
                            Console.WriteLine("Press enter to try again.");
                            Console.ReadLine();
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
                    words = new string[] {"Tasi", "Lua", "tolu", "fa", "Lima", "Ono", "fitu", "Valu", "Iva", "Sefulu" };
                    string[] RightOrWrong;
                    RightOrWrong = new string[] {"That is correct :)", "That is incorrect :(" };
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
                    string three = Console.ReadLine();
                    three = three.ToLower();

                   /* do
                    {
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(RightOrWrong[0]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to coninue.");
                        Console.ReadLine();
                        break;
                    } while (three == "tolu");*/

                    while (three == "tolu")
                    {
                        Console.WriteLine("INPUT: " + three);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(RightOrWrong[0]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    while (three != "tolu")
                    {
                        Console.WriteLine("INPUT: " + three);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is incorrect :(");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Press enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("In Samoan, To say the Number 4");
                    Console.WriteLine("We say 'Fa'");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("How do you say the number 4 in Samoan.");
                    Console.WriteLine("ps. this is really easy.");
                    string four = Console.ReadLine();
                    four = four.ToLower();

                    if (four == "fa")
                        Console.WriteLine("CORRECT");
                        Console.WriteLine("WOOOOOW, that was really easy wasn't it?");
                }
                
            }
        }
    }
}
