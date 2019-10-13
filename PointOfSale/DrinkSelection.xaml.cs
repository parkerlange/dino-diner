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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }

        private void FlavorClick(Object sender, RoutedEventArgs arg)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

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
        }

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
        }

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
        }

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
        }

    }
}
