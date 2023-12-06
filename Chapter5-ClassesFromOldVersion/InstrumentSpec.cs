namespace Chapter5;

using System.Collections.Generic;


public class InstrumentSpec
{
    public Builder Builder { get; set; }
    public string Model { get; set; }
    public Type Type { get; set; }
    public Wood BackWood { get; set; }
    public Wood TopWood { get; set; }

    protected InstrumentSpec(Builder builder, string model, Type type, Wood topWood, Wood backWood)
    {
        Builder = builder;
        Model = model;
        Type = type;
        BackWood = backWood;
        TopWood = topWood;
    }

    public bool Matches(InstrumentSpec otherSpec)
    {
        if (Builder != otherSpec.Builder)
            return false;
        if (!string.IsNullOrEmpty(Model) && !Model.Equals("") &&
            !Model.Equals(otherSpec.Model))
            return false;
        if (Type != otherSpec.Type)
            return false;
        if (BackWood != otherSpec.BackWood)
            return false;
        if (TopWood != otherSpec.TopWood)
            return false;
        return true;
    }
}