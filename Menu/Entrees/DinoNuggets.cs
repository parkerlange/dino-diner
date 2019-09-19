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
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// NuggetCount holds the number of nuggets user wants
        /// </summary>
        private int NuggetCount = 6;

        /// <summary>
        /// Constructor for dino nuggets, sets price and calories
        /// </summary>
        public DinoNuggets()
        {
            Price = 4.25;
            Calories = 354;
            for (int i = 0; i < NuggetCount; i++) ingredients.Add("Chicken Nugget");
        }

        /// <summary>
        /// this is used to add a nugget to the order, it updates price, calories, and the count of nuggets
        /// </summary>
        public void AddNugget()
        {
            Price += .25;
            Calories += 59;
            ingredients.Add("Chicken Nugget");
        }
    }
}

