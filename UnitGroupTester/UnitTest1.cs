using Chapter6;
using System.Collections.Generic;
using Xunit;
using AutoFixture;
using AutoFixture.Xunit2;
namespace UnitGroupTester;
using Xunit.Abstractions;
using Xunit.Sdk;

    public class UnitGroupTests
    {
        [Theory]
        [AutoData]
        public void AddUnit_Always_AddsUnitToList(UnitGroup unitGroup, Unit unit)
        {
            unitGroup.AddUnit(unit);
            Assert.Contains(unit, unitGroup.GetUnits());
        }

        [Theory]
        [AutoData]
        public void RemoveUnit_WithExistingUnit_RemovesUnitFromList(UnitGroup unitGroup, Unit unit)
        {
            unitGroup.AddUnit(unit);
            unitGroup.RemoveUnit(unit);
            Assert.DoesNotContain(unit, unitGroup.GetUnits());
        }

        [Theory]
        [AutoData]
        public void RemoveUnit_WithNonExistingUnit_DoesNothing(UnitGroup unitGroup, Unit unit)
        {
            unitGroup.RemoveUnit(unit);
            Assert.DoesNotContain(unit, unitGroup.GetUnits());
        }

        [Theory]
        [AutoData]
        public void GetUnit_WithExistingId_ReturnsUnit(UnitGroup unitGroup, Unit unit)
        {
            unitGroup.AddUnit(unit);
            var retrievedUnit = unitGroup.GetUnit(unit.Id);
            Assert.Equal(unit, retrievedUnit);
        }

        [Theory]
        [AutoData]
        public void GetUnit_WithNonExistingId_ReturnsNull(UnitGroup unitGroup, int id)
        {
            var retrievedUnit = unitGroup.GetUnit(id);
            Assert.Null(retrievedUnit);
        }
    }