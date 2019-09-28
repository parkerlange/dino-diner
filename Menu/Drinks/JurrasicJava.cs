﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        public bool roomForCream { get; set; } = false;
        public bool decaf { get; set; } = false; 

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

        public  JurrasicJava()
        {
            Price = 0.59;
            Calories = 2;
            size = Size.Small;
            Ice = false;
            ingredients.Add("Water");
            ingredients.Add("Coffee");
        }

        public void AddIce()
        {
            Ice = true; 
        }

        public void LeaveRoomForCream()
        {
            roomForCream = true; 
        }

        public void Decafinate()
        {
            decaf = true; 
        }
    }
}
