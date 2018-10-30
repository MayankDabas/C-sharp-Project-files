using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excerise6
{
    /// <summary>
    /// Calculating sine and cosine angles.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print an angle of your choice: ");
            float userValue = float.Parse(Console.ReadLine());

            //Calculate and print sine and cosine of an angle.

            float cosine = (float)Math.Cos(userValue * Math.PI / 180);
            float sine = (float)Math.Sin(userValue * Math.PI / 180);

            Console.WriteLine("Cosine = " + cosine);
            Console.WriteLine("Sine = " + sine);

            Console.ReadLine();
        }
    }
}
