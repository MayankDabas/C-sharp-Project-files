using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingDocumentation
{
    /// <summary>
    /// Reading Documentation
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demostrates reading documentation
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            float cosine = (float)Math.Cos(45 * Math.PI / 180);

            //Calculate and print cosine of 45 degrees

            Console.WriteLine("Cosine of 45 degree is: " + cosine);
            Console.ReadLine();
        }
    }
}
