/* Author: Parker Lange
 * Combo Selection.xaml
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// thhis is the initialization of the combo selection page
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when the customize combo button is pressed, the combo window is called and opened
        /// </summary>
        /// <param name="sender"> the button pressed</param>
        /// <param name="arg"> what happens when a press is made</param>
        private void CustomizeCombo(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
