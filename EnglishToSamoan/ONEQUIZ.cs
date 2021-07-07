using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class ONEQUIZ
    {
        public ONEQUIZ()
        {
            quiz();
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

                    if (Q2 == "b")
                    {
                        Console.WriteLine("That is Correct, lets move onto the final question of this quiz");
                        Console.WriteLine("PRESS ENTER TO CONTINUE");
                        Console.ReadLine();
                        QUE3();

                    }
                    else if (Q2 != "b")
                    {
                        Console.WriteLine("That is incorrect, press enter to try again");
                        Console.ReadLine();
                        QUE2();
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid input.");
                        Console.WriteLine("Press enter to try again.");
                        Console.ReadLine();
                        QUE2();
                    }
                }

                static void QUE3()
                {
                    Console.Clear();
                    Console.WriteLine("how do you say 'Goodbye' in Samoan?");
                    Console.WriteLine("A. Tofa");
                    Console.WriteLine("B. Talofa");
                    Console.WriteLine("Enter your answer below as (A or B)");
                    Console.WriteLine("Press enter to submit your answer");
                    string good = Console.ReadLine();
                    good = good.ToLower();

                    if (good == "a")
                    {
                        Console.WriteLine("Congratualtions");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        WordsLearnt();
                    }
                    else
                    {
                        Console.WriteLine("That is incorrect, press enter to try again.");
                        Console.ReadLine();
                        QUE3();
                    }
                    static void WordsLearnt()
                    {
                        Console.Clear();
                        Console.WriteLine("These are the new words that you have learnt today.");
                        string[] words; 
                            words = new string[] { "Talofa", "Tofa", "Tama", "Teine" };
                        Console.WriteLine(words[0] + " = 'Hello'");
                        Console.WriteLine(words[1] + " = 'Goodbye'");
                        Console.WriteLine(words[2] + " = 'Boy or Dad'");
                        Console.WriteLine(words[3] + " = 'Girl or Mum'");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        choice();
                    }
                    static void choice()
                    {
                        Console.Clear();
                        Console.WriteLine("You have officially finished Tutorial 1/5 of the Samoan tutorials point");
                        Console.WriteLine("Type yes if you want to carry onto the next tutorial.");
                        Console.WriteLine("Or no to leave Samoan Tutorials Point.");
                        Console.WriteLine("Press enter after making your choice.");

                        string answerA = Console.ReadLine();
                        answerA = answerA.ToLower();
                        if (answerA == "yes")
                        {
                            LVLTWO L2 = new LVLTWO();
                        }
                        else if (answerA == "no")
                        {
                            Console.ReadKey();
                        }
                        else if (answerA != "yes" || answerA != "no")
                        {
                            Console.WriteLine("That is an invalid input.");
                            Console.WriteLine("Press enter to pick again.");
                            choice();
                        }

                    }

                 
                }
            }
        }
    }
}
