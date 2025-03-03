using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Guessing the number");
            //Console.Write("Enter the number between(1 - 100):");



            //int val = 78;

            //    while (true)
            //    {
            //        Console.Write("Enter the number between(1 - 100):");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //    if (num <= 0 || num > 100)
            //        {
            //            Console.WriteLine("Range out of bound");

            //        }
            //    else
            //    {
            //        if (num >= 70 && num <= 77)
            //        {
            //            Console.WriteLine("Close");

            //        }
            //        else if (num >= 1 && num <= 30)
            //        {
            //            Console.WriteLine("Too Low");
            //        }
            //        else if (num >= 85 && num <= 100)
            //        {
            //            Console.WriteLine("Too high");
            //        }
            //        else if (num >= 79 && num <= 85)
            //        {
            //            Console.WriteLine("Close");
            //        }
            //        else if (num >= 31 && num <= 60)
            //        {
            //            Console.WriteLine("Low");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Congrats you have guessed the correct number : {val}");
            //            break;
            //        }

            //    }

            //Random random = new Random();
            //int target = random.Next(1, 101);

            //Switch statement


            //Console.Write("Enter a value:");
            //int day = Convert.ToInt32(Console.ReadLine());


            //    switch (day)
            //    {
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;


            //while loop

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //Console.ReadKey();


            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}



            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 4)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    if (i == 7)
            //    {
            //        break;
            //    }
            //}




            Random random = new Random();

            int target = random.Next(1, 101);


            Console.WriteLine("Guess the number between 1 - 100"); 
            while (true)
            {
                Console.Write("Enter a number:");
                int input = Convert.ToInt32(Console.ReadLine());
                if (target > input)
                {
                    Console.WriteLine("Too Low");
                }
                else if (target < input)
                {
                    Console.WriteLine("Too high");

                }
                else
                {
                    Console.WriteLine("Congrats you guessed correctly "+input);
                    break;
                }
            }


        }

    }
}
