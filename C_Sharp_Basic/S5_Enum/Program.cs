using System;

namespace S5_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Role:!");
            string input = Console.ReadLine();
            if ((int)Role.Editor == int.Parse(input))
            {
                Console.WriteLine("Your Role Name " + Role.Editor.ToString());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("1");
                Console.ReadLine();
            }
        }
        public enum Role
        {
            Member,
            Admin,
            Boss,
            Editor,
        }
    }
}
