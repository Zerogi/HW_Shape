using System;
namespace HW_Shape
{
    class Circle : Shape
    {
        public string Name { get; set; }
        public double Radius { get; set; }
        public new double Perimetr { get; set; }
        public new double Square { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
            Perimetr = 2 * Math.PI * Radius;
            Square = Math.PI * (Radius * Radius);
        }
    }
}
