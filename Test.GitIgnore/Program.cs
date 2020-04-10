using System;

namespace Test.GitIgnore
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            int area = square.Area(20,40);
            int perimetr = square.Perimetr(20, 40);
            Console.WriteLine("Area {0} ", area);
            Console.WriteLine("Perimetr {0} ", perimetr);
               
        }
    }
}
