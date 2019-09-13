/* SteakosaurusBurger.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// this class constructs the burger based on user settings
    /// </summary>
    public class SteakosaurusBurger
    {
        /// <summary>
        /// determines if user wants ketchup on burger
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// determines if user wants mustard
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// determines if user wants a bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// determines if user wants pickle 
        /// </summary>
        private bool pickle = true; 
        /// <summary>
        /// this variable is used to set price of burger
        /// </summary>
        public double Price { get; set;  }
        /// <summary>
        /// this variable sets calories of burger
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// this is the ingredients of burger, based on user options indgredients can be held
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                return ingredients; 
            }
        }

        /// <summary>
        /// constructor for the burger, sets price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621; 
        }

        /// <summary>
        /// if used, the bun will be held
        /// </summary>
        public void HoldBun()
        {
            this.bun = false; 
        }

        /// <summary>
        /// if called, no ketchup on burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false; 
        }

        /// <summary>
        /// if called, no mustard on burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false; 
        }

        /// <summary>
        /// if held, no pickles on burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false; 
        }
    }
}
