using ShapeLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary
{
    public class AreaCaculator
    {
        private IShape _shape;

        public AreaCaculator(IShape shape)
        {
            _shape = shape;
        }

        public double CalculateArea()
        {
            return _shape.CalculateArea();
        }
    }
}
