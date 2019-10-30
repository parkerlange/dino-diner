/* Author: Parker Lange
 * EntreeSelection.xaml
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// entree item we modify throughout the class 
        /// </summary>
        public Entree entree { get; set; }
        /// <summary>
        /// this is the initialization for the entree selection page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the initialization for the entree selection page
        /// </summary>
        /// <param name="entree">entree item passed in</param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.entree = entree; 
        }

        /// <summary>
        /// event handler for the brat add to order
        /// </summary>
        /// <param name="sender"> object </param>
        /// <param name="arg">button click</param>
        private void OnSelectBrontowurst(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
            }

            NavigationService.Navigate(new CustomizeBrontowurst((Brontowurst)entree));

        }
        /// <summary>
        /// event handler for the nuggets add to order
        /// </summary>
        /// <param name="sender"> object </param>
        /// <param name="arg"> button click </param>
        private void OnSelectDinoNuggets(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
            }

            NavigationService.Navigate(new CustomizeDinoNuggets((DinoNuggets)entree));

        }

        /// <summary>
        /// event handler for adding burger to order
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="arg"> ubtton click</param>
        private void OnSelectSteakosaurusBurger(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
            }
            NavigationService.Navigate(new CustomizeSteakosaurusBurger((SteakosaurusBurger)entree));

        }
        /// <summary>
        /// event handler for adding t rex to order
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="arg">button lcikc</param>
        private void OnSelectTRexKingBurger(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
            }

            NavigationService.Navigate(new CustomizeTRexBurger((TRexKingBurger)entree));

        }

        /// <summary>
        /// event handler for adding pbj to order
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="arg"> button click </param>
        private void OnSelectPrehistoricPBJ(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
            }

            NavigationService.Navigate(new CustomizePrehistoricPBJ((PrehistoricPBJ)entree));
        }
        /// <summary>
        /// event handler for adding wings to order
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="arg">button click </param>
        private void OnSelectPterodactylWings(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
            }

            NavigationService.Navigate(new MenuCategorySelection());
        }
        /// <summary>
        /// event handler for adding wrap to order
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="arg"> button click</param>
        private void OnSelectVelociWrap(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
            }

            NavigationService.Navigate(new CustomizeVelociWrap((VelociWrap)entree));

        }

    }
}
