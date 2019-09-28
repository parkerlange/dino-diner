using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
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
            }

            get
            {
                return size;
            }
        }

        public Water()
        {
            Price = 0.10;
            Calories = 0;
            size = Size.Small;
            ingredients.Add("Water");
            Ice = true; 
        }

        public void AddLemon()
        {
            Lemon = true;
            ingredients.Add("Lemon");
        }
    }
}
