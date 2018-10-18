using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace understandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code in /*..*/ will not execute.
            //It is one way of initilizing and
            //printing arrays.

            /*
             //This type of syntax is used for creating 
             //arrays.Using [] after int tells c sharp to 
             //create an array of datatype integer.
             //We name this integer numbers and after
             //that we ask c sharp to  create an integer
             //with a space of five bits in which we will 
             //store an integer in each bit.
             //int[] numbers = new int[5];

            //Below, we are storing integers in each
            //bits after providing array number an 
            //appropiate index.

            //In c sharp or any other you know
            //,we will consider 0 in our counting 
            //process ,i.e, we will start with 0 
            //instead of one.
            numbers[0] = 24;
            numbers[1] = 25;
            numbers[2] = 26;
            numbers[3] = 27;
            numbers[4] = 28;
            

            //We will print any particular 
            //integer (say 24) by calling it
            //by its name ,i.e, numbers
            //giving it's index ,i.e, '1'.
            Console.WriteLine(numbers[1]);

            //numbers.Length will print total
            //number of integers that are stored
            //in each bit.
            Console.WriteLine(numbers.Length);
            Console.ReadLine();
            */

            //int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            //It is not compulsory to set numbers of bit you want to
            //chip off from computers memory.
            //This particular type of syntax will allow c sharp compiler 
            //to decide how much memory is needed to be chipped off from
            //memory.
        
            string[] name = new string[] {"Mayank Dabas","Promila Dabas", "Mohan Singh Dabas"};

            //Below, we create an integer 'i' and initilize it an value zero.
            //Next we setup an condition that 'i' should be smaller than Length
            //of array ,i.e, '3' in this case.
            //Till this condition is satisfied we want integer i to increment by
            //'1'.
             for (int i = 0; i < name.Length; i++)
             {
                //We print array named 'name' and providing index 'i'.
                Console.WriteLine(name[i]);
             }
            


            /*
             //In this we use 'foreach' and creating
             //a tempory variable called names and store
             //array variable name in names.
             foreach (string names in name)
            {
                Console.WriteLine(names);
            }
            */

           // int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0,};

            /*
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            */

            /*
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            */

            /*Console.Write("Enter your name: ");

            string name = Console.ReadLine();

            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);

            foreach (char nameArray in charArray)
            {
                Console.Write(nameArray);
            }*/

            Console.ReadLine();
         
        }
    }
}
