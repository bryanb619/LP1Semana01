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

            // 5

            int x = 5, y = 3; 

            string a = "a" + 2; 

            string b = "abc" + x; 

            Console.WriteLine(a); 
            Console.WriteLine(b); 

            // interpolações
            Console.WriteLine($"O valor de e' {x}");
            Console.WriteLine($"{x} + {y} = {x+y}");






        }
    }
}
