using System;
using System.Globalization;

namespace CentraPelaVirgula
{
    class Program
    {
        private static void Main(string[] args)
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


            //string fomated = string.Format
            //("{0:F2}\n{1:F2}\n{2:F2}\n{3:F2}", a, b, c, d);

            //Console.WriteLine(fomated);
            // print the numbers to the console
            //Console.WriteLine($"  {a:F2}\n  {b:F2}\n  {c:F2}\n  {d:F2}");

            Console.WriteLine($"{a,6:F2}");
            Console.WriteLine($"{b,6:F2}");
            Console.WriteLine($"{c,6:F2}");
            Console.WriteLine($"{d,6:F2}");





        }
    }
}
