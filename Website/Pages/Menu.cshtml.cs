using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu; 

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu
        {
            get
            {
                return new Menu();
            }
        }

        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> category { get; set; } = new List<string>();
        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maximumPrice { get; set; }
        [BindProperty]
        public List<string> ingredient { get; set; } = new List<string>();

        public List<IMenuItem> AllCombos { get { return Menu.AvailableCombos; } set { } }
        public List<IMenuItem> AllEntrees { get { return Menu.AvailableEntrees; } set { } }
        public List<IMenuItem> AllDrinks { get { return Menu.AvailableDrinks; } set { } }
        public List<IMenuItem> AllSides { get { return Menu.AvailableSides; } set { } }

        public List<IMenuItem> ComboItems;
        public List<IMenuItem> EntreeItems;
        public List<IMenuItem> DrinkItems;
        public List<IMenuItem> SideItems;

        public void OnGet()
        {
            ComboItems = AllCombos;
            EntreeItems = AllEntrees;
            SideItems = AllSides;
            DrinkItems = AllDrinks;
        }

        public void OnPost()
        {
            ComboItems = AllCombos;
            EntreeItems = AllEntrees;
            SideItems = AllSides;
            DrinkItems = AllDrinks;

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

        public static List<IMenuItem> FilterByIngredients(List<IMenuItem> menu, List<string> ingredients)
        {
            List<IMenuItem> results = new List<IMenuItem>();
            foreach (IMenuItem item in menu)
            {
                for(int i = 0; i < item.Ingredients.Count; i++)
                {
                    if (!ingredients.Contains(item.Ingredients[i]))
                    {
                        results.Add(item);
                    }
                }
            }

            return results;
        }
    }
}