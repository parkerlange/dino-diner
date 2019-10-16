/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Parker Lange
 */
using System.Collections.Generic;
using System.ComponentModel; 

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the class for the food item PBJ
    /// inherited from entree base class
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// private bool indicating peanutbutter
        /// </summary>
        private bool peanutButter = true;
         
        /// <summary>
        /// private bool indicating jelly 
        /// </summary>
        private bool jelly = true;

        /// <summary>
        /// this is the constructor setting the price and calories
        /// it also adds all of the ingredients to the menu item
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
            ingredients.Add("Bread");
            ingredients.Add("Peanut Butter");
            ingredients.Add("Jelly");
        }

        /// <summary>
        /// if this peanut butter is false, none will be on pbj
        /// </summary>
        public void HoldPeanutButter()
        {
            peanutButter = false;
            ingredients.Remove("Peanut Butter");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// if this bool is false, it will remove jelly
        /// </summary>
        public void HoldJelly()
        {
            jelly = false; 
            ingredients.Remove("Jelly");
            NotifyOfPropertyChanged("Ingredients");
            NotifyOfPropertyChanged("Special");
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the menu item
        /// </summary>
        /// <returns> returns a string of the menu item </returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }

        /// <summary>
        /// gets a description of the order item
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!peanutButter) special.Add("Hold Peanut Butter");
                if (!jelly) special.Add("Hold Jelly");
                return special.ToArray();
            }
        }
    }
}
