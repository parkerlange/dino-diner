/* VelociWrap.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// this is a class to construct the food item velociwrap based off an inherited Entree class
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// this is the constructor for the wrap, it sets price and calories
        /// it also adds all of the ingredients to the menu item
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }

        /// <summary>
        /// method for holding dressing from the wrap
        /// </summary>
        public void HoldDressing()
        {
            ingredients.Remove("Ceasar Dressing");
        }

        /// <summary>
        /// method to hold lettuce, and not add to the wrap
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Romaine Lettuce");
        }

        /// <summary>
        /// method to hold cheese from the wrap
        /// </summary>
        public void HoldCheese()
        {
            ingredients.Remove("Parmesan Cheese");
        }
    }
}
