﻿/* Sodasaurus.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
            set { flavor = value; }
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
    }
}
