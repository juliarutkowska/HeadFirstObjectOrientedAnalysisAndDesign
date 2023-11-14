namespace Chapter1;

public record Specification(Builder builder, string model, Type type, Wood backWood, Wood topWood, int numberOfStrings);
public class GuitarSpec
{
    public Builder Builder { get; set; }
    public string Model { get; set; }
    public Type Type { get;set; }
    public Wood BackWood { get; set; }
    public Wood TopWood { get;set; }
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
        var x = Builder == guitar.Spec.Builder
                && Model == guitar.Spec.Model
                && Type == guitar.Spec.Type
                && BackWood == guitar.Spec.BackWood
                && TopWood == guitar.Spec.TopWood
                && NumberOfStrings == guitar.Spec.NumberOfStrings;
                return x;
    }
    
}