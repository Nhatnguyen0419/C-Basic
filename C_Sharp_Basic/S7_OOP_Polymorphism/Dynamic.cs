using System;

namespace S7_OOP_Polymorphism
{
    class Dynamic
    {
        static void Main(string[] args)
        {
            Caller caller = new Caller();
            Rectangle rectangle = new Rectangle(5, 6);
            Triangle triangle = new Triangle(7, 8);
            int recArea = caller.GetArea(rectangle);
            Console.WriteLine(recArea);

            int triArea = caller.GetArea(triangle);
            Console.WriteLine(triArea);
            Console.ReadKey();
        }
        public class Shape
        {
            protected int _width;
            protected int _height;
            protected Shape(int width, int height)
            {
                _width = width;
                _height = height;

            }
            public virtual int GetArea()
            {
                Console.WriteLine("This is Area:");
                return 0;
            }
        }
        public class Rectangle : Shape
        {
            public Rectangle(int width, int height) : base(width, height)
            {

            }
            public override int GetArea()
            {
                Console.WriteLine(" Rec Area: ");
                return _width * _height;
            }
        }
        public class Triangle : Shape
        {
            public Triangle(int a, int h) : base(a, h)
            {

            }
            public override int GetArea()
            {
                Console.WriteLine(" TRi Area: ");
                return (_width * _height)/ 2;
            }
        }
        public class Caller
        {
            public int GetArea(Shape shape)
            {
                int area = shape.GetArea();
                return area;
            }
        }

    }
}
