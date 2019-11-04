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
            c.Drink = new MockDrink(1.25);
            c.Side = new MockSide(3.00);
            Order o = new Order();
            o.Add(c);
            Assert.Equal<double>(12.00, o.SubtotalCost);
        }

        [Fact]
        public void SalesTaxCalculationShouldBeCorrect()
        {
            CretaceousCombo c = new CretaceousCombo(new MockEntree(8.00));
            c.Drink = new MockDrink(1.25);
            c.Side = new MockSide(3.00);
            Order o = new Order();
            o.Add(c);
            //o.SalesTaxRate = 0.05; 
            Assert.Equal<double>(0.72, o.SalesTaxCost);
        }

        [Fact]
        public void TotalPriceCalculationShouldBeCorrect()
        {
            CretaceousCombo c = new CretaceousCombo(new MockEntree(8.00));
            c.Drink = new MockDrink(1.25);
            c.Side = new MockSide(3.00);
            Order o = new Order();
            o.Add(c);
            //o.SalesTaxRate = 0.05;
            Assert.Equal<double>(12.72, o.TotalCost);
        }

        [Fact]
        public void NegativeSumCalculationShouldSetToZero()
        {
            CretaceousCombo c = new CretaceousCombo(new MockEntree(-8.00));
            c.Drink = new MockDrink(1.25);
            c.Side = new MockSide(3.00);
            Order o = new Order();
            o.Add(c);
            Assert.Equal<double>(0, o.SubtotalCost);
        }
    }
}
