using System;

namespace AskForInput
{
    /// <summary>
    ///  Basic program, asks for a integer and a real number
    ///  and finally presents the sum of both
    /// </summary>
    class Program
    {
        /// <summary>
        /// Simple program thats asks for an integer 
        /// and a real number, converts them to int and float
        /// presents the sum of the int with the float previously inserted
        /// </summary>
        /// <param name="args">Not used</param> <summary>
        private static void Main(string[] args)
        {
            // Request user input for an integer
            Console.WriteLine("Insere um número inteiro");

            // Read the input and convert to int
            int intInput = int.Parse(Console.ReadLine());

            // Request user input for a real number
            Console.WriteLine("Insere um número real");

            // Read the input and convert to float
            float realInput = float.Parse(Console.ReadLine());

            // print the result of the sum 
            Console.WriteLine($"{intInput + realInput}");
        }
    }
}
