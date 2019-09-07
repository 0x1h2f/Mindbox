using System;

namespace MindBox.Library
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Square
        {
            get => Math.PI * Radius * Radius;
        }
    }
}
