/* Water.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the water option for the menu
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// this is the bool to see if the user adds lemon to their water.
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// This is a Size enumerations used to set the size of order
        /// </summary>
        private Size size;

        /// <summary>
        /// This is an override for the Size, based on the size, the calories
        /// and the price are set differently. We use a private backing for the size 
        /// in order to modify it 
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// constructor for water. Price, calories, size, ice, and ingredients are set in here
        /// </summary>
        public Water()
        {
            Price = 0.10;
            Calories = 0;
            size = Size.Small;
            ingredients.Add("Water");
            Ice = true; 
        }

        /// <summary>
        /// if called, the lemon bool is true, and lemon is added to the ingredients.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }

        public override string ToString()
        {
            return size + " Water";
        }
    }
}
