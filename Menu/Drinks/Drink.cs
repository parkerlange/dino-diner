﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }

    public abstract class Drink
    {
        /// <summary>
        /// 
        /// </summary>
        protected List<string> ingredients = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public bool Ice { get; set; }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get { return ingredients; } }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public void HoldIce()
        {
            this.Ice = false; 
        }

    }
}

