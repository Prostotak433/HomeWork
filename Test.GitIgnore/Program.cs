using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number : ");
            int num = int.Parse(Console.ReadLine());
            if (number(num))
                Console.WriteLine(num + " is a prime number");
            else
                Console.WriteLine(num + " is not a prime number");
        }
        public static bool number(int num1)
        {
            var result = true;
            {
                if(num1 > 1)
                {
                    for(var i = 2; i < num1; i++)
                    {
                        if (num1 % i == 0)
                        {
                            result = false;
                            break;
                        }
                    }
                }
                else
                {
                    result = false;
                }
                return result;
            }
        }
    }
}
