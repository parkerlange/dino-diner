/*CretaceousCombo.cs
 * Author: Parker Lange
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the combo option for items on the menu.
    /// </summary>
    public class CretaceousCombo : IMenuItem, INotifyPropertyChanged, IOrderItem
    {
        /// <summary>
        /// An event handler for PropertyChanged for fields hold jelly/peanut butter
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// method call for the property changed call
        /// </summary>
        /// <param name="propertyName">this is the property being changed</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Entree entree; 
        /// <summary>
        /// creates an instance of the entree the user picks
        /// </summary>
        public Entree Entree {
            get { return entree;  }
            protected set
            {
                entree = value;
                entree.PropertyChanged += (object sender, PropertyChangedEventArgs args) =>
                {
                    NotifyOfPropertyChanged(args.PropertyName);
                };
            }
        }
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

        private Drink drink = new Sodasaurus();
        /// <summary>
        /// creates an instance of the drink the user selects 
        /// </summary>
        public Drink Drink { get { return drink; }
            set
            {
                drink = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }

        }
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
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
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

        /// <summary>
        /// this returns the description of the string
        /// </summary>
        public string Description
        {
            get 
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// this returns a list of all of the special requests the user has for their order
        /// </summary>

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        /// <summary>
        /// this is the constructor for the combo class it sets the entree side and drink
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

        /// <summary>
        /// this is the to string for the class, it returns a string of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Entree + " Combo";
        }
    }
}
