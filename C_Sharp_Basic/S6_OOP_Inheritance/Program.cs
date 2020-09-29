using System;

namespace S6_OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.SetWidth(20);
            rec.SetHeight(30);
            int result;
            result = rec.GetArea();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    public class Shape
    {
        protected int _width;
        protected int _height;
        public void SetWidth(int width)
        {
            _width = width;
        }
        public void SetHeight(int hight)
        {
            _height = hight;
        }
    }
    public class Rectangle : Shape
    {
        public int GetArea()
        {
            return _width * _height;
        }

    }
}
