using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the digits of the number {0} is : {1}", num, Sum(num)); 


        }
        public static int Sum(int num1)
        {
            int sum = 0;
            string nums = Convert.ToString(num1);
            for (int i = 0; i < nums.Length; i++)
                sum += int.Parse(nums.Substring(i,1));
            return sum;
        }
    }
}
