using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Source code in /*..*/ will not executed as 
            //it is commented out and it is for understading 
            //porpose only.


            //We declare variable after calling suitable datatype. 
            //Example of datatypes are int, char, float, bool etc.

            //Here we declare variables 'x' and 'y' of type integer(int stands for integer)
            /*
            int x;
            int y;
            */

            //We use assignment operator '=' and assign 
            //variable 'x' a value '7'.
            //In next line we assign 'x + 3'
            //to variable 'y'
            /*
            x = 7;
            y = x + 3;
            */

            //In first line we print variable 'y' to console
            //window. 
            //This statement waits for input from user. 
            //If we don't use this statement, console 
            //window will not wait for input from user
            //and will close automatically like a flash
            //of light.
            /*
            Console.WriteLine(y);
            Console.ReadLine();
            */
                        
            Console.WriteLine("What is your name?");

            //Here we are asking user for input.
            Console.Write("Type your first name: ");

            //Here we declare another variable of string type.
            //Your first name that you typed, will store in
            //variable myFirstName.
            string myFirstName;

            //Here Console.ReadLine(); will retrive your first
            //name from variable myFirsgtName.
            myFirstName = Console.ReadLine();

            

            Console.Write("type your last name: ");
            string myLastName = Console.ReadLine();

            //This is know as concatinating of string.
            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();

        }
    }
}
