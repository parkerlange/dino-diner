/* MeteorMacAndCheese.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
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
    }
}