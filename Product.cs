using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {   
        Random random = new Random();
        public string Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Iva { get; set; }

        public Product(string name, decimal price, int iva)
        {
            this.Name = name;
            this.Price = price;
            this.Iva = iva;
            this.Id = this.SetId();
        }

        private string SetId()
        {
            string pseudoId = random.Next(1, 999999).ToString();
            int numberDigits = pseudoId.Length;
            while (numberDigits < 8)
            {
                pseudoId = "0" + pseudoId;
                numberDigits = pseudoId.Length;
            }
            return pseudoId;
        }

        public decimal IvaPrice()
        {
            decimal increment = this.Price * this.Iva / 100;
            return this.Price + increment;
        }

        public string FullName()
        {
            return this.Id + this.Name;
        }
    }
}
