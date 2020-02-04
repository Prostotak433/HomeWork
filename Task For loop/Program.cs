using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.Write("Введите начальный номер диапазона: ");
            int nmin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите конечный номер диапазона: ");
            int nmax = Convert.ToInt32(Console.ReadLine());
            for(int i=nmin; i<=nmax; i++)
            {
                sum = 0;
                for(int j=2; j<=i/2;j++)
                {
                    if (i % j == 0)
                    {
                        sum++;
                        break;
                    }
                }
                if (sum == 0 && i != 1)
                    Console.Write("{0} ", i);
            }
            Console.Write("\n");
        }
    }
}


