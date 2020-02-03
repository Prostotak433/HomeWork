using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, j=1;
            Console.Write("Введите количество терминов : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i =1; i<=a;i++)
            {
                sum += j;
                Console.Write("{0} ", j);
                j = j * 10 + 1;
            }
            Console.Write("Натуральное число квадрата до {0} терминов = {1} ", j, sum);
        }
    }
}
