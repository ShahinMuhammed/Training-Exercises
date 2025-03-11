using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int> {1,2,3,4,5,6,7,8,9,10 };
            var evenNumbers = number.Where(n=>n%2==0).ToList() ;
            foreach(var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
