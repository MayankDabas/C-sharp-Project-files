using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, this application will help" +
                "you in calculating distance between two points" +
                "and angle between those two points!!!");
            
            //Prompting user to input coordinates of both the points.
        
            Console.Write("Enter first x value: ");

            //float.Parse will convert user value, which is 
            //in form of string, into float.
            float point1X = float.Parse(Console.ReadLine());

            Console.Write("Enter first y value: ");
            float point1Y = float.Parse(Console.ReadLine());

            Console.Write("Enter second x value: ");
            float point2X = float.Parse(Console.ReadLine());

            Console.Write("Enter second y value: ");
            float point2Y = float.Parse(Console.ReadLine());

            //Calculates base and height of triangle.
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            //Calculates distance between two points, which is
            //hypotenuse, by using Math.sqrt().
            float distanceBetweenPoints = (float)Math.Sqrt((deltaX * deltaX + deltaY * deltaY));

            //Prints output to console window.
            Console.WriteLine("Distance between two points: " + distanceBetweenPoints);

            //Finds angle we would have to move in radians.
            float angleInRadians = (float)Math.Atan2(deltaY , deltaX);
            //Convert radians into angle.
            float angleInDegree = angleInRadians * 180 / (float)Math.PI;

            Console.WriteLine("Angle between two points: " + angleInDegree);

            //Waits for user to press any key to ackonwledge and 
            //close the console windows.
            Console.ReadLine();
        }
    }
}
