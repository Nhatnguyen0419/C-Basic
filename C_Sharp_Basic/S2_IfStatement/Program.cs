using System;

namespace S2_IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            string number = Console.ReadLine();
            int a = Convert.ToInt32(number);
            if (a % 4 == 1)
            {
                Console.WriteLine("1");
            }
            else if (a % 4 == 2)
            {
                Console.WriteLine(2);
            }
            else if( a% 4==3)
            {
                Console.WriteLine(03);
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.ReadKey();
        }
    }
}
