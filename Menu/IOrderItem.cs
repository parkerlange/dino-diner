/* Author: Parker Lange
 * IOrderItem.cs
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This is the interface for IOrderItem
    /// it will be supported by the gui
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// double value holding the price of the item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// string holding a description of the item
        /// it is the same as the to string method
        /// </summary>
        string Description { get; }
        /// <summary>
        /// this is an array of strings holding special requests for the menu item
        /// such as held bun, lettuce, etc
        /// </summary>
        string [] Special { get;  }
    }
}
