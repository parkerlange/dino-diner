/* Author: Parker Lange
 * OrderList.xaml.cs
 */
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
using DinoDiner.Menu; 

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderList : UserControl
    {
        /// <summary>
        /// navigation service used throughout the order list
        /// </summary>
        public NavigationService NavigationService { get; set; }
        /// <summary>
        /// constructor for the order list class
        /// </summary>
        public OrderList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for removing an item from the menu by clicking the redx 
        /// </summary>
        /// <param name="sender">button click</param>
        /// <param name="args">argument</param>
        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        /// <summary>
        /// this is the event handler for selecting an item
        /// once selected, it takes us to the page to go modify its properties
        /// </summary>
        /// <param name="sender">button click</param>
        /// <param name="args">argument</param>
       private void OnSelectionChanged(object sender, EventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }

            if (OrderItems.SelectedItem is Entree entree)
            {
                NavigationService?.Navigate(new EntreeSelection(entree));
            }

            if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
        }
    }
}
