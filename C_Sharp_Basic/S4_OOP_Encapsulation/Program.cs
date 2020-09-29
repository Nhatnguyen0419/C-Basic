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
            Console.ReadKey();

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


        }
    }
}
