using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        int nuggetCount = 6; 
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < nuggetCount; i++) ingredients.Add("Chicken Nugget");
                return ingredients; 
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            this.nuggetCount++;        }
    }
}
