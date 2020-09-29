using System;
using System.Collections.Generic;
using System.Text;

namespace S6_OOP_Inheritance
{
    class ProgramBase
    {
        static void Main(string[] args)
        {

            BaseClass bc = new BaseClass(30,25);
            double result;
            result = bc.GetArea();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    class BaseClass : Rec
    {
        public BaseClass(int width, int height) : base(width, height)
        {

        }
        public double GetCost()
        {
            double cost;
            cost = GetArea();
            return cost;
        }
    }
    public class Rec
    {
        protected int _width;
        protected int _height;
        public Rec (int width,int height)
        {
            _width = width;
            _height = height;
        }
        public double GetArea()
        {
            return _width * _height;
        }

    }
}
