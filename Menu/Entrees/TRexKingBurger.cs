/* TRexKingBurger.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This is used to create the burger for the menu 
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// constructor for the burger, sets price and calories
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
            for (int i = 0; i < 3; i++) ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Lettuce");
            ingredients.Add("Tomato");
            ingredients.Add("Onion");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Mayo");
        }
        /// <summary>
        /// if called, the bun is not on burger
        /// </summary>
        public void HoldBun()
        {
            ingredients.Remove("Whole Wheat Bun");
        }
        /// <summary>
        /// if called, lettuce is not on burger
        /// </summary>
        public void HoldLettuce()
        {
            ingredients.Remove("Lettuce");
        }
        /// <summary>
        /// if called, tomato is not on burger
        /// </summary>
        public void HoldTomato()
        {
            ingredients.Remove("Tomato");
        }
        /// <summary>
        /// if called, onion is not on burger
        /// </summary>
        public void HoldOnion()
        {
            ingredients.Remove("Onion");
        }
        /// <summary>
        /// if called, pickle is not on burger
        /// </summary>
        public void HoldPickle()
        {
            ingredients.Remove("Pickle");
        }
        /// <summary>
        /// if called, ketchup is not on burger
        /// </summary>
        public void HoldKetchup()
        {
            ingredients.Remove("Ketchup");
        }
        /// <summary>
        /// if called, mustard is not on burger
        /// </summary>
        public void HoldMustard()
        {
            ingredients.Remove("Mustard");
        }
        /// <summary>
        /// if called, mayo is held from burger
        /// </summary>
        public void HoldMayo()
        {
            ingredients.Remove("Mayo");
        }
    }
}
