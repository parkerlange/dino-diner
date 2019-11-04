/* Author: Parker Lange
 * CustomizePrehistoricPBJ.xaml.cs
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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizePrehistoricPBJ : Page
    {
        /// <summary>
        /// private pbj to modify
        /// </summary>
        private PrehistoricPBJ pbj;
        /// <summary>
        /// private combo to modify
        /// </summary>
        private CretaceousCombo combo;

        /// <summary>
        /// constructor for the pbj class
        /// </summary>
        /// <param name="pbj">pbj object to modify passed in</param>
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj; 
        }

        /// <summary>
        /// constructor for the pbj class
        /// </summary>
        /// <param name="pbj">pbj object to modify passed in</param>
        public CustomizePrehistoricPBJ(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            pbj = (PrehistoricPBJ)combo.Entree;
        }
        /// <summary>
        /// button press for holding peanut butter
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldPeanutButter(object sender, RoutedEventArgs args)
        {
            pbj.HoldPeanutButter();
        }
        /// <summary>
        /// button click for holding jelly
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnHoldJelly(object sender, RoutedEventArgs args)
        {
            pbj.HoldJelly(); 
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
