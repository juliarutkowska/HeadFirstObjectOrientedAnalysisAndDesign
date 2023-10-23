namespace Chapter1;

public class GuitarSpec
{

    Builder Builder { get; }
    string Model { get; }
    Type Type { get; }
    Wood BackWood { get; }
    Wood TopWood { get; }
    
    public GuitarSpec (Builder builder, string model, Type type, Wood backWood, Wood topWood)
    {
        Builder = builder;
        Model = model;
        Type = type;
        BackWood = backWood;
        TopWood = topWood;
    }
}