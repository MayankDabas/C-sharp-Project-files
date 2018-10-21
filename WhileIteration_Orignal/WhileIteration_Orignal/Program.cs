using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration_Orignal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool DisplayMenu = true;

            while (DisplayMenu == true)
            {
               DisplayMenu = MainMenu();
            }
        }  
      

        private static bool MainMenu()
        {

            Console.Clear();

            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");

            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                PrintingNumbers();
                return true;
            }

            else if (userValue == "2")
            {
                GuessingGame();
                return true;
            }

            else if (userValue == "3")
            {
                return false;
            }

            else
            {
                FalseOption();
                return true;
            }
        }

        private static void PrintingNumbers()
        {

            Console.Clear();
            
            Console.WriteLine("Printing Numbers!!!");
            Console.Write("Type any number of your choice: ");

            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < number + 1)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {

            Console.Clear();

            Console.WriteLine("Guessing Game!!!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1,11);

            bool incorrect = true;
            int guesses = 0;

            do
            {
                Console.Write("Guess any number between 1 to 10: ");
                int userValue = int.Parse(Console.ReadLine());
                guesses++;

                if (userValue == randomNumber)
                {
                    incorrect = false;
                }

                else
                {
                    Console.WriteLine("You guessed wrong!!!");
                }

            } while (incorrect);

            Console.WriteLine("You guessed right and it took you {0} guesses!!!",guesses);           

            Console.ReadLine();
        }

        private static void FalseOption()
        {
            Console.WriteLine("Sorry, Dude you probably have entered wrong option!!!");
            Console.WriteLine("Make sure that you choose right option next time.");
            Console.WriteLine("Press Enter to return back to your options.");
            Console.ReadLine();
        }
    }
}
