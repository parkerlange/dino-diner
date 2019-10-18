using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu; 

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void SubtotalPriceShouldBeCorrectSum()
        {
            CretaceousCombo c = new CretaceousCombo(new MockEntree(8.00));
            c.Drink = new MockDrink(1.50);
            c.Side = new MockSide(3.00);
            Order o = new Order();
            o.Items.Add(c);
            Assert.Equal<double>(12.50, o.SubtotalCost);
        }
    }
}
