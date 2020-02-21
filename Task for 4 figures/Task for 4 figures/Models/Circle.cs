using System;
using System.Collections.Generic;
using System.Text;

namespace Task_for_4_figures
{
    class Circle
    {
        double z, r = 3;
        public double Area()
        {
            z = 3.14 * r*r;
            return z;
        }
        public void Info()
        {
            Console.Write("Площадь Круга = {0} ", z);
        }
    }
}
