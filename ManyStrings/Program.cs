using System;

namespace ManyStrings
{
    class Program
    {
        private static void Main(string[] args)
        {
            // 4 Exercício

            // path to steve desktop
            string path = "C:\\Users\\Steve\\Desktop"; 

            // testing escape keys and unicode
            string someString = "\r This \t symbol is: \u03A9";


            Console.WriteLine(someString);
            Console.WriteLine(path);
        }
    }
}
