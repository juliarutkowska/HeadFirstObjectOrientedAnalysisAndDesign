namespace Chapter5;

public class Guitar: Instrument
{
    public Guitar(string serialNumber, double price, InstrumentSpec spec)
        : base(serialNumber, price, spec)
    {
        throw new NotImplementedException();
    }
}
