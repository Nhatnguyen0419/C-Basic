using System;
using System.IO;

namespace FileStreamEx
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("text.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++)
            {
                fileStream.WriteByte((byte)i);
            }
            fileStream.Position = 0;
            Console.WriteLine("Write Ok.");
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(fileStream.ReadByte() + "\t");
            }
            fileStream.Close();
            Console.ReadKey();

        }
    }
}
