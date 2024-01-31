using System.Diagnostics.Metrics;

namespace Chapter5_ClassesFromOldVersion;

public class Guitar: Instrument
{
    public Guitar(string serialNumber, double price, InstrumentSpec spec)
        : base(serialNumber, price, spec)
    {
        throw new NotImplementedException();
    }
}
