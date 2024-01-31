using System.Diagnostics.Metrics;

namespace Chapter5_ClassesFromOldVersion;

public class Mandolin : Instrument
{
    public Mandolin(string serialNumber, double price, MandolinSpec spec)
        : base(serialNumber, price, spec)
    {
        throw new NotImplementedException();
    }
}