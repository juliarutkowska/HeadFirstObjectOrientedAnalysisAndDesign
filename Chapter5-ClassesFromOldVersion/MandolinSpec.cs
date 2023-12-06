namespace Chapter5;

public class MandolinSpec: InstrumentSpec
{
    private Style Style { get; set; }
    public MandolinSpec(Builder builder, string model, Type type, Style style, Wood topWood, Wood backWood) 
        : base(builder, model, type, topWood, backWood)
    {
        Style = style;
    }

    public bool Matches(InstrumentSpec otherSpec)
    {
        if (!base.Matches(otherSpec))
        {
            return false;
        }

        if (!(otherSpec is MandolinSpec))
        {
            return false;
        }

        var spec = (MandolinSpec)otherSpec;
        if (Style != spec.Style)
        {
            return false;
        }

        return true;
    }
}