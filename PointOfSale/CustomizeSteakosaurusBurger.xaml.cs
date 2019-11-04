/* Author: parker  Lange
 * CustomizeSteakosaurusBurger.xaml.cs
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
    /// Interaction logic for CustomizeSteakosaurusBurger.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        /// <summary>
        /// private burger to modify in this class
        /// </summary>
        private SteakosaurusBurger burger;
        /// <summary>
        /// private combo to modify
        /// </summary>
        private CretaceousCombo combo;
        /// <summary>
        /// constructor for the class
        /// </summary>
        /// <param name="burger">steakosaurus object passed in</param>
        public CustomizeSteakosaurusBurger(SteakosaurusBurger burger)
        {
            InitializeComponent();
            this.burger = burger; 
        }
        /// <summary>
        /// constructor for the class
        /// </summary>
        /// <param name="combo">combo object passed in</param>
        public CustomizeSteakosaurusBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            burger = (SteakosaurusBurger)combo.Entree;
        }
        /// <summary>
        /// button click for holding bun
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            burger.HoldBun();
        }
        /// <summary>
        /// button click for holding ketchup
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldKetchup(object sender, RoutedEventArgs args)
        {
            burger.HoldKetchup();
        }
        /// <summary>
        /// button click for holding mustard
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldMustard(object sender, RoutedEventArgs args)
        {
            burger.HoldMustard();
        }
        /// <summary>
        /// button click for bholding pickle 
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
        }
        /// <summary>
        /// button click for going back a page
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            if (combo != null)
                NavigationService.Navigate(new CustomizeCombo(combo));
            else
                NavigationService.GoBack();
        }
    }
}
