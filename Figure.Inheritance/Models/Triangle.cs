using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Inheritance
{
    class Triangle
    {
        private double _base, _height;
        public Triangle(double height, double baseA)
        {
            _height = height;
            _base = baseA;
        }
        public double Area() { return (_base * _height) / 2; }
    }
}
