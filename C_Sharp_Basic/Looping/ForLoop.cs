using System;
using System.Collections.Generic;
using System.Text;

namespace Looping
{
    public class ForLoop
    {
       static void Main(string[] args)
        {
            //Console.WriteLine("Please Enter Number:");
            //string a = Console.ReadLine();
            //int b = int.Parse(a);
            ////for (int i = 0; i < b; i++)
            ////{
            ////    Console.WriteLine("this is index: " + i);
            ////}

            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int item in arr){
                Console.WriteLine(" stt {0}",item);
            }
            Console.ReadKey();


        }
    }
}
