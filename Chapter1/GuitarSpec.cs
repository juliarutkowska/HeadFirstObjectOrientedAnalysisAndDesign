namespace Chapter1;

public class GuitarSpec
{
    public Builder Builder { get; }
    public string Model { get; }
    public Type Type { get; }
    public Wood BackWood { get; }
    public Wood TopWood { get; }
    
    public GuitarSpec (Builder builder, string model, Type type, Wood backWood, Wood topWood)
    {
        Builder = builder;
        Model = model;
        Type = type;
        BackWood = backWood;
        TopWood = topWood;
    }
}