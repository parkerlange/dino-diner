/* Author: Parker Lange
 * CustomizeTRexBurger.xaml.cs
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
    /// Interaction logic for CustomizeTRexBurger.xaml
    /// </summary>
    public partial class CustomizeTRexBurger : Page
    {
        /// <summary>
        /// private burger object to modify
        /// </summary>
        private TRexKingBurger burger;
        /// <summary>
        /// private combo to modify
        /// </summary>
        private CretaceousCombo combo;
        /// <summary>
        ///  constructor for the class
        /// </summary>
        /// <param name="burger">burger is object passed in</param>
        public CustomizeTRexBurger(TRexKingBurger burger)
        {
            InitializeComponent();
            this.burger = burger;
        }
        /// <summary>
        ///  constructor for the class
        /// </summary>
        /// <param name="combo">combo is object passed in</param>
        public CustomizeTRexBurger(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            burger = (TRexKingBurger)combo.Entree; 
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
        /// button click for holding lettuce
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            burger.HoldLettuce();
        }
        /// <summary>
        /// button click for holding mayo
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldMayo(object sender, RoutedEventArgs args)
        {
            burger.HoldMayo();
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
        /// button click for holding onion
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            burger.HoldOnion();
        }
        /// <summary>
        /// button click for holding pickle
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldPickle(object sender, RoutedEventArgs args)
        {
            burger.HoldPickle();
        }
        /// <summary>
        /// button click for holding tomato
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldTomato(object sender, RoutedEventArgs args)
        {
            burger.HoldTomato();
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
