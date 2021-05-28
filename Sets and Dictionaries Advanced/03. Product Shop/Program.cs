using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> foodShopsInfo =
                new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shopName = input[0];
                
                if (shopName == "Revision")
                {
                    break;
                }

                string product = input[1];
                double price = double.Parse(input[2]);

                if (foodShopsInfo.ContainsKey(shopName) == false)
                {
                    foodShopsInfo.Add(shopName, new Dictionary<string, double>());
                }
                
                foodShopsInfo[shopName].Add(product, price);
            }

            foodShopsInfo = foodShopsInfo
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var kvp in foodShopsInfo)
            {
                Dictionary<string, double> products = kvp.Value;

                Console.WriteLine($"{kvp.Key}-> ");

                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
