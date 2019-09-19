/* SteakosaurusBurger.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// this class constructs the burger based on user settings
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// constructor for the burger, sets price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Pickle");
        }

        /// <summary>
        /// if used, the bun will be held
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }

        /// <summary>
        /// if called, no ketchup on burger
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }

        /// <summary>
        /// if called, no mustard on burger
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }

        /// <summary>
        /// if held, no pickles on burger
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }
    }
}
