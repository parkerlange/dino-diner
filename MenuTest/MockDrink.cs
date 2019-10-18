using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MockDrink : Drink
    {
        public override string Description => throw new NotImplementedException();

        public override string[] Special => throw new NotImplementedException();

        public MockDrink(double price)
        {
            Price = price; 
        }
    }
}
