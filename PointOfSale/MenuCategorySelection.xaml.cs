/* Author: Parker Lange
 * MenuCategorySelection.xaml
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// this is the initialization for the menu 
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when the combo button is pressed, the page for combos opens 
        /// </summary>
        /// <param name="sender"> sender is the object the request is from</param>
        /// <param name="arg">arg is what is pressed</param>
        private void SelectCombo(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        /// <summary>
        /// when the entree button is pressed, the page for entrees opens 
        /// </summary>
        /// <param name="sender"> sender is the object the request is from</param>
        /// <param name="arg">arg is what is pressed</param>
        private void EntreeCombo(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        /// <summary>
        /// when the side button is pressed, the page for sides opens 
        /// </summary>
        /// <param name="sender"> sender is the object the request is from</param>
        /// <param name="arg">arg is what is pressed</param>
        private void SideCombo(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// when the drink button is pressed, the page for drinks opens 
        /// </summary>
        /// <param name="sender"> sender is the object the request is from</param>
        /// <param name="arg">arg is what is pressed</param>
        private void DrinkCombo(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
