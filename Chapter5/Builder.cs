namespace chapter5_new;
public enum Builder
{
    Fender,
    Martin,
    Gibson,
    Collings,
    Olson,
    Ryan,
    Prs,
    Any
}

public static class BuilderExtensions
{
    public static string ToStringValue(this Builder builder)
    {
        switch (builder)
        {
            case Builder.Fender: return "Fender";
            case Builder.Martin: return "Martin";
            case Builder.Gibson: return "Gibson";
            case Builder.Collings: return "Collings";
            case Builder.Olson: return "Olson";
            case Builder.Ryan: return "Ryan";
            case Builder.Prs: return "PRS";
            default: return "Unspecified";
        }
    }
}