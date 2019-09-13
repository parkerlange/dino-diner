/* TRexKingBurger.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// This is used to create the burger for the menu 
    /// </summary>
    public class TRexKingBurger
    {
        /// <summary>
        /// determines if the bun is on the burger
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// determines if the lettuce is on the burger
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// determines if the tomato is on burger
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// determines if onion is on burger
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// determines if pickle is on burger
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// determines if ketchup is on burger
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// determines if mustard is on burger
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// determines if mayo is on the burger
        /// </summary>
        private bool mayo = true; 
        /// <summary>
        /// variable for the price of the burger
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// variable for calories of the burger
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// this is the ingredients for the burger, if an ingredient is true, it gets added to the list 
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// constructor for the burger, sets price and calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// if called, the bun is not on burger
        /// </summary>
        public void HoldBun()
        {
            this.bun = false; 
        }
        /// <summary>
        /// if called, lettuce is not on burger
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false; 
        }
        /// <summary>
        /// if called, tomato is not on burger
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false; 
        }
        /// <summary>
        /// if called, onion is not on burger
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// if called, pickle is not on burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false; 
        }
        /// <summary>
        /// if called, ketchup is not on burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false; 
        }
        /// <summary>
        /// if called, mustard is not on burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false; 
        }
        /// <summary>
        /// if called, mayo is held from burger
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false; 
        }
    }
}
