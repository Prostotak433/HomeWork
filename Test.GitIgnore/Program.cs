using System;


namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input days temperature: ");
            int temp = int.Parse(Console.ReadLine());
            if(temp < 0) Console.WriteLine("Freezing weather");
            else if (temp < 10) Console.Write("Very cold weather.");
            else if (temp < 20) Console.Write("Cold weather.");
            else if (temp < 30) Console.Write("Normal in temp.");
            else if (temp < 40) Console.Write("Its Hot.");
            else Console.Write("Its very hot.");
        }
    }
}

