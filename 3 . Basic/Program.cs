using System;

namespace _3_._Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-oe число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-oe число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3-oe число");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("4-oe число");
            int num4 = Convert.ToInt32(Console.ReadLine());
            double result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ", num1, num2, num3, num4, result);

            Console.WriteLine("1-oe число");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2-oe число");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3-oe число");
            int numb3= Convert.ToInt32(Console.ReadLine());
            Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
        numb1, numb2, numb3, ((numb1 + numb2) * numb3), (numb1 * numb2 + numb2 * numb3));
        }
    }
}
