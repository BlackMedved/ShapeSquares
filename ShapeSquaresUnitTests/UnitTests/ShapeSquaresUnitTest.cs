using Xunit;
using ShapeSquare;
using System;

namespace ShapeSquaresUnitTests
{
    public class ShapeSquareUnitTest
    {
        [Fact]
        public void TestTriangleNullSquare()
        {
            var triangle = new Triangle();
            var square = triangle.Square();
            Assert.Equal(0, square);
        }

        [Fact]
        public void TestCircleNullSquare()
        {
            var triangle = new Circle();
            var square = triangle.Square();
            Assert.Equal(0, square);
        }

        [Fact]
        public void TestShapeTriangleNullSquare()
        {
            IShape shape = new Shape(new Triangle());
            var square = shape.Square();
            Assert.Equal(0, square);
        }

        [Fact]
        public void TestShapeCircleNullSquare()
        {
            IShape shape = new Shape(new Circle());
            var square = shape.Square();
            Assert.Equal(0, square);
        }

        [Fact]
        public void TestTriangleIsNotExists()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(10, 15, 30));
        }

        [Fact]
        public void TestCircleIsNotExists()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Circle(-5));
        }

        [Fact]
        public void TestTriangleSquare1()
        {
            var triangle = new Triangle(3, 4, 5);
            var square = triangle.Square();
            Assert.Equal(6, square);
        }

        [Fact]
        public void TestTriangleSquare2()
        {
            var triangle = new Triangle(10, 15, 20);
            var square = triangle.Square();
            double p = (10.0 + 15.0 + 20.0) / 2;
            double res = Math.Sqrt(p * (p - 10) * (p - 15) * (p - 20));
            Assert.Equal(res, square);
        }

        [Fact]
        public void TestCircleSquare1()
        {
            var triangle = new Circle(3);
            var square = triangle.Square();
            Assert.Equal(Math.PI * Math.Pow(3, 2), square);
        }

        [Fact]
        public void TestCircleSquare2()
        {
            var triangle = new Circle(7.5);
            var square = triangle.Square();
            Assert.Equal(Math.PI * Math.Pow(7.5, 2), square);
        }

        [Fact]
        public void TestIsTriangleRight1()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRight());
        }

        [Fact]
        public void TestIsTriangleRight2()
        {
            var triangle = new Triangle(10, 15, 20);
            Assert.False(triangle.IsRight());
        }
    }
}
