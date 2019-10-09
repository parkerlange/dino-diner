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
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        private void SelectCombo(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new ComboSelection());
        }
        private void EntreeCombo(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        private void SideCombo(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new SideSelection());
        }
        private void DrinkCombo(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
