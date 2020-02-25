using System.Collections.Generic;

namespace Figure.Inheritance
{
    class FigureComparer : IComparer<IFigure>
    {
       
        public double Comparer(IFigure x, IFigure y)
        {
            if (x.Area() > y.Area())
                return 1;
            else if (x.Area() < y.Area())
                return -1;
            else
                return 0;
        }

    }
}
