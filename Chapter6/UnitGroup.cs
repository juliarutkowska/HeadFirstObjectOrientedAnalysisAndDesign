namespace Chapter6;

public class UnitGroup
{
    private Dictionary<int, Unit> _units;
    public UnitGroup() : this(new List<Unit>()) { }
    public UnitGroup(List<Unit> unitList)
    { 
        _units = new Dictionary<int, Unit>();
        foreach (var unit in unitList)
        {
            _units[unit.Id] = unit;
        }
    }

    public void AddUnit(Unit unit)
    {
        _units[unit.Id] = unit;
    }

    private void RemoveUnit(int id)
    {
        _units.Remove(id);
    }

    public void RemoveUnit(Unit unit)
    {
        RemoveUnit(unit.Id);
    }

    public Unit GetUnit(int id)
    {
        Unit unit;
        _units.TryGetValue(id, out unit);
        return unit ?? null;
    }
    
    public List<Unit> GetUnits()
    {
        var unitList = new List<Unit>();
        foreach (KeyValuePair<int, Unit> entry in _units)
        {
            unitList.Add(entry.Value);
        }
        return unitList;
    }
}