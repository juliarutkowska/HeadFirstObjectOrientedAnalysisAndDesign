namespace Chapter1;

public class GuitarSpec
{
    public Builder Builder { get; }
    public string Model { get; }
    public Type Type { get; }
    public Wood BackWood { get; }
    public Wood TopWood { get; }
    public int NumberOfStrings { get; set; }
    
    public GuitarSpec (Builder builder, string model, Type type, Wood backWood, Wood topWood, int numberOfStrings)
    {
        Builder = builder;
        Model = model;
        Type = type;
        BackWood = backWood;
        TopWood = topWood;
        NumberOfStrings = numberOfStrings;
    }
    
    
    
    //chcemy sprawdzić czy dana gitara spełnia daną specyfikację

    public bool GuitarFulfillsSpec(Guitar guitar)
    {
        return guitar.Spec.Builder == Builder
               && guitar.Spec.Model == Model
               && guitar.Spec.Type == Type
               && guitar.Spec.BackWood == BackWood
               && guitar.Spec.TopWood == TopWood
               && guitar.Spec.NumberOfStrings == NumberOfStrings;
    }
}