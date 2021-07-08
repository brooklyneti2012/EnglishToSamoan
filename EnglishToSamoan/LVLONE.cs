using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishToSamoan
{
    public class LVLONE
    {
        public LVLONE()
        {
            Console.Title = "Level one";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            //welcomes user to tutorial 1
            Console.WriteLine("Welcome to Tutorial 1/5 of the Samoan tutorial");
            Console.WriteLine("In this tutorial you will be learning simple Samoan words");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The greeting used most in the Samoan language is 'Talofa'(tah - loh - fah)");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Talofa();
            static void Talofa()
            {
                Console.Clear();
                Console.WriteLine("Try writing 'Talofa' yourself.");
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
                    Console.WriteLine("That is incorrect, press enter to try again.");
                    Talofa();
                }
            }





            

            Console.Clear();
            Console.WriteLine("The next word we will try to learn is Goodbye");
            Console.WriteLine("press enter to continue");
            Console.ReadKey();
            Console.WriteLine("The Samoan way to say Goodbye is 'Tofa' (toh - fah)");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            tryagain();
            //retry method for TOFA 
            static void tryagain()
            {
                Console.Clear();
                Console.WriteLine("Try writing 'tofa' yourself.");

                string tofa = Console.ReadLine();
                tofa = tofa.ToLower();

                if (tofa == "tofa")
                {
                    Console.WriteLine("Nice job we will now move onto the next word to learn is Tama and Teine.");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();

                }
                else
                {
                    Console.Clear();
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
            again();

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
            AGAIN();

            static void AGAIN()
            {
                string teine = Console.ReadLine();
                teine = teine.ToLower();

                if (teine == "teine")
                {
                    Console.WriteLine("Nice job, we will now move onto the End Of Tutorial Quiz");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    ONEQUIZ O1 = new ONEQUIZ();
                }
                else
                {
                    Console.WriteLine("That was incorrect, try again");
                    AGAIN();
                }
            }


            
        }
    }
}

