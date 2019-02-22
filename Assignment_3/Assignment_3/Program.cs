using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ProductList = new List<Product>() {
                new Product("lettuce",10.5,50,"Leafy green"),
                new Product("cabbage",20,100,"Cruciferous"),
                new Product("pumpkin",30,30,"Marrow"),
                new Product("cauliflower",10,25,"Cruciferous"),
                new Product("zucchini",20.5,50,"Marrow"),
                new Product("yam",30,50,"Root"),
                new Product("spinach",10,100,"Leafy green"),
                new Product("broccoli",20.2,75,"Cruciferous"),
                new Product("garlic",30,20,"Leafy green"),
                new Product("silverbeet",10,50,"Marrow")
            };

            Console.WriteLine("the total number of product in the list : " + ProductList.Count);

            ProductList.Add(new Product("Potato", 10, 50, "Root"));
            Console.WriteLine("\nthe list of all products including potato : ");
            foreach (Product product in ProductList)
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine("\nthe total number of products including potato : {0}", ProductList.Count);

            Console.WriteLine("\nthe products of which have the type Leafy green are : ");
            foreach (Product product in ProductList.FindAll(product => product.Type == "Leafy green"))
            {
                Console.WriteLine(product.ToString());
            }
            Console.WriteLine();

            ProductList.RemoveAll(Product => Product.Name == "garlic");
            Console.WriteLine("\nthe total number of products excluding garlic : {0}", ProductList.Count);

            ProductList.Find(product => product.Name == "cabbage").Quantity += 50;
            Console.WriteLine("\nthe final quantity of cabbage in the inventory : {0}", ProductList.Find(product => product.Name == "cabbage").Quantity);

            double total = 0;
            double lettucePrice = ProductList.Find(product => product.Name == "lettuce").Price;
            double zucchiniPrice = ProductList.Find(product => product.Name == "zucchini").Price;
            double broccoliPrice = ProductList.Find(product => product.Name == "broccoli").Price;
            total += lettucePrice + (2 * zucchiniPrice) + broccoliPrice;

            Console.WriteLine("\nthe round figure that user need to pay for purchasing 1 kg lettuce, 2 kg zucchini, 1 kg broccoli is : {0}\n", Math.Round(total));

            Console.ReadKey();
        }
    }
}