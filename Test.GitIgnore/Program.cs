using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a name: ");
            string name = Convert.ToString(Console.ReadLine());
            Welcom(name);
            HaveANiceDay();
        }
        public static void Welcom(string name)
        {
            Console.WriteLine("Welcome Friend" + name+"!");
        }
        public static void HaveANiceDay()
        {
            Console.WriteLine("Have a nice day!");
        }
            

    }
}
