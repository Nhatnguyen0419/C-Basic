using System;

namespace Delegate
{
    class Program
    {
        public delegate void PriceChangeHandler(decimal oldPrice, decimal newPrice);
        public class Product
        {
            private decimal _price;
            public event PriceChangeHandler PriceChanged;
            public decimal Price
            {
                get { return _price; }


                set
                {
                    if (_price == value)
                    {
                        return;
                    }
                    decimal oldPrice = _price;
                    _price = value;
                    if (PriceChanged != null)
                    {
                        PriceChanged(oldPrice, _price);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Price = 1500;
            product.PriceChanged += product_PriceChanged;
            product.Price = 3000;
            Console.ReadKey();
        }
        public static void product_PriceChanged(decimal oldPrice,decimal newPrice)
        {
            Console.WriteLine("Old price: {0}", oldPrice);
            Console.WriteLine("New price: {0}", newPrice);
        }
    }
}
