/* Author: Parker Lange
 * CustomizeCombo.xaml
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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// this initializes the customize combo window
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when the side button is pressed, the side window is called and opened
        /// </summary>
        /// <param name="sender"> the button pressed</param>
        /// <param name="arg"> what happens when a press is made</param>
        private void SideClick(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// when the flavor button is pressed, the flavor window is called and opened
        /// </summary>
        /// <param name="sender"> the button pressed</param>
        /// <param name="arg"> what happens when a press is made</param>
        private void FlavorClick(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
