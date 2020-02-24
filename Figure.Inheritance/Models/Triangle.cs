using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Inheritance
{
    class Triangle : IFigure
    {
        private double _base, _height;
        public Triangle(double height, double baseA)
        {
            _height = height;
            _base = baseA;
        }
        public double Area() { return (_base * _height) / 2; }
        public override string ToString()
        {
            return $"Площадь треугольника = {Area()}";
        }
    }
}
