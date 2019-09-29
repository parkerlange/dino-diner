/*CretaceousCombo.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Sides;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the combo option for items on the menu.
    /// </summary>
    public class CretaceousCombo
    {
        /// <summary>
        /// creates an instance of the entree the user picks
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// private backing for the side user selects
        /// </summary>
        private Side side; 
        /// <summary>
        /// creates an instance of the side the user wants
        /// </summary>
        public Side Side {
            get { return side; }
            set
            {
                side = value;
                side.Size = size;
            }
        }
        /// <summary>
        /// creates an instance of the drink the user selects 
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// This gets the total price. Combos have a 25 cent discount.
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25; 
            }
        }

        /// <summary>
        /// this gets the calorie total for the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }
        /// <summary>
        /// private backing for the size
        /// </summary>
        private Size size = Size.Small; 
        /// <summary>
        /// this creates an instance of the size. Based on the selection, the 
        /// drink and side sizes are set
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value; 
            }
        }

        /// <summary>
        /// this is the ingredients for the combo
        /// it adds all the ingredients for each item of the combo to the
        /// complete list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients; 
            }
        }

        /*public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }*/
    }
}
