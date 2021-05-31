using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EnglishToSamoan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Samoan tutorial");

            Console.WriteLine("Pick a number between 1 and 5 depending on your skill with the Samoan language, and then press enter to continue");

            int answer;
            int.TryParse(Console.ReadLine(), out answer);

            switch (answer)
            {
                case 5:
                    FVE();
                    break;
                case 4:
                    FOUR();
                    break;
                case 3:
                    THREE();
                    break;
                case 2:
                    TWO();
                    break;
                case 1:
                    ONE();
                    break;
                    

            }
                
            static void FVE()
            {

            }

            static void FOUR()
            {

            }

            static void THREE()
            {

            }

            static void TWO()
            {
                
            }

            static void ONE()
            {
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
                }
               else
                {
                    Console.WriteLine("That is incorrect, try again.");
                    retry();
                }

                //retry method for Talofa 
                static void retry()
                {
                  Console.WriteLine("Try writing 'Talofa' yourself.");

                    string talofa = Console.ReadLine();
                    talofa = talofa.ToLower();

                    if (talofa == "talofa" )
                    {
                        Console.WriteLine("Nice job we will now move onto the next word to learn.");
                        
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
                    }
                    else
                    {
                        Console.WriteLine("Ooh, try again remeber the word is 'TOFA' ");
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
                    Console.WriteLine("That is incorrect try again.");
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
                }









                Console.ReadKey();
                
            }
            
        }
    }
}
