using System;

namespace GeometryLibrary
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public bool IsRightAngled()
        {
            return Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
                   Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2) ||
                   Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2);
        }
    }

    public class ShapeCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}