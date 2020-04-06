using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[5];
            Console.WriteLine("Input 5 elements in the array : ");
            for(int j = 0; j < 5; j++)
            {
                Console.Write("element - {0} : ", j);
                mass[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The sum of the elements of the array is : {0}", Sum(mass));
        }
       public static int Sum(int[] mass)
        {
            int result = 0;
            for (int i = 0; i < mass.Length; i++)
                result += mass[i];
            return result;
        }
    }
}
