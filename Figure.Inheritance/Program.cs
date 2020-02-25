using System;
using System.Collections.Generic;

namespace Figure.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure square = new Square(4);
            IFigure rectangle = new Rectangle(4, 3);
            IFigure triangle = new Triangle(2, 4);
            IFigure circle = new Circle(4);

            var figures = new List<IFigure> { new Square(4), new Rectangle(4, 3), new Triangle(2, 4), new Circle(4) };
            foreach(var figure in figures)
            {
                Console.WriteLine(figure.ToString());
            }
            figures.Sort(new FigureComparer());
            foreach(var figure in figures)
            {
                Console.WriteLine(figure.ToString());
            }
            Console.Read();
        }
        
    }
}
