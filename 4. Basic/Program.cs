using System;

namespace _4._Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваш возраст");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вроде вы выглядите старше {0}", x);  // 11

            Console.WriteLine("Введите число");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}{0}", y);
            Console.WriteLine("{0} {0} {0} {0}", y);
            Console.WriteLine("{0}{0}{0}{0}", y);
            Console.WriteLine("{0} {0} {0} {0}", y);       //12

            Console.WriteLine("Введите число");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", z);
            Console.WriteLine("{0}   {0}", z);
            Console.WriteLine("{0}   {0}", z);
            Console.WriteLine("{0}   {0}", z);
            Console.WriteLine("{0}{0}{0}", z);      //13
        }
    }
}
