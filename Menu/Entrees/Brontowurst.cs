/* Brontowurst.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the class to create the brontowurst to the users selections
    /// inherited from entree base class
    /// </summary>
    public class Brontowurst : Entree
    {

        /// <summary>
        /// This is the public constructor Brontowurst, this sets price and calories
        /// it also adds all of the ingredients to the menu item
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
            ingredients.Add("Brautwurst");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Peppers");
            ingredients.Add("Onion");
        }

        /// <summary>
        /// This HoldBun method is used to disable the bun
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// This holdpeppers method disables peppers
        /// </summary>
        public void HoldPeppers()
        {
            ingredients.Remove("Peppers");
        }

        /// <summary>
        /// this hold onion method disables onions
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item
        /// </summary>
        /// <returns> returns a string of the menu item </returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
