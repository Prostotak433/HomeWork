using System;

namespace _2._Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("First number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("third number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int result = num1 * num2 * num3;
            Console.WriteLine($"{result} = {num1} x {num2} x {num3}");  // 6

            Console.WriteLine("First number");
            int num11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number");
            int num22 = Convert.ToInt32(Console.ReadLine());

            
            int resultMinus = num11 - num22;
            int resultMnoj = num11 * num22;
            int resyltDel = num11 / num22;
            Console.WriteLine("{0} + {1} = {2}", num11, num22, num11 + num22);
            Console.WriteLine($"{resultMinus} = {num11} - {num22}");
            Console.WriteLine($"{resultMnoj} = {num11} * {num22}");
            Console.WriteLine($"{resyltDel} = {num11} / {num22}");  // 7


            Console.WriteLine("введите число");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", numb1, 1, numb1 * 1);
            Console.WriteLine("{0} * {1} = {2}", numb1, 2, numb1 * 2);
            Console.WriteLine("{0} * {1} = {2}", numb1, 3, numb1 * 3);
            Console.WriteLine("{0} * {1} = {2}", numb1, 4, numb1 * 4);
            Console.WriteLine("{0} * {1} = {2}", numb1, 5, numb1 * 5);
            Console.WriteLine("{0} * {1} = {2}", numb1, 6, numb1 * 6);
            Console.WriteLine("{0} * {1} = {2}", numb1, 7, numb1 * 7);
            Console.WriteLine("{0} * {1} = {2}", numb1, 8, numb1 * 8);
            Console.WriteLine("{0} * {1} = {2}", numb1, 9, numb1 * 9);
            Console.WriteLine("{0} * {1} = {2}", numb1, 10, numb1 * 10);
        }
    }
}
