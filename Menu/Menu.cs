using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<string> AvailableMenuItems
        {
            get
            {
                List<string> availableMenuItems = new List<string>()
                {
                    "Brontowurst", "Dino-Nuggets", "Prehistoric PB&J", "Pterodactyl Wings",
                    "Steakosaurus Burger", "T-Rex King Burger", "Veloci-Wrap",

                    "Friceritops", "Meteor Mac and Cheese", "Mezzorella Sticks", "Triceritots",

                    "Jurassic Java", "Sodasaurus", "Tyrannotea", "Water"
                };
                return availableMenuItems; 
            }
        }

        public List<string> AvailableEntrees
        {
            get
            {
                List<string> availableEntrees = new List<string>()
                {
                    "Brontowurst", "Dino-Nuggets", "Prehistoric PB&J", "Pterodactyl Wings",
                    "Steakosaurus Burger", "T-Rex King Burger", "Veloci-Wrap"
                };

                return availableEntrees;
            }
        }

        public List<string> AvailableSides
        {
            get
            {
                List<string> availableSides = new List<string>()
                {
                    "Friceritops", "Meteor Mac and Cheese", "Mezzorella Sticks", "Triceritots"
                };

                return availableSides; 
            }
        }

        public List<string> AvailableDrinks
        {
            get
            {
                List<string> availableDrinks = new List<string>()
                {
                    "Jurassic Java", "Sodasaurus", "Tyrannotea", "Water"
                };

                return availableDrinks; 
            }
        }

        public List<string> AvailableCombos
        {
            get
            {
                List<string> availableCombos = new List<string>();
                foreach (string item in AvailableEntrees)
                {
                    availableCombos.Add(item + " Combo");
                }

                return availableCombos;
            }
        }

        public override string ToString()
        {
            string finalString = "";
            foreach (string item in AvailableMenuItems)
            {
                finalString += item + "\n"; 
            }

            return finalString; 
        }
    }
}
