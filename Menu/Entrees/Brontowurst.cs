/* Brontowurst.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// this is the class to create the brontowurst to the users selections
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// Bool to set adding a bun true or false
        /// </summary>
        private bool Bun = true;
        /// <summary>
        /// Bool to set adding peppers true or false
        /// </summary>
        private bool Peppers = true;
        /// <summary>
        /// Bool to set addding onion true or false
        /// </summary>
        private bool Onion = true; 

        /// <summary>
        /// This is a double value holding the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// This is a uint holding the number of calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// This is the List holding the indgredients. Based on the bools set, certains values will or will not be included
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (Bun) ingredients.Add("Whole Wheat Bun");
                if (Peppers) ingredients.Add("Peppers");
                if (Onion) ingredients.Add("Onion");
                return ingredients; 
            }
        }

        /// <summary>
        /// This is the public constructor Brontowurst, this sets price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498; 
        }

        /// <summary>
        /// This HoldBun method is used to disable the bun
        /// </summary>
        public void HoldBun()
        {
            this.Bun = false; 
        }

        /// <summary>
        /// This holdpeppers method disables peppers
        /// </summary>
        public void HoldPeppers()
        {
            this.Peppers = false; 
        }

        /// <summary>
        /// this hold onion method disables onions
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false; 
        }
    }
}
