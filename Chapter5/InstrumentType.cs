namespace Chapter5;

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
        return instrumentType switch
        {
            InstrumentType.Guitar => "Guitar",
            InstrumentType.Banjo => "Banjo",
            InstrumentType.Dobro => "Dobro",
            InstrumentType.Fiddle => "Fiddle",
            InstrumentType.Bass => "Bass",
            InstrumentType.Mandolin => "Mandolin",
            _ => "Unspecified"
        };
    }
}