using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests
{
    [UsedImplicitly]
    public partial class QuantityTests
    {
        /// <summary>
        /// Tests constructors of quantity types.
        /// </summary>
        public class Ctor
        {
            [Fact]
            public void CtorWithOnlyValueOfRepresentativeTypes_SetsValueToGivenValueAndUnitToBaseUnit()
            {
#pragma warning disable 618
                // double types
                Assert.Equal(5, new Mass(5L).Value);
                Assert.Equal(5, new Mass(5d).Value);
                Assert.Equal(5, new Mass(5m).Value);
                Assert.Equal(MassUnit.Kilogram, new Mass(5L).Unit);
                Assert.Equal(MassUnit.Kilogram, new Mass(5d).Unit);
                Assert.Equal(MassUnit.Kilogram, new Mass(5m).Unit);

                // logarithmic types
                Assert.Equal(5, new Level(5L).Value);
                Assert.Equal(5, new Level(5d).Value);
                Assert.Equal(5, new Level(5m).Value);
                Assert.Equal(LevelUnit.Decibel, new Level(5L).Unit);
                Assert.Equal(LevelUnit.Decibel, new Level(5d).Unit);
                Assert.Equal(LevelUnit.Decibel, new Level(5m).Unit);
#pragma warning restore 618
            }

            [Fact]
            public void CtorWithValueAndUnitOfRepresentativeTypes_SetsValueAndUnit()
            {
                // double types
                var mass = new Mass(5L, MassUnit.Centigram);
                Assert.Equal(5, mass.Value);
                Assert.Equal(MassUnit.Centigram, mass.Unit);

                // logarithmic types
                var level = new Level(5, LevelUnit.Neper);
                Assert.Equal(5, level.Value);
                Assert.Equal(LevelUnit.Neper, level.Unit);
            }
        }
    }
}
