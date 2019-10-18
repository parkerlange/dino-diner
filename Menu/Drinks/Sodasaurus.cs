/* Sodasaurus.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the soda drink for the menu
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// the private backing for the soda flavor
        /// </summary>
        private SodasaurusFlavor flavor; 
        /// <summary>
        /// this is the flavor for the soda, gets and returns the flavor user requests
        /// </summary>
        public SodasaurusFlavor Flavor {
            get { return flavor; }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Description");
            }
        }

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

                switch (size)
                {
                    case Size.Small:
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// constructor for the soda, sets price calories size, ice, and ingredeints.
        /// </summary>
        public Sodasaurus()
        {
            Price = 1.50;
            Calories = 112;
            size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Natural Flavors");
            ingredients.Add("Cane Sugar");
            Ice = true; 
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item as well as its size
        /// </summary>
        /// <returns> a string of the menu item </returns>
        public override string ToString()
        {
            return size + " " + Flavor + " Sodasaurus";
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
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
