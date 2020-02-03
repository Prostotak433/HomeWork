using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, j;
            Console.Write("Введите количество терминов : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i =1; i<=a;i++)
            {
                j = i * i;
                Console.Write("{0} ", j);
                sum = sum + j;
            }
            Console.Write("Натуральное число квадрата до {0} терминов = {1} ", a, sum);
        }
    }
}
