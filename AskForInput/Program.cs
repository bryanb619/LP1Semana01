using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {

            // Request user input for an integer
            Console.WriteLine("Inseri um número inteiro");

            // Read the input and convert to int
            int intInput = int.Parse(Console.ReadLine());

            // Request user input for a real number
            Console.WriteLine("Inseri um número real");

            // Read the input and convert to float
            float realInput = float.Parse(Console.ReadLine());

            // print the result of the sum 
            Console.WriteLine($"{intInput + realInput}");
        }
    }
}
