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
using DinoDiner.Menu; 

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private CretaceousCombo combo; 
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
        private void onCustomizeBrontowurst(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new Brontowurst());
                order.Add(combo);
            }

            NavigationService.Navigate(new CustomizeBrontowurst(combo));
        }
        /// <summary>
        /// when the customize combo button is pressed, the combo window is called and opened
        /// </summary>
        /// <param name="sender"> the button pressed</param>
        /// <param name="arg"> what happens when a press is made</param>
        private void onCustomizeDinoNuggets(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new DinoNuggets());
                order.Add(combo);
            }
            NavigationService.Navigate(new CustomizeDinoNuggets(combo));
        }
        /// <summary>
        /// when the customize combo button is pressed, the combo window is called and opened
        /// </summary>
        /// <param name="sender"> the button pressed</param>
        /// <param name="arg"> what happens when a press is made</param>
        private void onCustomizeSteakosaurus(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new SteakosaurusBurger());
                order.Add(combo);
            }

            NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo));
        }
        /// <summary>
        /// when the customize combo button is pressed, the combo window is called and opened
        /// </summary>
        /// <param name="sender"> the button pressed</param>
        /// <param name="arg"> what happens when a press is made</param>
        private void onCustomizeTRex(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new TRexKingBurger());
                order.Add(combo);
            }

            NavigationService.Navigate(new CustomizeTRexBurger(combo));
        }
        /// <summary>
        /// when the customize combo button is pressed, the combo window is called and opened
        /// </summary>
        /// <param name="sender"> the button pressed</param>
        /// <param name="arg"> what happens when a press is made</param>
        private void onCustomizePBJ(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PrehistoricPBJ());
                order.Add(combo);
            }

            NavigationService.Navigate(new CustomizePrehistoricPBJ(combo));
        }
        /// <summary>
        /// when the customize combo button is pressed, the combo window is called and opened
        /// </summary>
        /// <param name="sender"> the button pressed</param>
        /// <param name="arg"> what happens when a press is made</param>
        private void onCustomizeWings(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new PterodactylWings());
                order.Add(combo);
            }

            NavigationService.Navigate(new CustomizeCombo(combo));
        }
        /// <summary>
        /// when the customize combo button is pressed, the combo window is called and opened
        /// </summary>
        /// <param name="sender"> the button pressed</param>
        /// <param name="arg"> what happens when a press is made</param>
        private void onCustomizeWrap(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                combo = new CretaceousCombo(new VelociWrap());
                order.Add(combo);
            }

            NavigationService.Navigate(new CustomizeVelociWrap(combo));
        }
    }
}
