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
        public Drink drink { get; set; }
       
        /// <summary>
        /// this is the initialization for thhe drink page
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// if the flavor button is pressed,  we go to the flavors page
        /// </summary>
        /// <param name="sender">sender is the button pressed</param>
        /// <param name="arg">arg is what the action is suppose to be</param>
        private void FlavorClick(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new FlavorSelection());
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
                order.Items.Add(drink);
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
                order.Items.Add(drink);
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
                order.Items.Add(drink);
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
                order.Items.Add(drink);
            }
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }

        private void OnSelectHoldIce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                
            }
        }

        private void OnSelectLemon(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                
            }
        }

        private void OnSelectDecaf(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                 
            }
        }

        private void OnSelectRoom(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                
            }
        }

        private void OnSelectSweet(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                
            }
        }
        private void OnSelectAddIce(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                
            }
        }
    }
}
