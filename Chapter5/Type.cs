namespace chapter5_new;

public enum Type
{
    Acoustic,
    Electric
}

public static class TypeExtensions
{
    public static string ToStringValue(this Type type)
    {
        switch (type)
        {
            case Type.Acoustic: return "acoustic";
            case Type.Electric: return "electric";
            default: return "unspecified";
        }
    }
}