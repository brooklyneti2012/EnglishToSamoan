using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class FIVEQUIZcs
    {
        
        public FIVEQUIZcs()
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

            Console.Clear();
            Console.WriteLine("Welcome to the final quiz for the Samoan Tutorials Point.");
            Console.WriteLine("There will be 5 questions in this quiz.");
            Console.WriteLine("there will be 3 multichoice questions.");
            Console.WriteLine("and 2 Written answer questions");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Q1();
            static void Q1()
            {
                Console.Clear();
                Console.WriteLine("Q1. Multichoice.");
                Console.WriteLine("Which of the following stands for the word 'Tall' in Samoan.");
                Console.WriteLine("A. Lapoa.");
                Console.WriteLine("B. Umi.");
                Console.WriteLine("C. Pu'upu'u.");
                Console.WriteLine("D. La'ititi");
                Console.WriteLine("Type the answer, or the letter and press enter to submit your answer");
                string b = Console.ReadLine();
                b = b.ToLower();

                if(b == "b" || b == "umi" || b == "b. umi" || b == "b umi")
                {
                    Console.WriteLine("INPUT: " + b);
                    correct();
                    Q2();
                }
                else
                {
                    incorrect();
                    Q1();
                }
            }
            static void Q2()
            {
                Console.Clear();
                Console.WriteLine("Q2. Written Answer.");
                Console.WriteLine("How do you say Short in Samoan?");
                Console.WriteLine("Press enter after typing your answer.");
                string q2 = Console.ReadLine();
                q2 = q2.ToLower();

                while(q2 == "pu'upu'u" || q2 == "puupuu")
                {
                    correct();
                    Q3();
                    break;
                }

                while(q2 != "pu'upu'u" || q2 != "puupuu")
                {
                    incorrect();
                    Q2();
                    break;
                }
            }
            static void Q3()
            {
                Console.Clear();
                Console.WriteLine("Q3. Multichoice.");
                Console.WriteLine("Which of the follwing means Wide in Samoan.");
                Console.WriteLine("A. la'ititi");
                Console.WriteLine("B. Lapo'a");
                Console.WriteLine("C. Lautele");
                Console.WriteLine("D. Umi");
                Console.WriteLine("Type the answer, or the letter and press enter to submit your answer");
                string c = Console.ReadLine();
                c = c.ToLower();

                switch(c)
                {
                    case "c":
                        correct();
                        Q4();
                        break;

                    case "lautele":
                        correct();
                        Q4();
                        break;

                    case "c. lautele":
                        correct();
                        Q4();
                        break;

                    default:
                        Console.WriteLine("INPUT: " + c);
                        incorrect();
                        Q3();
                        break;
                }
            }

            static void Q4()
            {
                Console.Clear();
                Console.WriteLine("How do you say the word skinny in Samoan?");
                Console.WriteLine("Press enter after typing your answer.");
                string q4 = Console.ReadLine();
                q4 = q4.ToLower();

                if (q4 == "paee")
                {
                    correct();
                    Q5();
                }
                else
                {
                    incorrect();
                    Q4();
                }

            }

            static void Q5()
            {
                Console.Clear();
                Console.WriteLine("Q3. Multichoice.");
                Console.WriteLine("Which of the follwing means Small in Samoan.");
                Console.WriteLine("A. la'ititi");
                Console.WriteLine("B. Lapo'a");
                Console.WriteLine("C. Lautele");
                Console.WriteLine("D. Umi");
                Console.WriteLine("Type the answer, or the letter and press enter to submit your answer");
                string a = Console.ReadLine();
                a = a.ToLower();

                switch (a)
                {
                    case "a":
                        correct();
                        EndOFQuiz();
                        break;

                    case "la'ititi":
                        correct();
                        EndOFQuiz();
                        break;

                    case "c. la'ititi":
                        correct();
                        EndOFQuiz();
                        break;

                    case "laititi":
                        correct();
                        break;

                    default:
                        Console.WriteLine("INPUT: " + a);
                        incorrect();
                        Q3();
                        break;
                }

            }
            static void EndOFQuiz()
            {
                Console.Clear();
                Console.WriteLine("Congrats on Finishing the Samoan Tutorials Point.");
                Console.WriteLine("You have officialy learnt some of the basics of the Samoan language.");
                Console.WriteLine("you may now press enter to finish the program.");
                Console.ReadLine();
            }
        }
            
    }
}
