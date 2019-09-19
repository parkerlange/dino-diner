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
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// this is the constructor for the wings, price and calories are set
        /// </summary>
        public PterodactylWings()
        {
            Price = 7.21;
            Calories = 318;
            ingredients.Add("Chicken");
            ingredients.Add("Wing Sauce");
        }
    }
}
