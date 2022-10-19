using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSquare
{
    public class Shape : IShape
    {
        private IShape _shape;

        public Shape(IShape shape)
        {
            _shape = shape;
        }

        public double Square()
        {
            return _shape.Square();
        }
    }
}
