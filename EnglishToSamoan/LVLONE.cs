﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLONE
    {
        public LVLONE()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //welcomes user to tutorial 1
            Console.WriteLine("Welcome to level 1/5 of the Samoan tutorial");
            Console.WriteLine("In this tutorial you will be learning simple Samoan words");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The greeting used most in the Samoan language is 'Talofa'(tah - loh - fah)");
            Console.WriteLine("");
            Console.WriteLine("Try writing 'Talofa' yourself.");
            string talofa = Console.ReadLine();

            talofa = talofa.ToLower();

            if (talofa == "talofa")
            {
                Console.WriteLine("Nice job we will now move onto the next word to learn.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That is incorrect, try again.");
                retry();
            }

            //retry method for Talofa 
            static void retry()
            {


                string talofa = Console.ReadLine();
                talofa = talofa.ToLower();

                if (talofa == "talofa")
                {
                    Console.WriteLine("Nice job we will now move onto the next word to learn.");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("That is incorrect, try again.");
                    Console.WriteLine("PRESS ENTER TO TRY AGAIN");
                    retry();
                }





            }

            Console.Clear();
            Console.WriteLine("The next word we will try to learn is Goodbye");
            Console.WriteLine("press any key to continue");
            Console.ReadLine();
            Console.WriteLine("The Samoan way to say Goodbye is 'Tofa' (toh - fah)");
            Console.WriteLine("Try typing 'Tofa' yourself");

            string tofa = Console.ReadLine();
            tofa = tofa.ToLower();

            if (tofa == "tofa")
            {
                Console.WriteLine("Nice job our next word we will be learning is Tama and Teine");
                Console.WriteLine("PRESS ENTER TO CONTINUE.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ooh, try again remeber the word is 'TOFA' ");
                Console.WriteLine("PRESS ENTER TO TRY AGAIN");
                tryagain();
            }



            //retry method for TOFA 
            static void tryagain()
            {
                Console.WriteLine("Try writing 'tofa' yourself.");

                string tofa = Console.ReadLine();
                tofa = tofa.ToLower();

                if (tofa == "tofa")
                {
                    Console.WriteLine("Nice job we will now move onto the next word to learn is Tama and Teine.");

                }
                else
                {
                    Console.WriteLine("That is incorrect, try again.");
                    Console.WriteLine("PRESS ENTER TO TRY AGAIN");
                    Console.ReadLine();
                    tryagain();
                }

            }
            Console.Clear();
            Console.WriteLine("We will now be learning 'Tama'(tah - mah) and 'Teine'(Tey - neh)");
            Console.WriteLine("tama means 'BOY' and in some situations 'DAD'");
            Console.WriteLine("and teine means 'GIRL' and in some situation 'MUM'");
            Console.WriteLine("_________________________________________________________________");
            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Try typing 'TAMA' yourself");
            string tama = Console.ReadLine();
            tama = tama.ToLower();

            if (tama == "tama")
            {
                Console.WriteLine("Congrats we will now move onto teine.");
                Console.WriteLine("PRESS ENTER TO CONTINUE");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That is incorrect, press enter to try again.");
                Console.ReadLine();
                again();
            }

            static void again()
            {
                string tama = Console.ReadLine();
                tama = tama.ToLower();

                if (tama == "tama")
                {
                    Console.WriteLine("Congrats we will now move onto teine.");
                    Console.WriteLine("PRESS ENTER TO CONTINUE");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("That is incorrect try again.");
                    again();
                }
            }

            Console.Clear();

            Console.WriteLine("Try typing Teine yourself");
            string teine = Console.ReadLine();
            teine = teine.ToLower();

            if (teine == "teine")
            {
                Console.WriteLine("Nice job, we will now move onto the End Of Tutorial Quiz");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                quiz();
            }
            else
            {
                Console.WriteLine("That was incorrect, try again");
                AGAIN();
            }

            static void AGAIN()
            {
                string teine = Console.ReadLine();
                teine = teine.ToLower();

                if (teine == "teine")
                {
                    Console.WriteLine("Nice job, we will now move onto the End Of Tutorial Quiz");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    quiz();
                }
                else
                {
                    Console.WriteLine("That was incorrect, try again");
                    AGAIN();
                }
            }

            static void quiz()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the end of tutorial quiz.");
                Console.WriteLine("After this tutorial you will move onto the next tutorial");
                Console.WriteLine("Answer every question with 'A,a' or 'B,b'");
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Question 1");
                Console.WriteLine("Which word means BOY in Samoan?");
                Console.WriteLine("A. Teine");
                Console.WriteLine("B. Tama");
                Console.WriteLine("Enter your answer below (A or B)");
                string Q1 = Console.ReadLine();
                Q1 = Q1.ToLower();

                if (Q1 == "b")
                {
                    Console.WriteLine("Correct, press enter to continue to next question");
                    Console.ReadLine();
                    QUE2();
                }
                else
                {
                    Console.WriteLine("That is incorrect, press enter to try again");
                    Console.ReadLine();
                    QUE1();

                }

                static void QUE1()
                {
                    Console.Clear();
                    Console.WriteLine("Question 1");
                    Console.WriteLine("Which word means BOY in Samoan?");
                    Console.WriteLine("A. Teine");
                    Console.WriteLine("B. Tama");
                    Console.WriteLine("Enter your answer below as (A or B)");
                    string Q1 = Console.ReadLine();
                    Q1 = Q1.ToLower();

                    if (Q1 == "b")
                    {
                        Console.WriteLine("Correct, press enter to continue to next question");
                        Console.ReadLine();
                        QUE2();
                    }
                    else
                    {
                        Console.WriteLine("That is incorrect, press enter to try again");
                        Console.ReadLine();
                        QUE1();

                    }

                }
                static void QUE2()
                {
                    Console.Clear();
                    Console.WriteLine("Question 2");
                    Console.WriteLine("What does Talofa mean in English?");
                    Console.WriteLine("A. Goodbye");
                    Console.WriteLine("B. Hello");
                    Console.WriteLine("Enter your answer below as (A or B)");
                    string Q2 = Console.ReadLine();
                    Q2 = Q2.ToLower();

                    switch (Q2)
                    {
                        case "b":
                            Console.WriteLine("That is Correct, lets move onto the final question of this quiz");
                            Console.WriteLine("PRESS ENTER TO CONTINUE");
                            Console.ReadLine();
                            QUE3();
                            break;
                        case "a":
                            Console.WriteLine("That is incorrect, press enter to try again");
                            Console.ReadLine();
                            QUE2();


                            break;
                    }
                }

                static void QUE3()
                {
                    Console.Clear();
                    Console.WriteLine("how do you say 'Goodbye' in Samoan?");
                    Console.WriteLine("A. Tofa");
                    Console.WriteLine("B. Talofa");
                    Console.WriteLine("Enter your answer below as (A or B)");
                    string good = Console.ReadLine();
                    good = good.ToLower();

                    if (good == "a")
                    {
                        Console.WriteLine("Congratualtions, you can now move onto the next tutorial.");
                        Console.WriteLine("Press enter to continue to the next tutorial.");
                        Console.ReadLine();
                        TWO();
                    }
                    else
                    {
                        Console.WriteLine("That is incorrect, press enter to try again.");
                        Console.ReadLine();
                        QUE3();
                    }
                }
            }
        }
    }
}