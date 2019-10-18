using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace MenuTest
{
    public class MockSide : Side
    {
        public MockSide(double price)
        {
            Price = price; 
        }

        public override string Description => throw new NotImplementedException();

        public override string[] Special => throw new NotImplementedException();
    }
}
