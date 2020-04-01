using System;

namespace w3resource.Task.ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Число в 10 системе ");
            string Oct = Convert.ToString(Console.ReadLine());
            Console.WriteLine("{0} : восьмеричная : {1}", Oct, Convert.ToInt64(Oct, 8));
        }
    }
}
