using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = {"BMW", "Lambo", "Benz"};
            Console.WriteLine(cars[0]);

            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            Array.Sort(cars);
            foreach(String i in cars)
            {
                Console.WriteLine(i);
            }
        }
    }
}
