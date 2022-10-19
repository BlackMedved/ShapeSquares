using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSquare
{
    public class Triangle : IShape
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        public Triangle()
        {
            A = B = C = 0;
        }

        public Triangle(double a, double b, double c)
        {
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("Треугольник не существует. Треугольник существует тогда и только тогда, когда сумма двух любых его сторон больше третьей.");
            }
            A = a;
            B = b;
            C = c;
        }

        public double Square()
        {
            double P = (A + B + C) / 2;
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }

        public bool IsRight()
        {
            return Math.Pow(A, 2) == (Math.Pow(B, 2) + Math.Pow(C, 2)) || Math.Pow(B, 2) == (Math.Pow(A, 2) + Math.Pow(C, 2)) || Math.Pow(C, 2) == (Math.Pow(A, 2) + Math.Pow(B, 2));
        }
    }
}
