﻿using System;

namespace Task_4_Cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
                {
                    Console.WriteLine("Числа не в диапазоне");
                }
                else
                {
                    Console.WriteLine($"{num1}*{num2} = {num1 * num2}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
