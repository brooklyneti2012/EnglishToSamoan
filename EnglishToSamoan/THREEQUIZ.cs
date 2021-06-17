using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class THREEQUIZ
    {
        public THREEQUIZ()
        {
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
                Console.WriteLine("Which of the following answers mean Monday in Samoan");
                Console.WriteLine("A. Aso Gafua");
                Console.WriteLine("B. Aso Lulu");
                Console.WriteLine("C. Aso Lua");
                Console.WriteLine("D. Aso Sa");
                Console.WriteLine("Type a letter and press enter to continue.");
                string answer = Console.ReadLine();
                answer = answer.ToLower();


            }
        }
    }
}
