using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndString
{
    class Program
    {
        static void Main(string[] args)
        {

            //Build in method Math

            int a = 10,b=16;
            double c = 99.99;

            Console.WriteLine(Math.Max(a, b));
            Console.WriteLine(Math.Min(a, b));
            Console.WriteLine(Math.Sqrt(b));
            Console.WriteLine(Math.Round(c));

            //String


            String word = "This is a string";

            String name = "random";

            Console.WriteLine("The lenght of the string is :" + word.Length);
            Console.WriteLine(word.ToUpper());
            Console.WriteLine(word.ToLower());

            Console.WriteLine($"This is {name} word");  //interpolation

            int charPos = name.IndexOf("d");
            string strpos = name.Substring(charPos);
            Console.WriteLine(strpos);                  //Substring after the specified index position


        }
    }
}
