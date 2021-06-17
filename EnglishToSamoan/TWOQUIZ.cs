using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class TWOQUIZ
    {
        public TWOQUIZ()
        {
            Console.Clear();
            Console.WriteLine("welcome to the end of tutorial quiz for tutorial 2/5");
            Console.WriteLine("you will be asked questions about what you have learnt in this tutorial");
            Console.WriteLine("There will be two multi choice qusetions. Eg: (a, b, c, or, d)");
            Console.WriteLine("And Three questions where you have to write the answer out. Eg: (talofa, hello)");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("Press enter when you're ready to continue");
            Console.ReadLine();
            Q1();
            static void Q1()
            {
                Console.Clear();
                Console.WriteLine("Q1 . Multichoice");
                Console.WriteLine("Which of the following means 'Please' in Samoan?");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("A. Talofa");
                Console.WriteLine("B. Malie");
                Console.WriteLine("C. Fa'amolemole");
                Console.WriteLine("D. Tofa");
                Console.WriteLine("Pick an answer out of A, B, C, D");
                string please1 = Console.ReadLine();
                please1 = please1.ToLower();

                while (please1 == "c" )
                {
                    Console.Clear();
                    Console.WriteLine("That is correct press enter to move onto the next question.");
                    Console.ReadLine();
                    Q2();
                    break;
                }
                switch (please1)
                {
                    case "a":
                        Console.WriteLine("that is incorrect press enter to try again.");
                        Console.ReadLine();
                        Q1();
                        break;
                    case "b":
                        Console.WriteLine("that is incorrect press enter to try again.");
                        Console.ReadLine();
                        Q1();
                        break;
                    case "d":
                        Console.WriteLine("that is incorrect press enter to try again.");
                        Console.ReadLine();
                        Q1();
                        break;
                }
            }
            static void Q2()
            {
                Console.Clear();
                Console.WriteLine("Q2 . Written answer");
                Console.WriteLine("As written in Samoan.");
                Console.WriteLine("How do you say 'Good' in Samoan?");
                string lelei1 = Console.ReadLine();
                lelei1 = lelei1.ToLower();

                if (lelei1 == "lelei" && lelei1 == "manaia")
                {
                    Console.WriteLine("That is correct, press enter to continue.");
                    Console.ReadLine();
                    Q3();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("That is incorrect");
                    Console.WriteLine("Do you want a hint?");
                    Console.WriteLine("yes or no");
                    Console.WriteLine("Press enter after making your answer.");
                    string hint = Console.ReadLine();
                    hint = hint.ToLower();

                    if (hint == "yes")
                    {
                        hint1();
                    }
                    else
                    {
                        Q2();
                    }
                }
                static void hint1()
                {
                    Console.Clear();
                    Console.WriteLine("These are your options.");
                    string[] hint2;
                    hint2 = new string[] { "Lelei", "Malie", "Fa'amolemole", "Leaga" };
                    Console.WriteLine("option 1 = " + hint2[0]);
                    Console.WriteLine("option 2 = " + hint2[1]);
                    Console.WriteLine("option 3 = " + hint2[2]);
                    Console.WriteLine("option 4 = " + hint2[3]);
                    Console.WriteLine("Press enter to try the question again.");
                    Console.ReadLine();
                    Q2();
                }
            }
            static void Q3()
            {
                Console.Clear();
                Console.WriteLine("Q3 . Multichoice");
                Console.WriteLine("Which of the following is the definition of 'Leaga' in English?");
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("Is it...");
                Console.WriteLine("A. Good");
                Console.WriteLine("B. Right");
                Console.WriteLine("C. Sad");
                Console.WriteLine("D. Bad");
                Console.WriteLine("Pick an answer out of A, B, C, D");
                string answer2 = Console.ReadLine();
                answer2 = answer2.ToLower();

                while (answer2 == "d")
                {
                    Console.Clear();
                    Console.WriteLine("That is correct press enter to move onto the next question.");
                    Console.ReadLine();
                    Q4();
                    break;
                }
                switch (answer2)
                {
                    case "a":
                        Console.WriteLine("that is incorrect press enter to try again.");
                        Console.ReadLine();
                        Q3();
                        break;
                    case "b":
                        Console.WriteLine("that is incorrect press enter to try again.");
                        Console.ReadLine();
                        Q3();
                        break;
                    case "c":
                        Console.WriteLine("that is incorrect press enter to try again.");
                        Console.ReadLine();
                        Q3();
                        break;
                }
                static void Q4()
                {
                    Console.Clear();
                    Console.WriteLine("Q4. Written Answer");
                    Console.WriteLine("How do you say 'Sorry' in Samoan?");
                    Console.WriteLine("Type your answer, and press enter to continue.");
                    string malie = Console.ReadLine();
                    malie = malie.ToLower();

                    if (malie == "malie")
                    {
                        Console.WriteLine("That is correct, press enter to finish quiz");
                        Console.ReadLine();
                        learnt();
                    }
                    else 
                    {
                        Console.WriteLine("That answer is incorrect");
                        Console.WriteLine("Do you want a hint?");
                        Console.WriteLine("yes or no");
                        Console.WriteLine("Press enter after making your answer.");
                        string hint = Console.ReadLine();
                        hint = hint.ToLower();

                        if (hint == "yes")
                        {
                            hint2();
                        }
                        else if(hint == "no")
                        {
                            Q4();
                        }
                    }
                    static void hint2()
                    {
                        Console.Clear();
                        Console.WriteLine("These are your options.");
                        string[] hint2;
                        hint2 = new string[] { "Lelei", "Malie", "Fa'amolemole", "Leaga" };
                        Console.WriteLine("option 1 = " + hint2[0]);
                        Console.WriteLine("option 2 = " + hint2[1]);
                        Console.WriteLine("option 3 = " + hint2[2]);
                        Console.WriteLine("option 4 = " + hint2[3]);
                        Console.WriteLine("Press enter to try the question again.");
                        Console.ReadLine();
                        Q2();
                    }
                }
                static void learnt()
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations you have officially finished the second tutorial of the Samoan Tutorials Point.");
                    Console.WriteLine("This is what youve learnt this lesson");
                    string[] learnt;
                    learnt = new string[] { "Lelei", "Malie", "Fa'amolemole", "Leaga" };
                    Console.WriteLine("Good = " + learnt[0] + ", Manaia");
                    Console.WriteLine("Sorry = " + learnt[1]);
                    Console.WriteLine("Please = " + learnt[2]);
                    Console.WriteLine("Bad = " + learnt[3]);
                    Console.WriteLine("Press enter to move onto the next tutorial.");
                    Console.ReadLine();
                    LVLTHREE L3 = new LVLTHREE();
                }



            }
        }
    }
}
