/* Author: Parker Lange
 * CustomizeVelociWrap.xaml.cs
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
    /// Interaction logic for CustomizeVelociWrap.xaml
    /// </summary>
    public partial class CustomizeVelociWrap : Page
    {
        /// <summary>
        /// private wrap object to modify
        /// </summary>
        private VelociWrap wrap;
        /// <summary>
        /// private combo to modify
        /// </summary>
        private CretaceousCombo combo;
        /// <summary>
        /// constructor for the velociwrap 
        /// </summary>
        /// <param name="wrap">wrap object passed in to modify</param>
        public CustomizeVelociWrap(VelociWrap wrap)
        {
            InitializeComponent();
            this.wrap = wrap; 
        }
        /// <summary>
        /// constructor for the velociwrap 
        /// </summary>
        /// <param name="combo">combo object passed in to modify</param>
        public CustomizeVelociWrap(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            wrap = (VelociWrap)combo.Entree; 
        }
        /// <summary>
        /// button click for hold cheese
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldCheese(object sender, RoutedEventArgs args)
        {
            wrap.HoldCheese();
        }
        /// <summary>
        /// button click for holding dressing
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldDressing(object sender, RoutedEventArgs args)
        {
            wrap.HoldDressing();
        }
        /// <summary>
        /// button click for holding lettuce
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldLettuce(object sender, RoutedEventArgs args)
        {
            wrap.HoldLettuce();
        }
        /// <summary>
        /// button click for going back
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
