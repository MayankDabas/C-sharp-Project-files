using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //'\' or back slash is an escape sequence.
            //Using '\' will alow you to use "" within 
            //the string ,i.e, our output will look like
            //My "so-called" life.

            //string myString = "My \"so-called\" life.";

            //'\n' is a new line character and it will split 
            //this whole sentence into two new lines.

            //string myString = "What if I need\na new line?";

            //If we actually wants to print \ in our console app
            //we need to use double back slash ,i.e, '\\'.

            //string myString = "Go to your c:\\ drive.";

            //Another way to print \ into console app is to
            //use @ before you  start writing your string.

            //string myString = @"Go to your c:\ drive.";

            //String.Format replaces the format items in a specified string
            //with the string representation of two specified object. 

            //string myString = string.Format("{0} = {1}", "first", "second");

            //This will format '123.45' as currency and display it on 
            //console application.

            //string myString = string.Format("{0:C}", 123.45);

            //This syntax will format '.123' as percentage and display it on
            //console application.

            //string myString = string.Format("{0:P}", .123);

            //This type of syntax put comma and decimal to appropiate
            //place.

            //string myString = string.Format("{0:N}", 1234567890);

            //This syntax is used to create coustom format.
            //For example a phone number which have different 
            //area code and different way of presenting in different
            //countries.

            //string myString = string.Format("Phone number: {0:(###) ####-####}", 11123456789);


            //string myString = " That summer we took threes across the board  ";

            //Every datatype have it's own builtin functionality.
            //.Substring hepls in displaying strings after certain
            //characters.

            //myString = myString.Substring(6, 14);

            //Will print message in upper case.

            //myString = myString.ToUpper();

            //Will replace character with other character.

            //myString = myString.Replace(" ", "--");

            //Using this syntax we can remove any numbers of
            //characters.

            //myString = myString.Remove(6, 14);

            //This will trim off the extra spaces in the strings.

            /*
            myString = string.Format("Length before: {0} -- Length after: {1}", 
                myString.Length, 
                myString.Trim().Length);
            */

            //This piece of code is correct but 
            //not really efficient as it drains 
            //alot of memory.

            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            //More efficient way is to use
            //String builder class.

            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                //Instead of concatnating, we use
                //Append which does the same work 
                //as concating the strings.
                myString.Append("--");
                myString.Append(i);
            }
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
