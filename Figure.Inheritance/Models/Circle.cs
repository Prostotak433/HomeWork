using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Inheritance
{
    class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
                _radius = radius;
        }
        public double Area() { return 3.14 * _radius * _radius; }
    }
}
