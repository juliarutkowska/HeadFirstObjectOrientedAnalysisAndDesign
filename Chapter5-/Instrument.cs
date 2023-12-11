namespace chapter5_new;

    public class Instrument
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public InstrumentSpec Spec { get; set; }

        public Instrument(string serialNumber, double price, InstrumentSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }
    }