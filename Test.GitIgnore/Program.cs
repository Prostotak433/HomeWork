using System;

namespace w3resource.Task.ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0, j,i, n1pos, n1;
            Console.Write("Enter a number to convert : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n1pos = n1;
            j = 1;

            for (i = n1; i > 0; i = i / 8)
            {
                result = result + (i % 8) * j;
                j = j * 10;
                n1 = n1 / 8;
            }
            Console.Write("\nThe Octal of {0} is {1}.\n\n", n1pos, result);
        }
    }
}
