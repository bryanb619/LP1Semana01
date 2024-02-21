using System;

namespace VariousTypes
{
    class Program
    {
        /// <summary>
        ///  Displays in console various integral types
        /// 
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            // integer
            int i = 10; 
            // unassigned integer
            uint j = 5U;

            // long
            long k = 8L; 
            // unassigned long
            ulong n = 3UL; 

            // sbyte
            sbyte sb = 110; 

            // byte
            byte b = 234; 

            // char
            char c = 'a';

            // prints 
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine(n);
            Console.WriteLine(sb);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
