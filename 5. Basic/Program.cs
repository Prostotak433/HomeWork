using System;

namespace _5._Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(del("w3resource", 1));
            Console.WriteLine(del("w3resource", 9));
            Console.WriteLine(del("w3resource", 0));

            Console.WriteLine("Градусов по цельсию");
            int cel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кельвину = {0}", cel + 273);
            Console.WriteLine("Фаренгейту = {0}", cel * 18 / 10 + 32);

        }
        public static string del(string str, int n)
        {
            return str.Remove(n, 1);
        }
        
    }
}
