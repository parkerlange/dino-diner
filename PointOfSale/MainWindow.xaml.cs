/* Author: Parker Lange
 * MainWindow.xaml
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// initialization of the main window for the menu
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
            DataContext = order;
            Order.NavigationService = OrderUI.NavigationService; 
        }

        /// <summary>
        /// this is a contructor to pass the page data onto the lower level pages
        /// </summary>
        private void PassDataContentToPage()
        {
            if (OrderUI.Content is Page page)
            {
                page.DataContext = OrderUI.DataContext; 
            }
        }

        /// <summary>
        /// event handler for loading the data into the new page
        /// </summary>
        /// <param name="sender">button click</param>
        /// <param name="args">argument</param>
        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            PassDataContentToPage();
        }

        /// <summary>
        /// this is an event handler for passing data to the next page in the tree
        /// </summary>
        /// <param name="sender">click</param>
        /// <param name="args">arument</param>
        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassDataContentToPage();
        }
    }
}
