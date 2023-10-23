namespace Chapter1;

public class Guitar
{
    public string SerialNumber { get; }
    public double Price { get; set; }
    GuitarSpec Spec { get; }
    
    public Guitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood)
    {
        
        SerialNumber = serialNumber;
        Price = price;
        Spec = new GuitarSpec(builder, model, type, backWood, topWood);
    }
}