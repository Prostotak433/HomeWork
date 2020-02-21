using System;
using System.Collections.Generic;
using System.Text;

namespace Task_for_4_figures
{
    class Triangle
    {
        double z, a = 3, b = 4;
        public double Area()
        {
            z = (a * b)/2;
            return z;
        }
        public void Info()
        {
            Console.Write("Площадь Треугольника = {0} ", z);
        }
    }
}
