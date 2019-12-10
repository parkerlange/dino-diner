/* Author: Parker Lange
 * IMenuItem.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the IMenuItem interface that is implemented by each class
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// a price each item must have
        /// </summary>
        double Price { get;}
        /// <summary>
        /// calories each item must have
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// a string list of ingredients each item must have
        /// </summary>
        List<string> Ingredients { get; }
        
    }
}
