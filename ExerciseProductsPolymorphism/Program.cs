using ExerciseProductsPolymorphism.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciseProductsPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number == 0)
            {
                try
                {
                    Console.Write("Enter the number of products: ");
                    number = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Inform any integer number!!!");
                }
            }

            List<Product> productList = new List<Product>();
            Product product;

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Product #{i}/{number} data: ");

                string type = "";

                do
                {
                    Console.Write("Common, used, or imported (c/u/i): ");
                    type = Console.ReadLine().ToLower();

                } while (type != "c" && type != "u" && type != "i");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case "c":

                        productList.Add(new Product(name, price));

                        break;

                    case "u":

                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        productList.Add(new UsedProduct(name, price, date));

                        break;

                    case "i":

                        Console.Write("Customs fee: ");
                        double customsFee = double.Parse(Console.ReadLine());
                        productList.Add(new ImportedProduct(name, price, customsFee));

                        break;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\t\nPRICE TAGS\n");

            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in productList)
            {
                Console.WriteLine(item.PriceTag());
            }



            Console.ReadKey();
        }
    }
}
