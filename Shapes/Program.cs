using System;

namespace Shapes
{
    public class Shape
    {
        protected Location c;
        public string ToString()
        {
            return "Diện tích hình tròn";
        }
        public double Area()
        {
            return 0.000;
        }
        public double Perimeter()
        {
            return 0.000;
        }   
     }
    class Rectangle : Shape
    {
        private double side2;
        private double side1;

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public double Area()
        {
            return Side1 * Side2;
        }
    }
    class Circle : Shape
    {
        private double radius;

        public double Radius { get => radius; set => radius = value; }

    }
    public class Location
    {
        private double x, y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
    }
    class TestShape
    {
        static void Main()
        {
            Circle circle = new Circle();
            circle.Radius = 80.8;
            Console.WriteLine(circle.Radius);
            Rectangle rectangle = new Rectangle();
            rectangle.Side1 = 5;
            rectangle.Side2 = 10;
            rectangle.Area();
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine(rectangle.Area());
            Location location = new Location();
            location.X = 10.0;
            location.Y = 5.2;
            Console.WriteLine(location.X +" "+ location.Y);
        }
    }
  }
