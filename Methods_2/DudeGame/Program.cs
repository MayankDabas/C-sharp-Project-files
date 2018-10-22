using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DudeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool DisplayMenu = true;

            while (DisplayMenu)
            {
                DisplayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("i. Option 1");
            Console.WriteLine("ii. Option 2");
            Console.WriteLine("iii. Option 3");
            Console.WriteLine("iv. Exit");

            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                PrintingNumbers();
                return true;
            }

            else if (userValue == "2")
            {
                GuessingNumbers();
                return true;
            }

            else if (userValue == "3")
            {
                Console.Clear();

                Console.WriteLine("Reversed String Game!!!");

                Console.WriteLine("Enter your first name?");
                string firstName = Console.ReadLine();

                Console.WriteLine("Enter your last name?");
                string lastName = Console.ReadLine();

                Console.WriteLine("In  which city your were born in?");
                string cityName = Console.ReadLine();

                Console.WriteLine(" ");

                ReversedString(firstName);
                ReversedString(lastName);
                ReversedString(cityName);

                DisplayResult(ReversedString(firstName),
                              ReversedString(lastName),
                              ReversedString(cityName));

                Console.ReadLine();

                return true;
            }

            else if (userValue == "4")
            {
                return false;
            }

            else
            {
                wrongOption();
                return true;
            }
        }

        private static void DisplayResult()
        {
            throw new NotImplementedException();
        }

        private static void PrintingNumbers()
        {
            Console.Clear();

            Console.WriteLine("Printing Numbers!!!");

            Console.Write("Type any number you want: ");
            int userValue = int.Parse(Console.ReadLine());
            
            int counter = 1;

            while (counter < userValue + 1)
            {
                Console.WriteLine(counter);
                counter++;
            }
            
            /*
            for (int i = 1; i < userValue + 1; i++)
            {
                Console.WriteLine(i);
            }
            */

            Console.ReadLine();
        }

        private static void GuessingNumbers()
        {
            Console.Clear();

            Console.WriteLine("Guessing Numbers!!!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            bool incorrect = true;
            int guessed = 0;

            /*
            while (incorrect)
            {
                Console.Write("Guess any Number between 1 to 10: ");
                int guessedNumber = int.Parse(Console.ReadLine());
                guessed++;

                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("You guessed right and you took {0} guess!!!",guessed);
                    incorrect = false;
                }

                else
                {
                    Console.WriteLine("You guessed wrong!!!");

                }
            }
           */

            //do while is used when if we want perform 
            //a particular loop atleast once.

            do
            {
                Console.WriteLine("Guess any number between 1 to 10: ");
                int userValue = int.Parse(Console.ReadLine());
                guessed++;

                if (userValue == randomNumber)
                {
                    incorrect = false;
                }

                else
                {
                    Console.WriteLine("You guessed wrong!!!");
                }
            } while (incorrect);
            Console.WriteLine("You guessed right and you took {0} guesses!!!",guessed);

            Console.ReadLine();
        }

        private static string ReversedString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return String.Concat(messageArray);
        }

        private static void DisplayResult(string DisplayfistName, string DisplaylastName, string DisplaycityName)
        {
            Console.Write("{0} {1} {2}",DisplayfistName ,DisplaylastName, DisplaycityName);
        }

        private static void wrongOption()
        {
            Console.WriteLine("Error!");
            Console.WriteLine("There is no such option in main menu." +
                "Please check it again.");
            Console.WriteLine("Press enter to return to main menu.");

            Console.ReadLine();
        }
    }
}
