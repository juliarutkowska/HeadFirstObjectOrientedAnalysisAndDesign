namespace chapter5_new;

public enum Style
{
    A,
    F
}

public static class StyleExtensions
{
    public static string ToStringValue(this Style style)
    {
        switch (style)
        {
            case Style.A: return "A style";
            case Style.F: return "F style";
            default: return "Unspecified";
        }
    }
}