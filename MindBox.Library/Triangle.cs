using System;

namespace MindBox.Library
{
    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double Side1, double Side2, double Side3)
        {
            SideA = Side1;
            SideB = Side2;
            SideC = Side3;
        }

        public double Square
        {
            get
            {
                double HalfPerimeter = (SideA + SideB + SideC) / 2;

                return Math.Sqrt(HalfPerimeter * (HalfPerimeter - SideA) * (HalfPerimeter - SideB) * (HalfPerimeter - SideC));
            }
        }

        public bool IsRightAngled
        {
            get
            {
                double SquaredSideA = SideA * SideA;
                double SquaredSideB = SideB * SideB;
                double SquaredSideC = SideC * SideC;

                return (SquaredSideA == SquaredSideB + SquaredSideC) || (SquaredSideB == SquaredSideA + SquaredSideC) || (SquaredSideC == SquaredSideA + SquaredSideB);
            }
        }
    }
}
