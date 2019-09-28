using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        public bool Lemon { get; set; } = false;

        private bool sweet; 
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

        public void AddLemon()
        {
            Lemon = true; 
            ingredients.Add("Lemon");
        }
    }
}
