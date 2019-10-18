/* Author: Parker Lange
 * Order.cs
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Order
    {
        /// <summary>
        /// this is a collection of all the items in a given order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>(); 
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
                    totalPrice =+ item.Price; 
                }

                if (totalPrice < 0)
                    totalPrice = 0; 

                return totalPrice; 
            }
        }

        /// <summary>
        /// this is the sales tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; }

        /// <summary>
        /// this is the cost of sales tax for the order
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }
        /// <summary>
        /// this is the total cost of the order
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
