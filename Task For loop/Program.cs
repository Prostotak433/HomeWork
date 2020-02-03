using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
          
            Console.Write("Введите начальный диапазон или число : ");
            int mn = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечный диапазон числа : ");
            int mx = Convert.ToInt32(Console.ReadLine());
            for (n = mn; n <= mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
        }
    }
}

