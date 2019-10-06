/* PterodactylWings.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class is used to order wings based on user selections
    /// inherited from entree base class
    /// </summary>
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// this is the constructor for the wings, price and calories are set
        /// it also adds all of the ingredients to the menu item
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }

        public override string ToString()
        {
            return "Pterodactyl Wings";
        }
    }
}
