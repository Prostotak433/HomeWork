using System;

namespace _1.Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Alexandra Abramovna");  // 1

            Console.WriteLine(1+1);   // 2

            Console.WriteLine(5/3);  // 3

            Console.WriteLine(-1+4*6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2); //4

            int num1, num2, num3;
            Console.WriteLine("Введите 1-ое число");
            num1 = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите 2-ое число");
            num2 = (Convert.ToInt32(Console.ReadLine()));
            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}
