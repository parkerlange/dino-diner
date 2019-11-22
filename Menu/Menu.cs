/* Author: Parker Lange
 * Menu.cs
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// this is the menu class that represents all of the items on the menu
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// this is a list of the ingredients used in all of the menu items
        /// </summary>
        public List<string> PossibleIngredients
        {
            get
            {
                List<string> possibleIngredients = new List<string>();
                foreach (IMenuItem item in AvailableMenuItems)
                {
                    for(int i = 0; i < item.Ingredients.Count; i++)
                    {
                        if (!possibleIngredients.Contains(item.Ingredients[i]))
                        {
                            possibleIngredients.Add(item.Ingredients[i]);
                        }
                    }
                }

                return possibleIngredients; 
            }
        }
        
        /// <summary>
        /// this is the list for all items on the menu that are available currently
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                //call of every item in the menu to get an instance of them
                JurassicJava java = new JurassicJava();
                Sodasaurus soda = new Sodasaurus();
                Tyrannotea tea = new Tyrannotea();
                Water water = new Water();
                Brontowurst brot = new Brontowurst();
                DinoNuggets nugs = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings wings = new PterodactylWings();
                SteakosaurusBurger burger = new SteakosaurusBurger();
                TRexKingBurger king = new TRexKingBurger();
                VelociWrap wrap = new VelociWrap();
                Fryceritops fries = new Fryceritops();
                MeteorMacAndCheese mac = new MeteorMacAndCheese();
                MezzorellaSticks sticks = new MezzorellaSticks();
                Triceritots tots = new Triceritots();
                // we put these objects in an array of objects
                Object[] menuItems = new Object[]
                {
                    brot, nugs, pbj, wings, burger, king, wrap,
                    java, soda, tea, water,
                    fries, mac, sticks, tots
                };

                List<IMenuItem> availableMenuItems = new List<IMenuItem>();
                foreach (IMenuItem item in menuItems)
                {
                    availableMenuItems.Add(item);
                }
                return availableMenuItems; 
            }
        }

        /// <summary>
        /// this is a list for all entrees on the menu currently available
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> availableEntrees = new List<IMenuItem>();
                foreach (IMenuItem entree in AvailableMenuItems)
                    if (entree is Entree)
                        availableEntrees.Add((Entree)entree);
                return availableEntrees;
            }
        }

        /// <summary>
        /// this is the list of all sides currently available on the menu
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> availableSides = new List<IMenuItem>();
                foreach (IMenuItem side in AvailableMenuItems)
                    if (side is Side)
                        availableSides.Add((Side)side);
                return availableSides; 
            }
        }

        /// <summary>
        /// this is a list of all drinks on the list currently available
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> availableDrinks = new List<IMenuItem>();
                foreach (IMenuItem drink in AvailableMenuItems)
                    if (drink is Drink)
                    availableDrinks.Add((Drink)drink);
                return availableDrinks; 
            }
        }

        /// <summary>
        /// this is the list of all of the combos that are available on the menu
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> availableCombos = new List<IMenuItem>();
                foreach (IMenuItem entree in AvailableMenuItems)
                {
                    if (entree is Entree)
                    {
                        CretaceousCombo combo = new CretaceousCombo((Entree)entree);
                        availableCombos.Add(combo);
                    }
                }
                return availableCombos;
            }
        }

        /// <summary>
        /// this is the to string method for the menu class. It displays all of the menu items
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string finalString = "";
            foreach (IMenuItem item in AvailableMenuItems)
            {
                finalString += item.ToString() + "\n"; 
            }

            return finalString; 
        }
    }
}
