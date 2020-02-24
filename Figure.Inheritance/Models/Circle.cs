using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Inheritance
{
    class Circle : IFigure
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double Area() { return 3.14 * _radius * _radius; }
        public override string ToString()
        {
            return $"Площадь круга = {Area()}";
        }
    }
}
