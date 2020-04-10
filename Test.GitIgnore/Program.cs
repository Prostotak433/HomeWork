using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassNumber classNumber = new ClassNumber();
            classNumber.n = 11;
            StructNumber structNumber = new StructNumber();
            structNumber.n = 12;
            Console.WriteLine(structNumber.n);
            Console.WriteLine(classNumber.n);
        }
    }
}
