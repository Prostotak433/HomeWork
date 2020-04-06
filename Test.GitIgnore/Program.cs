using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Rever(ref a, ref b);
            Console.WriteLine("Now the 1st number is : {0}, and the 2nd number is : {1}", a, b);
        }
        public static void Rever(ref int a, ref int b)
        {
            int c = 0;
            c = a;
            a = b;
            b = c;
            
        }
    }
}
