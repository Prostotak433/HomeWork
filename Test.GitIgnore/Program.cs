using System;

namespace w3resource.Task.ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число в 10 системе ");
            string num = Convert.ToString(Console.ReadLine());
            long temp = Convert.ToInt64(num, 2);
            Console.WriteLine("{0} : двоичная : {1}", num, Convert.ToString(temp, 8));

            Console.WriteLine("Конвертируем в двоичную систему счисления:\n");
            string num1 = Convert.ToString(Console.ReadLine());
            long temp1 = Convert.ToInt64(num1, 8);
            Console.WriteLine("{0} : восьмеричная : {1}", num1, Convert.ToString(temp1, 2));

        }
    }
}
