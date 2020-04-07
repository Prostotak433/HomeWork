using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Base number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the Exponent : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2}", a, b, Function(a, b));
        }
        public static int Function(int a1, int b1)
        {
            int result = 1;
            for(int i = 1; i<=b1; i++ )
                result *= a1;
            return result;
         }
    }
}
