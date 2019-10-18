/* TRexKingBurger.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is used to create the burger for the menu 
    /// inherited from entree base class
    /// </summary>
    public class TRexKingBurger : Entree
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
        /// constructor for the burger, sets price and calories
        /// it also adds all of the ingredients to the menu item
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
            for (int i = 0; i < 3; i++) ingredients.Add("Steakburger Pattie");
            ingredients.Add("Whole Wheat Bun");
            ingredients.Add("Lettuce");
            ingredients.Add("Tomato");
            ingredients.Add("Onion");
            ingredients.Add("Pickle");
            ingredients.Add("Ketchup");
            ingredients.Add("Mustard");
            ingredients.Add("Mayo");
        }
        /// <summary>
        /// if called, the bun is not on burger
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            ingredients.Remove("Whole Wheat Bun");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// if called, lettuce is not on burger
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            ingredients.Remove("Lettuce");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// if called, tomato is not on burger
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            ingredients.Remove("Tomato");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// if called, onion is not on burger
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
            ingredients.Remove("Onion");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// if called, pickle is not on burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            ingredients.Remove("Pickle");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// if called, ketchup is not on burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            ingredients.Remove("Ketchup");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// if called, mustard is not on burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            ingredients.Remove("Mustard");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// if called, mayo is held from burger
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
            ingredients.Remove("Mayo");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item
        /// </summary>
        /// <returns> returns a string of the menu item </returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
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
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
    }
}
