/* PterodactylWings.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// this class is used to order wings based on user selections
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// this variable sets the price of the wings
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// this variable sets the calories of wings
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// this is the list of ingredients, the user cannot modify these
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients; 
            }
        }

        /// <summary>
        /// this is the constructor for the wings, price and calories are set
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318; 
        }
    }
}
