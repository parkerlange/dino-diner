﻿/* MeteorMacAndCheese.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    // <summary>
    /// This is the class for the food item MeteorMacAndCheese, it uses the side class for its menu items
    /// </summary>
    public class MeteorMacAndCheese : Side
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
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// This is the constructor for MeteorMacAndCheese
        /// This sets the price, calories, and adds all items to the 
        /// ingredients of the menu item
        /// </summary>
        public MeteorMacAndCheese()
        {
            Price = 0.99;
            Calories = 420;
            ingredients.Add("Macaroni Noodles");
            ingredients.Add("Cheese Product");
            ingredients.Add("Pork Sausage");
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item as well as its size
        /// </summary>
        /// <returns> a string of the menu item </returns>
        public override string ToString()
        {
            return size + " Meteor Mac and Cheese";
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
                return special.ToArray();
            }
        }
    }
}