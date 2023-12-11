namespace chapter5_new;

public enum Wood
{
    IndianRosewood,
    BrazilianRosewood,
    Mahogany, 
    Maple,
    Cocobolo,
    Cedar,
    Adirondack,
    Alder,
    Sitka
}

public static class WoodExtensions
{
    public static string ToStringValue(this Wood wood)
    {
        switch (wood)
        {
            case Wood.IndianRosewood: return "Indian Rosewood";
            case Wood.BrazilianRosewood: return "Brazilian Rosewood";
            case Wood.Mahogany: return "Mahogany";
            case Wood.Maple: return "Maple";
            case Wood.Cocobolo: return "Cocobolo";
            case Wood.Cedar: return "Cedar";
            case Wood.Adirondack: return "Adirondack";
            case Wood.Alder: return "Alder";
            case Wood.Sitka: return "Sitka";
            default: return "unspecified";
        }
    }
}