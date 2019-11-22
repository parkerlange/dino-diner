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

        /// <summary>
        /// this is a string containing the search filter 
        /// </summary>
        [BindProperty]
        public string search { get; set; }
        /// <summary>
        /// this is a list of string items containing the menu item type 
        /// </summary>
        [BindProperty]
        public List<string> category { get; set; } = new List<string>();
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

        public List<IMenuItem> ComboItems;
        public List<IMenuItem> EntreeItems;
        public List<IMenuItem> DrinkItems;
        public List<IMenuItem> SideItems;

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

            if (search != null)
            {
                ComboItems = Search(ComboItems, search);
                EntreeItems = Search(EntreeItems, search);
                SideItems = Search(SideItems, search);
                DrinkItems = Search(DrinkItems, search);
            }

            if (category.Count != 0)
            {
                FilterByCategory(category);
            }

            if (minimumPrice != null)
            {
                ComboItems = FilterByMinPrice(ComboItems, (float)minimumPrice);
                EntreeItems = FilterByMinPrice(EntreeItems, (float)minimumPrice);
                SideItems = FilterByMinPrice(SideItems, (float)minimumPrice);
                DrinkItems = FilterByMinPrice(DrinkItems, (float)minimumPrice);
            }

            if (maximumPrice != null)
            {
                ComboItems = FilterByMaxPrice(ComboItems, (float)maximumPrice);
                EntreeItems = FilterByMaxPrice(EntreeItems, (float)maximumPrice);
                SideItems = FilterByMaxPrice(SideItems, (float)maximumPrice);
                DrinkItems = FilterByMaxPrice(DrinkItems, (float)maximumPrice);
            }
            
            if (ingredient.Count != 0)
            {
                ComboItems = FilterByIngredients(ComboItems, ingredient);
                EntreeItems = FilterByIngredients(EntreeItems, ingredient);
                SideItems = FilterByIngredients(SideItems, ingredient);
                DrinkItems = FilterByIngredients(DrinkItems, ingredient);
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
                ComboItems = new List<IMenuItem>(); 
            }

            if (!category.Contains("Entree"))
            {
                EntreeItems = new List<IMenuItem>();
            }

            if (!category.Contains("Side"))
            {
                SideItems = new List<IMenuItem>();
            }

            if (!category.Contains("Drink"))
            {
                DrinkItems = new List<IMenuItem>();
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