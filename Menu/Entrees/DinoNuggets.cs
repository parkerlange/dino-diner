/* DinoNuggets.cs
 * Author Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This is the class for the food item DinoNuggets
    /// </summary>
    public class DinoNuggets
    {
        /// <summary>
        /// NuggetCount holds the number of nuggets user wants
        /// </summary>
        private int NuggetCount = 6; 
        /// <summary>
        /// this sets the price of the food item
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// this sets the calories of the food item
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This is the ingredients the user wants. If they want extra nuggets,they will get extras
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < NuggetCount; i++) ingredients.Add("Chicken Nugget");
                return ingredients; 
            }
        }

        /// <summary>
        /// Constructor for dino nuggets, sets price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 354;
        }

        /// <summary>
        /// this is used to add a nugget to the order, it updates price, calories, and the count of nuggets
        /// </summary>
        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            this.NuggetCount++;        }
    }
}
