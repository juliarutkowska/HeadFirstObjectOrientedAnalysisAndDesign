namespace chapter5_new;

using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    private List<Instrument> _inventory;

    public Inventory()
    {
        _inventory = new List<Instrument>();
    }

    public void AddInstrument(string serialNumber, double price, InstrumentSpec spec)
    {
        Instrument instrument = new Instrument(serialNumber, price, spec);
        _inventory.Add(instrument);
    }

    public Instrument Get(string serialNumber)
    {
        return _inventory.FirstOrDefault(instrument => instrument.SerialNumber == serialNumber);
    }

    public List<Instrument> Search(InstrumentSpec searchSpec)
    {
        return _inventory.Where(instrument => instrument.Spec.Matches(searchSpec)).ToList();
    }
}