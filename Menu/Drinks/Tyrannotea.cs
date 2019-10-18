/* Tyrannotea.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the tea for the menu
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// this is the bool for lemon,  if true it adds lemon
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// private backing for  the sweet setting
        /// </summary>
        private bool sweet; 
        /// <summary>
        /// this is the getter setter for the sweetness in the tea. If 
        /// true, sweetener is added to the tea and the calories are doubled.
        /// if not, the calories are set back to their defaults.
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value; 
                if (sweet)
                {
                    ingredients.Add("Cane Sugar");
                    Calories += Calories;
                }
                else
                {
                    ingredients.Remove("Cane Sugar");
                    if (size == Size.Small) 
                        Calories = 8;
                    if (size == Size.Medium)
                        Calories = 16;
                    if (size == Size.Large)
                        Calories = 32; 
                }
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
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
            }

            get
            {
                return size;
            }
        }

        /// <summary>
        /// constructor for the tea. The price, calories, ice, size, and ingredients are set. 
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
            size = Size.Small;
            ingredients.Add("Water");
            ingredients.Add("Tea");
            Sweet = false;
            Ice = true; 
        }

        /// <summary>
        /// this is the method for adding a lemon. If called, the lemon
        /// bool is set true, and lemon is added to the ingredients.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true; 
            ingredients.Add("Lemon");
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item as well as its size
        /// </summary>
        /// <returns> a string of the menu item </returns>
        public override string ToString()
        {
            string item = "";
            if (sweet)
                item = size + " Sweet Tyrannotea";
            else
                item = size + " Tyrannotea";

            return item;
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
