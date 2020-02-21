using System;
using System.Collections.Generic;
using System.Text;

namespace Task_for_4_figures
{
    class Square : IFigure
    {
        double z, a = 3;
        public double Area()
        {
            z = a * a;
            return z;
        }
        public void Info()
        {
            Console.WriteLine("Площадь Квадрата = {0} ", z);
        }
    }
}
