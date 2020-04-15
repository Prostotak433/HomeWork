using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 1st number: ");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("{0} is a positive number", a);
            else
                Console.WriteLine("{0} is a not potsitive number",a); 
               


        }
    }
}
