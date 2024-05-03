using ShapeLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Shapes
{
    public class Triangle : IShape
    {
        private double _sideA;

        private double _sideB;

        private double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;

            _sideB = sideB;

            _sideC = sideC;
        }

        public double CalculateArea()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        public bool IsRightAngled()
        {
            double a2 = Math.Pow(_sideA, 2);

            double b2 = Math.Pow(_sideB, 2);

            double c2 = Math.Pow(_sideC, 2);

            return Math.Abs(a2 + b2 - c2) < 0.0001 || Math.Abs(a2 + c2 - b2) < 0.0001 || Math.Abs(b2 + c2 - a2) < 0.0001;
        }

    }
}
