/* Side.cs
 * Author: Nathan Bean
 * Modified: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Size enumeration. This is used to determine the size of the side the user wants
    /// </summary>
    public enum Size
    {
        Small,
        Medium, 
        Large
    }
    
    /// <summary>
    /// this is our base abract Side class
    /// </summary>
    public abstract class Side
    {
        protected List<string> ingredients = new List<string>();
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

    }
}
