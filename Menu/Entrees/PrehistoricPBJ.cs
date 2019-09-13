/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Parker Lange
 */
using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// this is the class for the food item PBJ
    /// </summary>
    public class PrehistoricPBJ
    {
        /// <summary>
        /// this is the bool to set peanut butter
        /// </summary>
        private bool PeanutButter = true;
        /// <summary>
        /// this is the bool to set jelly
        /// </summary>
        private bool Jelly = true;

        /// <summary>
        /// this is the price variable 
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// this is the calories variable
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This is the list of ingredients, bools will add or delete ingreds
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (PeanutButter) ingredients.Add("Peanut Butter");
                if (Jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// this is the constructor setting the price and calories
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }

        /// <summary>
        /// if this peanut butter is false, none will be on pbj
        /// </summary>
        public void HoldPeanutButter()
        {
            this.PeanutButter = false;
        }

        /// <summary>
        /// if this bool is false, it will remove jelly
        /// </summary>
        public void HoldJelly()
        {
            this.Jelly = false;
        }
    }
}
