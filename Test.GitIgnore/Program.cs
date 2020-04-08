using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of Fibonacci Series : ");
            decimal a = decimal.Parse(Console.ReadLine());
            
            for(int i = 0; i < a; i++)
            {
                Console.Write(Fibonach(i) + "  ");
            }
            Console.ReadLine();
        }
        public static decimal Fibonach(decimal a1)
        {
            decimal num1 = 0;
            decimal num2 = 1;
            for(int i = 0; i < a1; i++)
            {
                decimal  temp = num1;
                num1 = num2;
                num2 = num1 + temp;
            }
            return num1;
        }
    }
}
