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
    private GuitarSpec Spec { get; set; }
    
    public Guitar(string serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood)
    {
        
        SerialNumber = serialNumber;
        Price = price;
        Builder = builder;
        Model = model;
        Type = type;
        BackWood = backWood;
        TopWood = topWood;
        Spec = new GuitarSpec(builder, model, type, backWood, topWood);
    }
}