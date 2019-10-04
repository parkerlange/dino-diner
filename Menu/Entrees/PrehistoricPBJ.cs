﻿/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Parker Lange
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the class for the food item PBJ
    /// inherited from entree base class
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// this is the constructor setting the price and calories
        /// it also adds all of the ingredients to the menu item
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
            ingredients.Add("Bread");
            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
        }

        /// <summary>
        /// if this peanut butter is false, none will be on pbj
        /// </summary>
        public void HoldPeanutButter()
        {
            ingredients.Remove("Peanut Butter");
        }

        /// <summary>
        /// if this bool is false, it will remove jelly
        /// </summary>
        public void HoldJelly()
        {
            ingredients.Remove("Jelly");
        }
    }
}
