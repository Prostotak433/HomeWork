using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Number2 classNumber = new Number2();
            classNumber.x = 7500;
            classNumber.y = 9500;
            Console.Write("Assign in Class:  x: {0}, y: {1}", classNumber.x, classNumber.y);
            Number structNumber = new Number();
            structNumber.x = 750;
            structNumber.y = 950;
            Console.Write("\nAssign in Struct:  x: {0}, y: {1}", structNumber.x, structNumber.y);
        }
    }
}
