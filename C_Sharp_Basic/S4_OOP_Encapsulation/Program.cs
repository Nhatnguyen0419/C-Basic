using System;

namespace S4_OOP_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person();
            //person1.Person1("nhat");
            //Console.WriteLine(person1.SayName());
            //Console.ReadKey();

            Rec area = new Rec();
            area.SetSize(30, 20);
            Console.WriteLine(area.GetArea());

            int result = area.GetPerimeter();
            Console.WriteLine(result);


            //Calculation cal = new Calculation();
            //int x=200;
            //int y = 300;
            //int resultFM = cal.FindMax(x, y);
            //Console.WriteLine(resultFM);

            Calculation cal = new Calculation();
            int resultFM;
            resultFM = cal.FindMax(20, 30);
            Console.WriteLine(resultFM);

            Console.ReadKey();


        }
        public class Rec
        {
            private int _height;
            private int _width;
            public void SetSize(int height, int width)
            {
                _height = height;
                _width = width;
            }
            public int GetArea()
            {
                return _height * _width;
            }
            public int GetPerimeter()
            {
                return (_height + _width) * 2;
            }

        }

        public class Calculation
        {
            private int _number1;
            private int _number2;
            public int FindMax(int number1, int number2)
            {
                _number1 = number1;
                _number2 = number2;
                int result;
                if (number1 > number2)
                {
                    result = number1;
                    return result;
                }
                else
                {
                    result = number2;
                    return result;
                }
            }
        }
        class Person
        {

            private string _name;

            public Person()
            {

            }
            public Person(string name)
            {
                _name = name;
            }
            public void Person1(string name)
            {
                _name = name;
            }


            public void Run()
            {
                Console.WriteLine("Person is running die...");
            }
            public string SayName()
            {
                return _name;
            }
        }

    }
}
