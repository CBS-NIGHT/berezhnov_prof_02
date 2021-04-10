using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Task2
{
    public class MyCollection : NameValueCollection 
    {
        public void PrintByShopper(string shopper)
        {
            var products = GetValues(shopper);

            if (products == null)
            {
                Console.WriteLine("Покупатель {0} не покупал товары.", shopper);
            }
            else
            {
                Console.WriteLine("Товаров покупателя {0} - {1}: ", shopper, products.Length);
                foreach (var product in products)
                {
                    Console.WriteLine("{0} ", product);
                }                
            }
            
            Console.WriteLine(new string('-', 20));
        }

        public void PrintByProduct(string product)
        {
            var shoppers = new List<string>();
            foreach (string shopper in this)
            {
                var products = GetValues(shopper);
                foreach (var p in products)
                {
                    if(p==product)
                    {
                        shoppers.Add(shopper);
                        break;
                    }
                }
            }

            Console.WriteLine("Покупателей продукта {0} - {1}", product, shoppers.Count);
            foreach (var shopper in shoppers)
            {
                Console.WriteLine(shopper);
            }

            Console.WriteLine(new string('-', 20));
        }
    }
}
