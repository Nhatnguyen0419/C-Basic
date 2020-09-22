using System;

namespace S1_ConvertDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert
            string name = "1904";
            int id = Convert.ToInt32(name);

            string date = "04/19/1998";
            DateTime dateTime = Convert.ToDateTime(date);


            Console.WriteLine(id);
            Console.WriteLine(date);
            Console.WriteLine(dateTime.ToLongDateString());

            //Parse ( Khi có ký tự không phải là số thì sẽ không Parse được)  112345hahhhhaha
            string a = "112345";
            int b = int.Parse(a);
            Console.WriteLine(b);

            string c = "true";
            bool d = bool.Parse(c);
            Console.WriteLine(d);

            //Try Parse
            string number = "19041998abc";
            int resultNumber;
            bool parseResult = int.TryParse(number, out resultNumber);
            Console.WriteLine(parseResult);

            Console.ReadKey();

        }
    }
}
