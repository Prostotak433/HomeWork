using System;
using System.Collections.Generic;
using System.Text;

namespace Task_for_4_figures
{
    class Rectangle : IFigure
    {
        double z, a = 3, b = 4;
        public double Area()
        {
            z = a * b;
            return z;
        }
        public void Info()
        {
            Console.WriteLine("Площадь Прямоугольник = {0} ", z);
        }
    }
}
