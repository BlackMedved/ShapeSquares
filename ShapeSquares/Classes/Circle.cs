using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSquare
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус круга не может быть отрицательным.");
            }
            Radius = radius;
        }

        public double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
