namespace Chapter1;

public class Guitar
{
    public string SerialNumber { get; set; }
    public double Price { get; set; }
    public int NumberOfStrings { get; set; }
    public GuitarSpec Spec { get; set; }
    
    public Guitar(string serialNumber, double price, GuitarSpec spec)
    {
        SerialNumber = serialNumber;
        Price = price;
        Spec = spec;
    }
}
