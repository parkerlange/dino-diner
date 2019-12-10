/*
 * Name: Parker Lange
 * Menu.cshtml.cs
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    /// <summary>
    /// class used for the backend of the webpage interface
    /// </summary>
    public class MenuModel : PageModel
    {
        /// <summary>
        /// creat an instance of the menu class
        /// </summary>
        public Menu Menu
        {
            get
            {
                return new Menu();
            }
        }
        
        public Size Size { get; set; }
        /// <summary>
        /// this is a string containing the search filter 
        /// </summary>
        [BindProperty]
        public string search { get; set; }
        /// <summary>
        /// this is a list of string items containing the menu item type 
        /// </summary>
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>() {"CretaceousCombo", "Entree", "Side", "Drink" };
        /// <summary>
        /// this is a float contaiing the minumum price
        /// </summary>
        [BindProperty]
        public float? minimumPrice { get; set; }
        /// <summary>
        /// this is a float contaiing the maximum price
        /// </summary>
        [BindProperty]
        public float? maximumPrice { get; set; }
        /// <summary>
        /// this is a list of the string ingredients that the user does not want 
        /// </summary>
        [BindProperty]
        public List<string> ingredient { get; set; } = new List<string>();

        /// <summary>
        /// IEnumerable item in order to filter the combos with the LINQ interface
        /// </summary>
        public IEnumerable<CretaceousCombo> ComboItems;
        /// <summary>
        /// IEnumerable item in order to filter the entrees with the LINQ interface
        /// </summary>
        public IEnumerable<IMenuItem> EntreeItems;
        /// <summary>
        /// IEnumerable item in order to filter the drinks with the LINQ interface
        /// </summary>
        public IEnumerable<Drink> DrinkItems;
        /// <summary>
        /// IEnumerable item in order to filter the sides with the LINQ interface
        /// </summary>
        public IEnumerable<Side> SideItems;

        /// <summary>
        /// public method for the get form
        /// </summary>
        public void OnGet()
        {
            ComboItems = Menu.AvailableCombos;
            EntreeItems = Menu.AvailableEntrees;
            SideItems = Menu.AvailableSides;
            DrinkItems = Menu.AvailableDrinks;

        }

        /// <summary>
        /// public method for the post form, inside here the functions to filter are called
        /// </summary>
        public void OnPost()
        {
            ComboItems = Menu.AvailableCombos;
            EntreeItems = Menu.AvailableEntrees;
            SideItems = Menu.AvailableSides;
            DrinkItems = Menu.AvailableDrinks;

            if (menuCategory != null)
            {
                ComboItems = Menu.AvailableMenuItems.OfType<CretaceousCombo>();
                EntreeItems = Menu.AvailableMenuItems.OfType<Entree>();
                SideItems = Menu.AvailableMenuItems.OfType<Side>();
                DrinkItems = Menu.AvailableDrinks.OfType<Drink>();
            }

            if (search != null)
            {
                ComboItems = ComboItems.Where(combo => combo.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                EntreeItems = EntreeItems.Where(entree => entree.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                SideItems = SideItems.Where(side => side.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
                DrinkItems = DrinkItems.Where(combo => combo.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            if (menuCategory.Count != 0)
            { 
                foreach (string item in menuCategory)
                {
                    ComboItems = ComboItems.OfType<CretaceousCombo>();
                    EntreeItems = EntreeItems.OfType<Entree>();
                    SideItems = SideItems.OfType<Side>();
                    DrinkItems = DrinkItems.OfType<Drink>();
                }
            }

            if (minimumPrice != null)
            {
                ComboItems = ComboItems.Where(combo => combo.Price > minimumPrice);
                EntreeItems = EntreeItems.Where(entree => entree.Price > minimumPrice);
                SideItems = SideItems.Where(side => side.Price > minimumPrice);
                DrinkItems = DrinkItems.Where(combo => combo.Price > minimumPrice);
            }

            if (maximumPrice != null)
            {
                ComboItems = ComboItems.Where(combo => combo.Price < maximumPrice);
                EntreeItems = EntreeItems.Where(entree => entree.Price < maximumPrice);
                SideItems = SideItems.Where(side => side.Price < maximumPrice);
                DrinkItems = DrinkItems.Where(combo => combo.Price <maximumPrice);
            }
            
            if (ingredient.Count != 0)
            {
                foreach (string item in ingredient)
                {
                    ComboItems = ComboItems.Where(combo => !combo.Ingredients.Contains(item));
                    EntreeItems = EntreeItems.Where(entree => !entree.Ingredients.Contains(item));
                    SideItems = SideItems.Where(side => !side.Ingredients.Contains(item));
                    DrinkItems = DrinkItems.Where(combo => !combo.Ingredients.Contains(item));
                }
            }
        }

        /// <summary>
        /// This method filters our menu by what the user searches, each item must contain this string
        /// </summary>
        /// <param name="menu">list of menu items</param>
        /// <param name="searchString">string used to filter our menu</param>
        /// <returns>list containing remaining menu items</returns>
        public List<IMenuItem> Search(List<IMenuItem> menu, string searchString)
        {
            List<IMenuItem> result = new List<IMenuItem>();
            foreach (IMenuItem item in menu)
            {
                if (item.ToString() != null && item.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        /// <summary>
        /// In here, we filter the menu by which type of item the user wants
        /// </summary>
        /// <param name="category">this is the type of menu item</param>
        public void FilterByCategory(List<string> category)
        {
            if (!category.Contains("Combo"))
            {
                ComboItems = new List<CretaceousCombo>(); 
            }

            if (!category.Contains("Entree"))
            {
                EntreeItems = new List<IMenuItem>();
            }

            if (!category.Contains("Side"))
            {
                SideItems = new List<Side>();
            }

            if (!category.Contains("Drink"))
            {
                DrinkItems = new List<Drink>();
            }
        }

        /// <summary>
        /// In here, the user selects a minimum price of item they are looking for, and we filter the menu based on this
        /// </summary>
        /// <param name="menu">menu to modify</param>
        /// <param name="minPrice">price to filter the menu by</param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByMinPrice(List<IMenuItem> menu, float minPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menu)
            {
                if (minPrice <= item.Price)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// In here, the user selects a maximum price of item they are looking for, and we filter the menu based on this
        /// </summary>
        /// <param name="menu">menu to modify</param>
        /// <param name="minPrice">price to filter the menu by</param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByMaxPrice(List<IMenuItem> menu, float maxPrice)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menu)
            {
                if (maxPrice >= item.Price)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// In filter by ingredients, the user selects ingredients they do not want
        /// and then we filter the passed in menu by these items. If the menu item contains this item
        /// then we do not add it
        /// </summary>
        /// <param name="menu">menu to modify</param>
        /// <param name="ingredients">list of strings containing the menu items the user doesnt want</param>
        /// <returns></returns>
        public static List<IMenuItem> FilterByIngredients(List<IMenuItem> menu, List<string> ingredients)
        {
            bool flag; 
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menu)
            {
                flag = false; 
                for(int i = 0; i < item.Ingredients.Count; i++)
                {
                    if (ingredients.Contains(item.Ingredients[i]))
                    {
                        flag = true; 
                    }
                }

                if (flag == false)
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }
}