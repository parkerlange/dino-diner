using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //The correct default price, calories, ice, size, lemon, and sweet properties.
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        [Fact]
        public void ShouldHaveDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void ShouldHaveCorrectIceAfterHoldingIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        //That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void ShouldHaveCorrectLemonAfterInvokingAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        //That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetTrueForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small; 
            tea.Sweet = true;
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetTrueForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            Assert.Equal<uint>(32, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSweetTrueForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            Assert.Equal<uint>(64, tea.Calories);
        }
        //That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmallAfterSettingSweetFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForMediumAfterSettingSweetFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForLargeAfterSettingSweetFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(32, tea.Calories);
        }
        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIngredientsAfterAddingLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon(); 
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);
        }
        [Fact]
        public void ShouldHaveCorrectDefaultIngredientsAfterMakingTeaSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true; 
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);
        }
    }
}
