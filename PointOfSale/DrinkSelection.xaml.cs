/* Author: parker Lange
 * DrinkSelection.xaml
 */
using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DDSize = DinoDiner.Menu.Size;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// new drink that use to set in the class
        /// </summary>
        public Drink drink { get; set; }

        /// <summary>
        /// instance of the water class
        /// </summary>
        Water water = new Water();
        /// <summary>
        /// instance of  the soda sclass
        /// </summary>
        Sodasaurus soda = new Sodasaurus();
        /// <summary>
        /// instance of the tea class
        /// </summary>
        Tyrannotea tea = new Tyrannotea();
        /// <summary>
        /// instance of the java class
        /// </summary>
        JurassicJava java = new JurassicJava();

        private CretaceousCombo combo; 

        /// <summary>
        /// this is the initialization for thhe drink page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            // set all buttons to off
            FlavorButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            RoomButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// this is the initialization for thhe drink page, based on the drink pased in
        /// the drink will change the drink buttons
        /// </summary>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            // set all buttons to off
            FlavorButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            RoomButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;
            this.drink = drink; 

            if (drink is Sodasaurus)
            {
                FlavorButton.Visibility = Visibility.Visible;
                HoldIceButton.Visibility = Visibility.Visible;
            }

            if (drink is JurassicJava)
            {
                DecafButton.Visibility = Visibility.Visible;
                RoomButton.Visibility = Visibility.Visible;
                AddIceButton.Visibility = Visibility.Visible;
            }

            if (drink is Tyrannotea)
            {
                SweetButton.Visibility = Visibility.Visible;
                LemonButton.Visibility = Visibility.Visible;
                HoldIceButton.Visibility = Visibility.Visible;
            }

            if (drink is Water)
            {
                LemonButton.Visibility = Visibility.Visible;
                HoldIceButton.Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// this is the initialization for thhe drink page, based on the drink pased in
        /// the drink will change the drink buttons
        /// </summary>
        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            // set all buttons to off
            FlavorButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            RoomButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;
            this.combo = combo;
            drink = combo.Drink; 

            if (combo.Drink is Sodasaurus)
            {
                FlavorButton.Visibility = Visibility.Visible;
                HoldIceButton.Visibility = Visibility.Visible;
            }

            if (combo.Drink is JurassicJava)
            {
                DecafButton.Visibility = Visibility.Visible;
                RoomButton.Visibility = Visibility.Visible;
                AddIceButton.Visibility = Visibility.Visible;
            }

            if (combo.Drink is Tyrannotea)
            {
                SweetButton.Visibility = Visibility.Visible;
                LemonButton.Visibility = Visibility.Visible;
                HoldIceButton.Visibility = Visibility.Visible;
            }

            if (combo.Drink is Water)
            {
                LemonButton.Visibility = Visibility.Visible;
                HoldIceButton.Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// if the flavor button is pressed,  we go to the flavors page
        /// </summary>
        /// <param name="sender">sender is the button pressed</param>
        /// <param name="arg">arg is what the action is suppose to be</param>
        private void FlavorClick(Object sender, RoutedEventArgs arg)
        {
            if (combo != null)
                NavigationService.Navigate(new FlavorSelection(combo));
            else
                NavigationService.Navigate(new FlavorSelection(soda));
        }
        // <summary>
        /// if the soda button is pressed we only make the options for soda shown and disable the rest
        /// </summary>
        /// <param name="sender">sender is the button pressed</param>
        /// <param name="arg">arg is what the action is suppose to be</param>
        private void SodaClick(Object sender, RoutedEventArgs arg)
        {
            // set all buttons to off
            FlavorButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            RoomButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;

            FlavorButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;

            if (DataContext is Order order)
            {
                drink = new Sodasaurus();
                soda = (Sodasaurus)drink;
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                    order.Add(drink);
            }
        }
        // <summary>
        /// if the coffee button is pressed we only make the options for coffee shown and disable the rest
        /// </summary>
        /// <param name="sender">sender is the button pressed</param>
        /// <param name="arg">arg is what the action is suppose to be</param>
        private void JavaClick(Object sender, RoutedEventArgs arg)
        {
            // set all buttons to off
            FlavorButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            RoomButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;

            DecafButton.Visibility = Visibility.Visible;
            RoomButton.Visibility = Visibility.Visible;
            AddIceButton.Visibility = Visibility.Visible;


            if (DataContext is Order order)
            {
                drink = new JurassicJava();
                java = (JurassicJava)drink;
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                    order.Add(drink);
            }
        }
        // <summary>
        /// if the water button is pressed we only make the options for water shown and disable the rest
        /// </summary>
        /// <param name="sender">sender is the button pressed</param>
        /// <param name="arg">arg is what the action is suppose to be</param>
        private void WaterClick(Object sender, RoutedEventArgs arg)
        {
            // set all buttons to off
            FlavorButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            RoomButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;

            LemonButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;


            if (DataContext is Order order)
            {
                drink = new Water();
                water = (Water)drink;
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                    order.Add(drink);
            }
        }
        // <summary>
        /// if the Tea button is pressed we only make the options for tea shown and disable the rest
        /// </summary>
        /// <param name="sender">sender is the button pressed</param>
        /// <param name="arg">arg is what the action is suppose to be</param>
        private void TeaClick(Object sender, RoutedEventArgs arg)
        {
            // set all buttons to off
            FlavorButton.Visibility = Visibility.Hidden;
            LemonButton.Visibility = Visibility.Hidden;
            HoldIceButton.Visibility = Visibility.Hidden;
            DecafButton.Visibility = Visibility.Hidden;
            RoomButton.Visibility = Visibility.Hidden;
            AddIceButton.Visibility = Visibility.Hidden;
            SweetButton.Visibility = Visibility.Hidden;

            SweetButton.Visibility = Visibility.Visible;
            LemonButton.Visibility = Visibility.Visible;
            HoldIceButton.Visibility = Visibility.Visible;


            if (DataContext is Order order)
            {
                drink = new Tyrannotea();
                tea = (Tyrannotea)drink;
                if (combo != null)
                {
                    combo.Drink = drink;
                }
                else
                    order.Add(drink);
            }
        }

        /// <summary>
        /// event handler for the change size button
        /// changes size of the drink
        /// </summary>
        /// <param name="sender">object </param>
        /// <param name="args"> button click </param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                if (combo == null)
                    drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }

        /// <summary>
        /// event handler for the hold ice button
        /// holds ice on the water soda or tea
        /// </summary>
        /// <param name="sender"> object </param>
        /// <param name="args"> button click sender</param>
        private void OnSelectHoldIce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            { 
                drink.HoldIce();
                if (combo != null)
                    combo.Drink = drink; 
            }
        }

        /// <summary>
        /// event handler for the add lemon button. 
        /// adds lemon to water/tea
        /// </summary>
        /// <param name="sender"> object </param>
        /// <param name="args"> button click sender</param>
        private void OnSelectLemon(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (drink is Water)
                {
                    water.AddLemon();
                    drink = water;
                    if (combo != null)
                        combo.Drink = drink;
                }

                if (drink is Tyrannotea)
                {
                    tea.AddLemon();
                    drink = tea;
                    if (combo != null)
                        combo.Drink = drink;
                }
            }
        }
        /// <summary>
        /// event handler for the decaf option on coffee
        /// makes coffee decaf
        /// </summary>
        /// <param name="sender"> object </param>
        /// <param name="args"> button click </param>
        private void OnSelectDecaf(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                java.Decafinate();
                drink = java;
                if (combo != null)
                    combo.Drink = drink;
            }
        }

        /// <summary>
        /// event handler for the add room for coffee feature
        /// adds room to coffee
        /// </summary>
        /// <param name="sender"> object </param>
        /// <param name="args"> button click</param>
        private void OnSelectRoom(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                java.LeaveRoomForCream();
                drink = java;
                if (combo != null)
                    combo.Drink = drink;
            }
        }

        /// <summary>
        /// event handler for the sweet option for the tea
        /// makes tea sweet
        /// </summary>
        /// <param name="sender"> object </param>
        /// <param name="args"> button click </param>
        private void OnSelectSweet(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                tea.Sweet = true;
                drink = tea;
                if (combo != null)
                    combo.Drink = drink;
            }
        }

        /// <summary>
        /// event handler for the add ice feature of the coffee
        /// </summary>
        /// <param name="sender"> object </param>
        /// <param name="args"> button click </param>
        private void OnSelectAddIce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                java.AddIce();
                drink = java;
                if (combo != null)
                    combo.Drink = drink;
            }
        }

        /// <summary>
        /// event handler for the back button, when pressed we return to the previous window 
        /// </summary>
        /// <param name="sender"> object </param>
        /// <param name="arg"> button click </param>
        private void OnSelectBack(Object sender, RoutedEventArgs arg)
        {
            if (combo != null)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
