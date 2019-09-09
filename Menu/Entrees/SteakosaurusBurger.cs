using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class SteakosaurusBurger
    {
        private bool ketchup, mustard, bun, pickle = true; 
        public double Price { get; set;  }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                return ingredients; 
            }
        }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621; 
        }

        public void HoldBun()
        {
            this.bun = false; 
        }

        public void HoldKetchup()
        {
            this.ketchup = false; 
        }

        public void HoldMustard()
        {
            this.mustard = false; 
        }

        public void HoldPickle()
        {
            this.pickle = false; 
        }
    }
}
