﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            Car.MyMethods();

            /*
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Superme";
            myCar.Year = 1989;
            myCar.Color = "Silver";
            
            Car myOtherCar;
            myOtherCar = myCar;

            Console.WriteLine("{0} {1} {2} {3}" ,
                myOtherCar.Make ,
                myOtherCar.Model ,
                myOtherCar.Year ,
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            myOtherCar = null;
            /*
            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);
            */
            /*
            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");
            Console.WriteLine("{0} {1} {2} {3}" , myThirdCar.Make ,
                myThirdCar.Model , 
                myThirdCar.Year , 
                myThirdCar.Color);

            myCar = null;
            */


            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }


       //Ways to initiate construtors. 
       /* public Car()
        {

            //You could load from a configuration file,
            //a database , etc.

            Make = "nissan";
        }

        public Car(string make , string model , int year , string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        */

       public static void MyMethods()
        {
            Console.WriteLine("Called the static MyMethods.");
        }
    }
}
