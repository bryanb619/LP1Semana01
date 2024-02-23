using System;

namespace VariousTypes
{
    class Program
    {
        /// <summary>
        ///  Displays in console various variables such as  
        /// integral types, real and bool.
        /// 
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {

            // 2

            // integer
            int i = 10; 
            // 
            int h = 0x18;
            // unassigned integer
            uint j = 5U;

            // long
            long k = 8L; 
            // unassigned long
            ulong n = 3UL; 

            // prints 

            Console.WriteLine
            ($"{i}\n{h}\n{j}\n{k}\n{n}");

            // -------------------------------------------------------------

            // 5

            // heart emoji
            char heart = '\u2764'; 
            // display emoji when supported by console
            Console.WriteLine(heart);  

            // star emoji
            char star = '\u2605';
            // display emoji when supported by console
            Console.WriteLine(star); 


            // 8 Variaveis de tipo real 

            // float
            float gravity = -9.8f; 

            // double
            double height = 1.65;

            // decimal
            decimal z = 3.1415m; 

            Console.WriteLine
            ($"My height is {height}, earth gravity is {gravity} and z = {z}");

            // -----------------------------------------------------------

            // 11
            // 11 Variaveis de tipo bool
            bool detected = false;

            bool connection = true;

            Console.WriteLine
            ($" Server was: {detected} and conection status is: {connection}");
        }
    }
}
