using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //The correct default price, calories, ice, size, and SpaceForCream properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<double>(0.59, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<uint>(2, java.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.Ice);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.roomForCream);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultDecafValue()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.False(java.decaf);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterChangingToSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<double>(0.59, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingToSmall()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            java.Size = Size.Small;
            Assert.Equal<uint>(2, java.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterChangingToMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(0.99, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingToMedium()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Medium;
            Assert.Equal<uint>(4, java.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterChangingToLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterChangingToLarge()
        {
            JurrasicJava java = new JurrasicJava();
            java.Size = Size.Large;
            Assert.Equal<uint>(8, java.Calories);
        }

        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void ShouldHaveIceAfterInvokingAddIce()
        {
            JurrasicJava java = new JurrasicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true.
        [Fact]
        public void ShouldHaveRoomForCreamAfterInvokingRoomForCream()
        {
            JurrasicJava java = new JurrasicJava();
            java.LeaveRoomForCream();
            Assert.True(java.roomForCream);
        }
        
        // invoking Decafinate() results in the decaf property being set true
        [Fact]
        public void ShouldBeDecafinatedAfterInvokingDecafinate()
        {
            JurrasicJava java = new JurrasicJava();
            java.Decafinate();
            Assert.True(java.decaf);
        }
        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurrasicJava java = new JurrasicJava();
            Assert.Contains<string>("Water", java.Ingredients);
            Assert.Contains<string>("Coffee", java.Ingredients);
            Assert.Equal<int>(2, java.Ingredients.Count);
        }
    }
}
