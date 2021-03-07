using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProductsPolymorphism.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base( name,  price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"Name: {Name} - {TotalPrice().ToString("C")} - (Customs Fee: {CustomsFee.ToString("C")})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
