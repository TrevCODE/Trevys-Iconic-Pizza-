using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrevysIconicPizza
{
    internal class Drink
    {
        String type;
        bool custom;
        decimal price;
        char size;
        List<String> ingredients;

        public Drink(string type, List<string> ingredients)
        {
            this.type = type;
            this.ingredients = ingredients ?? new List<string>();
        }

        /*
         *Coca Cola
Diet Coke
Ginger Ale
Sprite
         */

        public decimal calculatePriceForDrinks()
        {
            if (type.Equals("Coca cola", StringComparison.OrdinalIgnoreCase)
                || type.Equals("Diet coke", StringComparison.OrdinalIgnoreCase)
                || type.Equals("Ginger ale", StringComparison.OrdinalIgnoreCase)
                || type.Equals("Sprite", StringComparison.OrdinalIgnoreCase))
            {
                Price = 2.99m;
            }
            else if (type.Equals("vanilla milkshake", StringComparison.OrdinalIgnoreCase)) 
            {
                Price = 7.99m;
            }
            else if (type.Equals("strawberry milkshake", StringComparison.OrdinalIgnoreCase)) 
            {
                Price = 8.99m;
            }
            else if (type.Equals("chocolate milkshake", StringComparison.OrdinalIgnoreCase)) 
            {
                Price = 8.99m;
            }
            

            return Price;
        }


        public String Type
        {
            get { return type; }
            set { type = value; }
        }

        public decimal Price { get { return price; } set { price = value; } }

        public List<String> Ingredients { get { return ingredients; } set { ingredients = value; } }
    }
}
