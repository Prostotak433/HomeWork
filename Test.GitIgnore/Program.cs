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
            Console.Write("Введите третье целое число: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Наибольший из трех: " + Math.Max(a, Math.Max(b, c)));
            Console.WriteLine("Найменьшее из трехч: " + Math.Min(a, Math.Min(b, c)));
            
        }
    }
}
