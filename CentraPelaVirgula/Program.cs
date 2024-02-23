using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        static void Main(string[] args)
        {
            // set the culture to invariant
            // reformarts , to . 
            CultureInfo.DefaultThreadCurrentCulture 
            = CultureInfo.InvariantCulture;

            // ask user 
            Console.WriteLine("Insere 4 números reais");

            // readlines of the 4 numbers
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());

            // print the numbers to the console
            Console.WriteLine($"  {a:F2}\n  {b:F2}\n  {c:F2}\n  {d:F2}");


            //Console.WriteLine
            //($"    {a,4:F2}\n  {b,4:F2}\n  {c,4:F2}\n  {d,4:F2}");





        }
    }
}
