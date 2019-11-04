/* Author: Parker Lange
 * CustomizeBrontowurst.xaml.cs
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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        /// <summary>
        /// private braut to modify
        /// </summary>
        private Brontowurst braut;
        /// <summary>
        /// private combo to modify
        /// </summary>
        private CretaceousCombo combo; 
        /// <summary>
        /// constructor for brontowurst
        /// </summary>
        /// <param name="braut">brontowurst passed in</param>
        public CustomizeBrontowurst(Brontowurst braut)
        {
            InitializeComponent();
            this.braut = braut; 
        }
        /// <summary>
        /// constructor for brontowurst
        /// </summary>
        /// <param name="braut">brontowurst passed in</param>
        public CustomizeBrontowurst(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            braut = (Brontowurst)combo.Entree; 
        }
        /// <summary>
        /// hold bun button click
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldBun(object sender, RoutedEventArgs args)
        {
            braut.HoldBun();
        }

        /// <summary>
        /// hold peppers button click
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldPeppers(object sender, RoutedEventArgs args)
        {
            braut.HoldPeppers();
        }
        /// <summary>
        /// hold onion button click
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldOnion(object sender, RoutedEventArgs args)
        {
            braut.HoldOnion();
        }
        /// <summary>
        /// done button click
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
