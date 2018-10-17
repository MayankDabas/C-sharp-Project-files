using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code in multi line comment will not execute.
            //It is just use of if, else statement.

            /*
            Console.WriteLine("Mayank's big giveaway!");
            Console.WriteLine("Choose a door: 1, 2, or 3. ");
            string userValue = Console.ReadLine();

            string message;

            if (userValue == "1")
                message = "You won a car!!!";


            else if (userValue == "2")
                message = "You won a new boat!!!";

            else if (userValue == "3")
                message = "You won a new cat!!!";


            else
            {
                message = "Sorry, we didn't understand. ";
                //message = message + "You lose!!!";
                message += "You lose!!!";
            }
            Console.WriteLine(message);
            Console.ReadLine();
              */

            //It is just other version of code decisions. 
            //Using this syntax will print "boat." if userValue
            //is equal to 1.Otherwise it will print "strand of lint."
            Console.WriteLine("Mayank's big giveaway!!!");
            Console.WriteLine("Choose: 1, 2, or 3");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat." : "strand of lint.";
            /*
            Console.Write("You won a, ");
            Console.Write(message);
            Console.Write(".");
            */

            //Console.WriteLine("You won a " + message);

            //Console.WriteLine("You won a {0}", message);

            //This syntax will print string that is stored in 
            //userValue and message in place of {0} and {1}
            //respectively.
            Console.WriteLine("You entered {0}, therefore you won a {1}", userValue,message);
            Console.ReadLine();
        }
    }
}
