using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_for_4_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            IFigure square = new Square();
            IFigure rectangle = new Rectangle();
            IFigure triangle = new Triangle();
            IFigure circle = new Circle();

            var figures = new List<IFigure>() { new Square(), new Rectangle(), new Triangle(), new Circle() };
            foreach (IFigure figure  in figures)
            {
                figure.Info();
            }
        } 
    }
}
