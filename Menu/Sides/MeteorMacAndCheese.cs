using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MeteorMacAndCheese : Side
    {
        public MeteorMacAndCheese()
        {
            this.Size = Size.Small; 
            this.Price = 0.99;
            this.Calories = 420;
            this.Ingredients.Add("Macaroni Noodles");
            this.Ingredients.Add("Cheese Product");
            this.Ingredients.Add("Vegtable Oil");
        }
    }
}
