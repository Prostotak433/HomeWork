using System;

namespace Figure.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure square = new Square(4);
            Console.WriteLine(square.ToString());
        }
    }
}
