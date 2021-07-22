using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLFIVE
    {
        static void correct()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("That is correct.");
            Console.ResetColor();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
        static void incorrect()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("That is incorrect.");
            Console.ResetColor();
            Console.WriteLine("Press enter to try again.");
            Console.ReadLine();
        }
        public LVLFIVE()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the FINAL tutorial for the Samoan Tutorials Point.");
            Console.WriteLine("In this tutorial you will learn how to say the words...");
            Console.WriteLine("Big");
            Console.WriteLine("Small");
            Console.WriteLine("Wide");
            Console.WriteLine("Skinny");
            Console.WriteLine("Tall");
            Console.WriteLine("Short.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            BIG();

            static void BIG()
            {
                Console.Clear();
                Console.WriteLine("In Samoan, to say the word 'Big' we say. \n 'Lapo'a'");
                Console.WriteLine("Pronounciation: Lah - poh - ah");
                Console.WriteLine("Try typing 'Lapo'a' yourself.");
                string big = Console.ReadLine();
                big = big.ToLower();

                if (big == "lapo'a" || big == "lapoa")
                {
                    Console.Clear();
                    Console.WriteLine("INPUT: " + big);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nice job, Press enter to continue.");
                    Console.ResetColor();
                    Console.ReadLine();
                    smol();
                }
                else if (big != "lapo'a" || big != "lapoa")
                {
                    Console.Clear();
                    Console.WriteLine("INPUT: " + big);
                    Console.WriteLine("That is incorrect. Press enter to try again");
                    Console.ReadLine();
                    BIG();
                }    
            }
            static void smol()
            {
                Console.Clear();
                Console.WriteLine("In Samoan, to say the word 'Small.'");
                Console.WriteLine("We say 'La'ititi'");
                Console.WriteLine("Pronounciation: lie - tee - tee.");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                SMOL();

                static void SMOL()
                {
                    Console.Clear();
                    Console.WriteLine("Try typing 'La'ititi' yourself.");
                    string small = Console.ReadLine();
                    small = small.ToLower();

                    while(small == "la'ititi" || small == "laititi")
                    {
                        correct();
                        WIDE();
                    }
                    while(small != "la'ititi" || small != "laititi")
                    {
                        incorrect();
                        SMOL();
                    }

                }
            }

            static void WIDE()
            {
                Console.Clear();
                Console.WriteLine("In Samoan, To say the word wide.");
                Console.WriteLine("We say 'Lautele'");
                Console.WriteLine("Pronounciation: lao - teh - leh");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                wide();

                static void wide()
                {
                    Console.Clear();
                    Console.WriteLine("Type 'Lautele' yourself");
                    Console.WriteLine("Press enter after you finish typing.");
                    string Wide = Console.ReadLine();
                    Wide = Wide.ToLower();

                    switch(Wide)
                    {
                        case "lautele":
                            correct();
                            skinny();
                            break;

                        default:
                            incorrect();
                            wide();
                            break;
                    }
                }
            }

            static void skinny()
            {
                Console.Clear();
                Console.WriteLine("In Samoan, to say the word skinny");
                Console.WriteLine("We say 'paee'");
                Console.WriteLine("Pronounciation: Pie - yeah");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                SKINNY();

                static void SKINNY()
                {
                    Console.Clear();
                    Console.WriteLine("Try typing 'Paee' yourself.");
                    string paee = Console.ReadLine();
                    paee = paee.ToLower();

                    if (paee == "paee")
                    {
                        correct();
                        tall();
                    }
                    else
                    {
                        incorrect();
                        SKINNY();
                    }
                }
                static void tall()
                {
                    Console.Clear();
                    Console.WriteLine("In Samoan, to say the word Tall");
                    Console.WriteLine("We say 'Umi'");
                    Console.WriteLine("Pronounciation: oo - me");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    TALL();

                    static void TALL()
                    {
                        Console.Clear();
                        Console.WriteLine("try typing 'Umi' yourself");
                        string umi = Console.ReadLine();
                        umi = umi.ToLower();

                        while(umi == "umi")
                        {
                            correct();
                            Short();
                            break;
                        }
                        while(umi != "umi")
                        {
                            incorrect();
                            TALL();
                            break;
                        }

                    }

                    static void Short()
                    {
                        Console.Clear();
                        Console.WriteLine("In Samoan, to say the word Short.");
                        Console.WriteLine("We say 'Pu'upu'u'.");
                        Console.WriteLine("Pronounciation: Poo - oo - poo - oo");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Shrt();

                        static void Shrt()
                        {
                            Console.Clear();
                            Console.WriteLine("Try typing 'Pu'upu'u' yourself.");
                            Console.WriteLine("Press enter after typing your answer.");
                            string SHORT = Console.ReadLine();
                            SHORT = SHORT.ToLower();

                            switch(SHORT)
                            {
                                case "pu'upu'u":
                                    correct();
                                    FIVEQUIZcs FQ = new FIVEQUIZcs();
                                    break;
                                case "puupuu":
                                    correct();
                                    FIVEQUIZcs Fq = new FIVEQUIZcs();
                                    break;
                                default:
                                    incorrect();
                                    Shrt();
                                    break;
                            }

                        }
                    }
                }
            }
        }
    }
}
