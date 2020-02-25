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

            IFigure[] figures = new IFigure[] { square, rectangle, circle,triangle };
            Array.Sort(figures, new FigureComparer());

            foreach (IFigure figure in figures)
            {
                Console.WriteLine(figure.Area());
            }
        }
    }
}
