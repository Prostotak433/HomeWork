using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int b = int.Parse(Console.ReadLine());
            int number = 20;
            var res1 = Math.Abs(a - number);
            var res2 = Math.Abs(b - number);
            Console.WriteLine(res1 == res2 ? 0 : (res1 > res2 ? b : a));

        }
    }
}
