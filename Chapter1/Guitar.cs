namespace Chapter1;

public class Guitar
{
    public string SerialNumber { get; }
    public double Price { get; }
    public string Model { get; }
    public Builder Builder { get; }
    public Type Type { get; }
    public Wood BackWood { get; }
    public Wood TopWood { get; }
    public GuitarSpec Spec { get; set; }
    public int NumberOfStrings { get; set; }
    
    public Guitar(string serialNumber, double price, GuitarSpec spec)
    {
        SerialNumber = serialNumber;
        Price = price;
        Spec = spec;
    }
}
