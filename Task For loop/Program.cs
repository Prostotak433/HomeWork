using System;

namespace Task_For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в двоичном виде : ");
            int a = Convert.ToInt32(Console.ReadLine());
            double a1= a, sum = 0, i = 0;
            while(a!=0)
            {
                int d = a % 10;
                sum = sum + d * Math.Pow(2, i);
                a = a / 10;
                i++;
            }
            Console.Write("Введенное число в двоичной системе {0} имеет вид в 10 -ой системе {1} ", a1,sum);
        }    
    }
}


