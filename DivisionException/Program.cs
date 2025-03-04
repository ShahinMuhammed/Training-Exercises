using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionException
{
    class Program
    {
        public int Division(int n1,int n2)
        {
            return n1 / n2;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Program obj = new Program();
                obj.Division(num1, num2);   


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
