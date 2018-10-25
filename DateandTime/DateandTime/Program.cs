    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateandTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //We create a DateTime object and stores it
            //a variable called myValue.

            //After that we assign present DateTime in variable 
            //myValue.

            //DateTime myValue = DateTime.Now;

            //We use ToString to convert integer value
            //into string value. It is not necessary
            //in present circumstances but it is a 
            //good habit to do so if you are dealing
            //with strings and integers.

            //Console.WriteLine(myValue.ToString());

            //Using ToShortDateString will cut present time
            //and will display present time only.

            //Console.WriteLine(myValue.ToShortDateString());

            //This will only display present time.

            //Console.WriteLine(myValue.ToShortTimeString());

            //Using ToLongDateString will display
            //longer version of Date.

            //Console.WriteLine(myValue.ToLongDateString());

            //Using ToLongTimeString will dispaly
            //longer version of time.

            //Console.WriteLine(myValue.ToLongTimeString());

            //This type of syntax is konwn as chain methods.
            //.AddDays is called helper method which adds 
            //days, three in the case, to present date
            //and create a new DateTime which is displayed as
            //longer version of time by using ToLongDateString()
            //helper method.

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            //Console.WriteLine(myValue.AddHours(23).ToLongTimeString());

            //If we have to subtract day or time we could use
            //negative sign while using .Add() helper methods.

            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //This will only print month.


            //Console.WriteLine(myValue.Month);

            //Till now we have only deal with present date and
            //time. But, could also use date time of past or
            //even future by providing parameters in parentheses.

            //DateTime myBirthday = new DateTime(2001, 01, 24);

            //Console.WriteLine(myBirthday.ToShortDateString());

            //Console.WriteLine(myBirthday.ToLongDateString());

            //First line of code will convert string into DateTime.
            //Second line will subtract myBirthDay from myAge to 
            //give total time span.
            //Last line print total number of days spend.
         
            DateTime myBirthday = DateTime.Parse("24/01/2001");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
         
            Console.ReadLine();
           
        }
    }
}
