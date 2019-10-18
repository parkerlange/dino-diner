/* SteakosaurusBurger.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this class constructs the burger based on user settings
    /// inherited from entree base class
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// bool indicating a bun 
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// bool indicating ketchup
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// bool indicating mustard
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// bool indicating pickles
        /// </summary>
        private bool pickle = true; 
        /// <summary>
        /// constructor for the burger, sets price and calories
        /// it also adds all of the ingredients to the menu item
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
            ingredients.Add("Steakburger Pattie");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Pickle");
        }

        /// <summary>
        /// if used, the bun will be held
        /// </summary>
        public void HoldBun()
        {
            bun = false; 
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// if called, no ketchup on burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false; 
            ingredients.Remove("Ketchup");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// if called, no mustard on burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false; 
            ingredients.Remove("Mustard");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// if held, no pickles on burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false; 
            ingredients.Remove("Pickle");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item
        /// </summary>
        /// <returns> returns a string of the menu item </returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
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
                if (!bun) special.Add("Hold Bun");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!pickle) special.Add("Hold Pickle");
                return special.ToArray();
            }
        }
    }
}
