/* Side.cs
 * Author: Nathan Bean
 * Modified: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is our base abract Side class
    /// </summary>
    public abstract class Side : IMenuItem, INotifyPropertyChanged
    {

        /// <summary>
        /// An event handler for PropertyChanged for fields hold jelly/peanut butter
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// method call for the property changed call
        /// </summary>
        /// <param name="propertyName">this is the property being changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

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
        public virtual List<string> Ingredients { get { return new List<string>(ingredients.ToArray()); } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

    }
}
