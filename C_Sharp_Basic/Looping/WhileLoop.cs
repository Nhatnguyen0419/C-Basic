using System;
using System.Collections.Generic;
using System.Text;

namespace S3_Looping
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter your number:");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            int i = 1;
            // Kiểm tra điều kiện rồi mới thực thi
            //while (i < b)
            //{
            //    Console.WriteLine("this is index {0}", i);
            //    i += 1;
            //}

            //Thực thi câu lênh rồi mới kiểm tra điều kiện
            do
            {
                Console.WriteLine(" this is function: " + i);
                i++;
            } while (i < b);
            Console.ReadKey();
        }
    }
}
