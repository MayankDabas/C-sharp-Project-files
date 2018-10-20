using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            Console.WriteLine("The Name Game");

            Console.WriteLine("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.WriteLine("In which city you were born in? ");
            string cityName = Console.ReadLine();

           //We call ReverseString method with some input
           //parameter that will be executed as per the code
           //written in ReverseString methods.
           ReverseString(firstName);
           ReverseString(lastName);
           ReverseString(cityName);

           //To display result we call DisplayResult 
           //with input parameter.
           DisplayResult(ReverseString(firstName),
                          ReverseString(lastName),
                          ReverseString(cityName));

            Console.WriteLine();
            
           DisplayResult(ReverseString(firstName)+" "+
                         ReverseString(lastName)+" "+
                         ReverseString(cityName));


            Console.ReadLine();
        }

        private static void DisplayResult()
        {
            throw new NotImplementedException();
        }

        //We create a helper method with an input parameter
        //string message.
        //We have used 'string' in place of 'void' because
        //we want this method to return value back to us.

        private static string ReverseString(string message)
        {
            //We created an array of characters and convert
            //the string that is stored in message to messagerArray
            //as an  array.
            char[] messageArray = message.ToCharArray();
            //After that we call Array.Reverse method to
            //reverse the charcters stored in messageArray.
            Array.Reverse(messageArray);


            //This will return value after concatination
            //of characters in messageArray.
            return String.Concat(messageArray);
        }

        //We create another method of name DisplayResult with input 
        //parameter. This will print our result to console window
        //after call it.
        private static void DisplayResult(string reversedFirstName,
                                          string reversedLastName,
                                          string reversedcityName)
        {
            Console.WriteLine(String.Format("{0} {1} {2}",
                              reversedFirstName,
                              reversedLastName,
                              reversedcityName));

        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine(message);
        }

    }
}

