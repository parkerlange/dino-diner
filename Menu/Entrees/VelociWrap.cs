/* VelociWrap.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is a class to construct the food item velociwrap based off an inherited Entree class
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// oprivate bool indicating lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// private bool indicating if dressing is on the wrap
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// private bool indicating if cheese is on the wrap
        /// </summary>
        private bool cheese = true; 

        /// <summary>
        /// this is the constructor for the wrap, it sets price and calories
        /// it also adds all of the ingredients to the menu item
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
            ingredients.Add("Flour Tortilla");
            ingredients.Add("Chicken Breast");
            ingredients.Add("Ceasar Dressing");
            ingredients.Add("Romaine Lettuce");
            ingredients.Add("Parmesan Cheese");
        }

        /// <summary>
        /// method for holding dressing from the wrap
        /// </summary>
        public void HoldDressing()
        {
            dressing = false; 
            ingredients.Remove("Ceasar Dressing");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// method to hold lettuce, and not add to the wrap
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false; 
            ingredients.Remove("Romaine Lettuce");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// method to hold cheese from the wrap
        /// </summary>
        public void HoldCheese()
        {
            cheese = false; 
            ingredients.Remove("Parmesan Cheese");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item
        /// </summary>
        /// <returns> returns a string of the menu item </returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }

        /// <summary>
        /// gets a description of the order item
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }
        }

        /// <summary>
        /// this is a list of all of the special requests for the order 
        /// </summary>
        public override  string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!lettuce) special.Add("Hold Lettuce");
                if (!dressing) special.Add("Hold Dressing");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }
    }
}
