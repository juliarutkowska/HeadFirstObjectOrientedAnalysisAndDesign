namespace Chapter5;

public class Instrument
{
    public string SerialNumber { get; set; }
    public double Price { get; set; }
    private InstrumentSpec Spec { get; set; }

    public Instrument(string serialNumber, double price, InstrumentSpec spec)
    {
        SerialNumber = serialNumber;
        Price = price;
        Spec = spec;
    }

    public InstrumentSpec GetSpec()
    {
        return Spec;
    }
}