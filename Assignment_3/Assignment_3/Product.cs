using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;
        public string Type;
   
        public Product(string Name, double Price, int Quantity, string Type)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Type = Type;
        }

        public override string ToString()
        {
            return "\nName : " + this.Name + "\nPrice : " + this.Price + "\nQuantity : " + this.Quantity + "\nType : " + this.Type + "";
        }
    }
}
