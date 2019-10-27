/* Author: Parker Lange
 * Order.cs
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel; 

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// this is a collection of all the items in a given order
        /// </summary>
        private List<IOrderItem> items;
        public IOrderItem[] Items
        {
            get { return items.ToArray();  }
        }
        /// <summary>
        /// notification for the price change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// this is the subtotal cost of the order
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double totalPrice = 0; 
                foreach (IOrderItem item in Items)
                {
                    totalPrice += item.Price; 
                }

                if (totalPrice < 0)
                    totalPrice = 0; 

                return Math.Round(totalPrice, 2); 
            }
        }

        /// <summary>
        /// this is the sales tax rate
        /// </summary>
        public double SalesTaxRate
        {
            get { return SalesTaxRate; }
            set
            {
                if (value < 0) return;
                SalesTaxRate = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxRate"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
        }

        /// <summary>
        /// this is the cost of sales tax for the order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return Math.Round(SalesTaxRate * SubtotalCost, 2, MidpointRounding.AwayFromZero);
            }
        }
        /// <summary>
        /// this is the total cost of the order
        /// </summary>
        public double TotalCost
        {
            get
            {
                return Math.Round(SubtotalCost + SalesTaxCost, 2, MidpointRounding.AwayFromZero);
            }
        }

        public Order()
        {
            items = new List<IOrderItem>();
        }
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnCollectionChanged;
            items.Add(item);
            OnCollectionChanged(this, new EventArgs()); 
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            OnCollectionChanged(this, new EventArgs());
        }
        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
    }
}
