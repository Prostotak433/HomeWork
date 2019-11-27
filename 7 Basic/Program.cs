using System;

namespace _7_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("первое число ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(a, b));
            Console.WriteLine(a == 20 || b == 20 || a + b == 20);   //  21
             
        }

        public static int result(int a, int b)    //20
        {
            if (a > b)
            {
                return (a - b) * 2;
            }
            return b - a;

        }
        
    }
}