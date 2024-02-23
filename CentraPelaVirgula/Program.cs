using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    /// <summary>
    /// Basic program, reads 4 numbers and outputs the numbers 
    /// with 2 decimal places
    /// </summary>
    class Program
    {
        /// <summary>
        /// Requests 4 real numbers from the user
        /// converts each number to a float inserted by the user
        /// outputs the numbers with 2 decimal places (F2) while also
        /// right aligned 6 spaces
        /// </summary>
        /// <param name="args">Not used</param>
        private static void Main(string[] args)
        {
            // set the culture to invariant
            // reformats , to . 
            CultureInfo.DefaultThreadCurrentCulture 
            = CultureInfo.InvariantCulture;

            // ask user for 4 real numbers
            Console.WriteLine("Insere 4 números reais");

            // read lines of the 4 numbers and convert to float
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());

            /*
            Outputs each number with 2 decimal places using (F2) formatting
            Aligns each number with 6 positions to the right
            \n is used to enter new line
            */
            Console.WriteLine($"{a,6:F2} \n{b,6:F2} \n{c,6:F2} \n{d,6:F2}");

        }
    }
}
