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
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Size");
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
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item as well as its size
        /// </summary>
        /// <returns> a string of the menu item </returns>
        public override string ToString()
        {
            return size + " Water";
        }
        /// <summary>
        /// gets a description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// special is a string array holding the held items user does not want
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
