namespace Chapter6;

using System.Collections.Generic;

    public class Tile
    {
        private List<Unit> _units = new();

        public void AddUnit(Unit unit)
        {
            _units.Add(unit);
        }

        public void RemoveUnit(Unit unit)
        {
            _units.Remove(unit);
        }

        public void RemoveUnits()
        {
            _units.Clear();
        }

        public List<Unit> GetUnits()
        {
            return _units;
        }
    }