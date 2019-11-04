/* Author: Parker Lange
 * CustomizeDinoNuggets.xaml.cs
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
    /// Interaction logic for CustomizeDinoNuggets.xaml
    /// </summary>
    public partial class CustomizeDinoNuggets : Page
    {
        /// <summary>
        /// private dino nugget to modify
        /// </summary>
        private DinoNuggets nug;
        /// <summary>
        /// private combo to modify
        /// </summary>
        private CretaceousCombo combo;
        /// <summary>
        /// constructor for dino nuggets.
        /// </summary>
        /// <param name="nug">dino nugget object passed in</param>
        public CustomizeDinoNuggets(DinoNuggets nug)
        {
            InitializeComponent();
            this.nug = nug; 
        }

        public CustomizeDinoNuggets(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
            nug = (DinoNuggets)combo.Entree;
        }
        /// <summary>
        /// button click for adding a nugget
        /// </summary>
        /// <param name="sender">sender is button</param>
        /// <param name="args"> arg is what to do</param>
        private void OnAddNugget(object sender, RoutedEventArgs args)
        {
            nug.AddNugget();
        }
        /// <summary>
        /// button click for clicking done
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
