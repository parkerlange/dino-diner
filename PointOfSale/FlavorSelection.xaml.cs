/* Author: Parker Lange
 * FlavorSelection.xaml
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// instance of the sodasaurus class
        /// </summary>
        Sodasaurus sd = new Sodasaurus();
        /// <summary>
        /// this is the initialization for the flavors of soda menu
        /// </summary>
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            sd = soda; 
        }

        /// <summary>
        /// on the click of the flavor select button,  set the flavor and return to the drink menu 
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="args">event pressing button</param>
        private void OnFlavorSelect(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                sd.Flavor = (DinoDiner.Menu.SodasaurusFlavor)Enum.Parse(typeof(DinoDiner.Menu.SodasaurusFlavor), element.Tag.ToString());
            }

            NavigationService.Navigate(new DrinkSelection(sd));
        }
    }
}
