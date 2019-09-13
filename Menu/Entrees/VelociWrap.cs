/* VelociWrap.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// this is a class to construct the food item velociwrap
    /// </summary>
    public class VelociWrap
    {
        /// <summary>
        /// indicates adding dressing or not
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// indicates adding lettuce or not
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// indicates adding cheese or not
        /// </summary>
        private bool cheese = true; 
        /// <summary>
        /// this is a double for adding prices of item
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// this is the uint for the calories of item 
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// this is the ingredients list, based on bool values, ingredients will add or not
        /// </summary>
        public  List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// this is the constructor for the wrap, it sets price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// method for holding dressing from the wrap
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false; 
        }
        /// <summary>
        /// method to hold lettuce, and not add to the wrap
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false; 
        }
        /// <summary>
        /// method to hold cheese from the wrap
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false; 
        }
    }
}
