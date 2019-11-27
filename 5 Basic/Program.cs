using System;

namespace _5_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int l = 0;
            Console.Write("Введите строу");
            str = Console.ReadLine();
            if(str.Length >0)
            {
                var a = str.Substring(0, 1);
                Console.WriteLine(a + str + a);
            }
        }
    }
}
