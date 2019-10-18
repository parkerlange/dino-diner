using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu; 

namespace MenuTest
{
    public class MockEntree : Entree
    {
        public override string Description => throw new NotImplementedException();

        public override string[] Special => throw new NotImplementedException();
        public MockEntree(double price)
        {
            Price = price; 
        }
    }
}
