/* Drink.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// This is the abstract for the drinks on the menu
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// This is the list of ingredients that go into the drink
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// this is the property for ice in the drink. If false, no ice
        /// </summary>
        public bool Ice { get; set; }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// When called, the ice property is set to false 
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false; 
        }

    }
}

