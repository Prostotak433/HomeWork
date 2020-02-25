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
        const double PI = 3.14;
        public double Area() { return PI * _radius * _radius; }
        public override string ToString()
        {
            return $"Area of a Circle = {Area()}";
        }
    }
}
