using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1989;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2}",
                myCar.Make,
                myCar.Model,
                myCar.Year, 
                myCar.Color);
            Car myCar_2 = new Car();

            myCar_2.Make = "NewMobiles";
            myCar_2.Model = "Cutlas Supreme";
            myCar_2.Year = 2001;
            myCar_2.Color = "Black";

            Console.WriteLine("{0} {1} {2}" , 
                myCar_2.Make , 
                myCar_2.Model , 
                myCar_2.Year , 
                myCar_2.Color);

            decimal value = DetermineMarketValue(myCar);
            decimal value_2 = DetermineMarketValue(myCar_2);

            //Console.WriteLine("{0:C}" , value);
            //Console.WriteLine("{0:C}" , value_2);

            Console.WriteLine("{0:C}" , myCar.DetermineMarketValue());
            Console.WriteLine("{0:C}" , myCar_2.DetermineMarketValue());
            Console.ReadLine();
        }

        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100000.75M;
            return carValue;
        }
    }
    
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
            {
                carValue = 100000.75M;
            }

            else
            {
                carValue = 75000.75M;
            }
            return carValue;
        }
    }
}
