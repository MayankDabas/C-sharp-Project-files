using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //This how we call a method.
            HelloWorld();
            Console.ReadLine();
        }

        //Snytax given below is a way
        //one creates a method.

        //This whole syntax means that we create
        //a method of name HellWorld.

        //To execute code written in code bolck
        //of method named HelloWorld, we call it
        //in our main method.

        private static void HelloWorld()
        {
            Console.WriteLine("Hello, World!!!");
        }
        

    }
}
