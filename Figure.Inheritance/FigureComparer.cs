using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Inheritance
{
    class FigureComparer : IComparer<IFigure>
    {
        public double Compare(IFigure square, IFigure rectangle, IFigure triangle, IFigure circle)
        {
            if (square.Area() > rectangle.Area() && square.Area() > triangle.Area() && square.Area() > circle.Area())
                return 1;
            else if (square.Area() < rectangle.Area() && square.Area() < triangle.Area() && square.Area() < circle.Area())
                return 1;
            else
                return 0;
        }
    }
}
