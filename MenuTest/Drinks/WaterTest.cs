using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        public class JurrasicJavaTest
        {
            //The correct default price, calories, ice, size, and lemon properties.
            [Fact]
            public void ShouldHaveCorrectDefaultPrice()
            {
                Water w = new Water();
                Assert.Equal<double>(0.10, w.Price);
            }
            [Fact]
            public void ShouldHaveCorrectDefaultCalories()
            {
                Water w = new Water();
                Assert.Equal<uint>(0, w.Calories);
            }
            [Fact]
            public void ShouldHaveCorrectDefaultIce()
            {
                Water w = new Water();
                Assert.True(w.Ice);
            }
            [Fact]
            public void ShouldHaveCorrectDefaultSize()
            {
                Water w = new Water();
                Assert.Equal<Size>(Size.Small, w.Size);
            }
            [Fact]
            public void ShouldHaveCorrectDefaultLemon()
            {
                Water w = new Water();
                Assert.False(w.Lemon);
            }

            //The correct price and calories after changing to small, medium, and large sizes.
            [Fact]
            public void ShouldHaveCorrectPriceAfterChangingToSmall()
            {
                Water w = new Water();
                w.Size = Size.Medium;
                w.Size = Size.Small;
                Assert.Equal<double>(0.10, w.Price);
            }
            [Fact]
            public void ShouldHaveCorrectCaloriesAfterChangingToSmall()
            {
                Water w = new Water();
                w.Size = Size.Medium;
                w.Size = Size.Small;
                Assert.Equal<uint>(0, w.Calories);
            }
            [Fact]
            public void ShouldHaveCorrectPriceAfterChangingToMedium()
            {
                Water w = new Water();
                w.Size = Size.Medium;
                Assert.Equal<double>(0.10, w.Price);
            }
            [Fact]
            public void ShouldHaveCorrectCaloriesAfterChangingToMedium()
            {
                Water w = new Water();
                w.Size = Size.Medium;
                Assert.Equal<uint>(0, w.Calories);
            }
            [Fact]
            public void ShouldHaveCorrectPriceAfterChangingToLarge()
            {
                Water w = new Water();
                w.Size = Size.Large;
                Assert.Equal<double>(0.10, w.Price);
            }
            [Fact]
            public void ShouldHaveCorrectCaloriesAfterChangingToLarge()
            {
                Water w = new Water();
                w.Size = Size.Large;
                Assert.Equal<uint>(0, w.Calories);
            }

            //That invoking HoldIce() results in the Ice property being false
            [Fact]
            public void ShouldHaveNoIceAfterInvokingHoldIce()
            {
                Water w = new Water();
                w.HoldIce();
                Assert.False(w.Ice);
            }

            //That invoking AddLemon() sets results in the Lemon property being true.
            [Fact]
            public void ShouldHaveLemonAfterInvokingAddLemon()
            {
                Water w = new Water();
                w.AddLemon();
                Assert.True(w.Lemon);
            }

            //The correct ingredients are given.
            [Fact]
            public void ShouldHaveCorrectDefaultIngredients()
            {
                Water w = new Water();
                Assert.Contains<string>("Water", w.Ingredients);
                Assert.Equal<int>(1, w.Ingredients.Count);
            }
            [Fact]
            public void ShouldHaveCorrectIngredientsAfterAddingLemon()
            {
                Water w = new Water();
                w.AddLemon();
                Assert.Contains<string>("Water", w.Ingredients);
                Assert.Contains<string>("Lemon", w.Ingredients);
                Assert.Equal<int>(2, w.Ingredients.Count);
            }

            [Theory]
            [InlineData(Size.Small)]
            [InlineData(Size.Medium)]
            [InlineData(Size.Large)]
            public void WaterToStringShouldGiveNameForSize(Size size)
            {
                Water water = new Water();
                water.Size = size;
                Assert.Equal($"{size} Water", water.Description);
            }

            [Fact]
            public void SpecialShouldBeEmptyByDefault()
            {
                Water water = new Water();
                Assert.Empty(water.Special);
            }


            [Fact]
            public void AddLemonShouldAddToSpecial()
            {
                Water water = new Water();
                water.AddLemon();
                Assert.Collection<string>(water.Special, item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
            }

            [Fact]
            public void HoldIceShouldAddToSpecial()
            {
                Water water = new Water();
                water.HoldIce();
                Assert.Collection<string>(water.Special, item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
            }

            [Fact]
            public void HoldAllShouldAddToSpecial()
            {
                Water water = new Water();
                water.AddLemon();
                water.HoldIce();
                Assert.Collection<string>(water.Special, item =>
                {
                    Assert.Equal("Add Lemon", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
            }

            [Theory]
            [InlineData(Size.Small)]
            [InlineData(Size.Medium)]
            [InlineData(Size.Large)]
            public void ChangingSizeShouldNotifyDescriptionChange(Size size)
            {
                Water water = new Water();
                Assert.PropertyChanged(water, "Description", () =>
                {
                    water.Size = size; 
                });
            }

            [Theory]
            [InlineData(Size.Small)]
            [InlineData(Size.Medium)]
            [InlineData(Size.Large)]
            public void ChangingSizeShouldNotifySizeChange(Size size)
            {
                Water water = new Water();
                Assert.PropertyChanged(water, "Size", () =>
                {
                    water.Size = size;
                });
            }

            [Fact]
            public void AddingLemonShouldNotifySpecialChange()
            {
                Water water = new Water();
                Assert.PropertyChanged(water, "Special", () =>
                {
                    water.AddLemon();
                });
            }

            [Fact]
            public void AddingLemonShouldNotifyIngredientsChange()
            {
                Water water = new Water();
                Assert.PropertyChanged(water, "Ingredients", () =>
                {
                    water.AddLemon();
                });
            }

            [Fact]
            public void RemovingIceShouldNotifySpecialChange()
            {
                Water water = new Water();
                Assert.PropertyChanged(water, "Special", () =>
                {
                    water.HoldIce();
                });
            }
        }
    }
}
