﻿/* MezzorellaSticks.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    // <summary>
    /// This is the class for the food item MezzorellaSticks, it uses the side class for its menu items
    /// </summary>
    public class MezzorellaSticks : Side
    {
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
                        Price = 0.99;
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// This is the constructor for MezzorellaSticks
        /// This sets the price, calories, and adds all items to the 
        /// ingredients of the menu item
        /// </summary>
        public MezzorellaSticks()
        {
            Price = 0.99;
            Calories = 540;
            ingredients.Add("Breading");
            ingredients.Add("Cheese Product");
            ingredients.Add("Vegetable Oil");
        }

        public override string ToString()
        {
            return size + " Mezzorella Sticks";
        }
    }
}