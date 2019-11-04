/* Author: Parker Lange
 * SideSelection.xaml
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
using DDSize = DinoDiner.Menu.Size; 

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// side class instance used for setting side 
        /// </summary>
        public Side side { get; set; }
        /// <summary>
        /// combo object passed in
        /// </summary>
        private CretaceousCombo combo; 
        /// <summary>
        /// initialization of the side selection page
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is a constructor for the side selection
        /// </summary>
        /// <param name="side"> side passed in to go back with click</param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side; 
        }
        /// <summary>
        /// this is a constructor for the side selection
        /// </summary>
        /// <param name="combo"> combo passed in to go back with click</param>
        public SideSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        /// <summary>
        /// event handler for adding fries to order via button click
        /// </summary>
        /// <param name="sender"> button clicked</param>
        /// <param name="args"> arguement</param>
        private void OnSelectFryceritops(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Fryceritops();
                if (combo != null)
                {
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else 
                    order.Add(side);
            } 
        }

        /// <summary>
        /// event handler for adding mac to order via button click
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="args">argument</param>
        private void OnSelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MeteorMacAndCheese();
                if (combo != null)
                {
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                    order.Add(side);
            }
        }

        /// <summary>
        /// event handler for ading mezzorella sticks to order via button click
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="args">argument</param>
        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new MezzorellaSticks();
                if (combo != null)
                {
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                    order.Add(side);
            }
        }

        /// <summary>
        /// event handler for adding tots to order via button click
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="args">argument</param>
        private void OnSelectTriceritots(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                side = new Triceritots();
                if (combo != null)
                {
                    combo.Side = side;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                    order.Add(side);
            }
        }
       
        /// <summary>
        /// event handler for setting the size of the side item
        /// </summary>
        /// <param name="sender">wsize button clicked</param>
        /// <param name="args">argument</param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                if (combo == null)
                    side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }

            if (combo == null)
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
