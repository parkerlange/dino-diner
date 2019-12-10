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
                CretaceousCombo brotCombo = new CretaceousCombo(brot);
                CretaceousCombo nugCombo = new CretaceousCombo(nugs);
                CretaceousCombo pbjCombo = new CretaceousCombo(pbj);
                CretaceousCombo wingCombo = new CretaceousCombo(wings);
                CretaceousCombo burgerCombo = new CretaceousCombo(burger);
                CretaceousCombo kingCombo = new CretaceousCombo(king);
                CretaceousCombo wrapCombo = new CretaceousCombo(wrap);
                // we put these objects in an array of objects
                Object[] menuItems = new Object[]
                {
                    brotCombo, nugCombo, pbjCombo, wingCombo, burgerCombo, kingCombo, wrapCombo,
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
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> availableSides = new List<Side>();
                foreach (IMenuItem side in AvailableMenuItems)
                    if (side is Side)
                        availableSides.Add((Side)side);
                return availableSides; 
            }
        }

        /// <summary>
        /// this is a list of all drinks on the list currently available
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> availableDrinks = new List<Drink>();
                foreach (IMenuItem drink in AvailableMenuItems)
                    if (drink is Drink)
                    availableDrinks.Add((Drink)drink);
                return availableDrinks; 
            }
        }

        /// <summary>
        /// this is the list of all of the combos that are available on the menu
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> availableCombos = new List<CretaceousCombo>();
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
