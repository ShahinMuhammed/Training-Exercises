using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLambda
{
    class Program
    {
        delegate int Operations(int num1,int num2);

        public int Addition(int n1,int n2)
        {
            return n1 + n2;
        }
        public int Substraction(int n1, int n2)
        {
            return n1 - n2;
        }
        public int Multiplication(int n1, int n2)
        {
            return n1 * n2;
        }
        public int Division(int n1, int n2)
        {
            return n1 / n2;
        }

        static void Main(string[] args)
        {
            //Program obj = new Program();
            //Console.Write("Enter the first number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Operations sum = obj.Addition;
            //Operations differnece = obj.Substraction;
            //Operations Product = obj.Multiplication;
            //Operations Divison = obj.Division;

            //Console.WriteLine(sum(num1, num2));
            //Console.WriteLine(differnece(num1, num2));
            //Console.WriteLine(Product(num1, num2));
            //Console.WriteLine(Divison(num1, num2));




        }
    }
}
