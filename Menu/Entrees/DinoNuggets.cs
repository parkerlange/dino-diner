/* DinoNuggets.cs
 * Author Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the class for the food item DinoNuggets
    /// inherited from entree base class
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// NuggetCount holds the number of nuggets user wants
        /// </summary>
        private int NuggetCount = 6;

        /// <summary>
        /// Constructor for dino nuggets, sets price and calories
        /// it also adds all of the ingredients to the menu item
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
            this.NuggetCount++; 
            Price += .25;
            Calories += 59;
            ingredients.Add("Chicken Nugget");
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item
        /// </summary>
        /// <returns> returns a string of the menu item </returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
        /// <summary>
        /// gets a description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// special is a string array holding the held items user does not want
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                for (int i = 0; i >= NuggetCount; i++)
                {
                    if (i > 6)
                        special.Add(i-6 + " Extra Nuggets");
                }
                return special.ToArray();
            }
        }
    }
}

