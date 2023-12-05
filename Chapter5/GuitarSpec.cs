namespace Chapter5;

public class GuitarSpec: InstrumentSpec
{
    public int NumberOfStrings { get; set; }
    
    public GuitarSpec (Builder builder, string model, Type type, Wood backWood, Wood topWood, int numberOfStrings) 
        : base(builder, model, type, backWood, topWood)
    {
        NumberOfStrings = numberOfStrings;
    }

    public bool Matches(InstrumentSpec otherSpec)
    {
        if (!base.Matches(otherSpec))
        {
            return false;
        }
        
        if (!(otherSpec is GuitarSpec))
        {
            return false;
        }
        
        var spec = (GuitarSpec)otherSpec;
        
        if(NumberOfStrings != spec.NumberOfStrings)
        {
            return false;
        }
        return true;
    }
    
}