using System;
using System.Collections.Generic;
using System.Text;

namespace Figure.Inheritance
{
    class Rectangle
    {
        private double _sideA, _sideB;
        public Rectangle(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }
        public double Area() { return _sideA * _sideB; }
    }
}
