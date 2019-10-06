/* JurassicJava.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class for the coffee the user can order
    /// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// this is a bool leaving room for cream. if true, there will be room
        /// </summary>
        public bool roomForCream { get; set; } = false;
        /// <summary>
        /// this is the option to have the coffee decafinated. 
        /// </summary>
        public bool Decaf { get; set; } = false; 

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
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// constructor for the coffee, it sets default price calories, ice,  size, and ingredients
        /// </summary>
        public  JurassicJava()
        {
            Price = 0.59;
            Calories = 2;
            size = Size.Small;
            Ice = false;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }

        /// <summary>
        /// method to add ice to the coffee
        /// </summary>
        public void AddIce()
        {
            Ice = true; 
        }

        /// <summary>
        /// method to add room for cream in the users coffee
        /// </summary>
        public void LeaveRoomForCream()
        {
            roomForCream = true; 
        }

        /// <summary>
        /// method to decafinate the coffee as per users request
        /// </summary>
        public void Decafinate()
        {
            Decaf = true; 
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item as well as its size
        /// </summary>
        /// <returns> a string of the menu item </returns>
        public override string ToString()
        {
            string item = "";
            if (Decaf)
                item = size + " Decaf Jurassic Java";
            else
                item =  size + " Jurassic Java";

            return item;
        }
    }
}
