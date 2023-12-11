namespace chapter5_new;

public enum InstrumentType
{
    Guitar,
    Banjo,
    Dobro,
    Fiddle,
    Bass,
    Mandolin
}

public static class InstrumentTypeExtensions
{
    public static string ToStringValue(this InstrumentType instrumentType)
    {
        switch (instrumentType)
        {
            case InstrumentType.Guitar: return "Guitar";
            case InstrumentType.Banjo: return "Banjo";
            case InstrumentType.Dobro: return "Dobro";
            case InstrumentType.Fiddle: return "Fiddle";
            case InstrumentType.Bass: return "Bass";
            case InstrumentType.Mandolin: return "Mandolin";
            default: return "Unspecified";
        }
    }
}