﻿/* Author: Parker Lange
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
        public Entree entree { get; set; }
        /// <summary>
        /// this is the initialization for the entree selection page
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
        }

        private void OnSelectBrontowurst(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Items.Add(entree);
            }
        }
        private void OnSelectDinoNuggets(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Items.Add(entree);
            }
        }
        private void OnSelectSteakosaurusBurger(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Items.Add(entree);
            }
        }
        private void OnSelectTRexKingBurger(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Items.Add(entree);
            }
        }
        private void OnSelectPrehistoricPBJ(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Items.Add(entree);
            }
        }
        private void OnSelectPterodactylWings(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Items.Add(entree);
            }
        }
        private void OnSelectVelociWrap(Object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Items.Add(entree);
            }
        }
        
    }
}
