using System;

namespace VariousTypes
{
    /// <summary>
    /// Basic programs that outputs the value of various types of variables
    /// </summary>
    class Program
    {
        /// <summary>
        ///  Displays in console various variables values such as integer, char 
        ///  real and bool types while also using interpolation to out-
        ///  put the values of the variables except for the char variables
        /// </summary>
        /// <param name="args">Not used</param>
        private static void Main(string[] args)
        {

            // 2

            // integer type variables
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
            ($"{i} \n{h} \n{j} \n{k} \n{n}");

            // -------------------------------------------------------------

            // 5

            // char type variables with unicode values
            // heart emoji
            char heart = '\u2764'; 
            // display emoji when supported by console
            Console.WriteLine(heart);  

            // star emoji
            char star = '\u2605';
            // display emoji when supported by console
            Console.WriteLine(star); 


            // 8 real type variables

            // float
            float gravity = -9.8f; 

            // double
            double height = 1.97;

            // decimal
            decimal z = 3.3465m; 

            Console.WriteLine
            ($"My height is {height}, earth gravity is {gravity} and z = {z}");

            // -----------------------------------------------------------

            // 11
            // 11 Bool type variables
            bool detected = false;

            bool connection = true;

            Console.WriteLine
            ($" Server was: {detected} and conection status is: {connection}");
        }
    }
}
