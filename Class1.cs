using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task__2
{
    public abstract class Shape
    {
        public abstract double CalculateArea();

        public abstract bool IsRightTriangle();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public override bool IsRightTriangle()
        {
            return false;
        }
    }

    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public override double CalculateArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override bool IsRightTriangle()
        {
            return sideA * sideA + sideB * sideB == sideC * sideC;
        }
    }

    public class FigureAreaLibrary
    {
        public static double CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }

        public static bool IsRightTriangle(Shape shape)
        {
            return shape.IsRightTriangle();
        }
    }
}
