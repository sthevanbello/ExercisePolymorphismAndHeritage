using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProductsPolymorphism.Entities
{
    class Product
    {
        public string Name { get; set; }
        protected double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"Name: {Name} - {Price.ToString("C")}";
        }
    }
}
