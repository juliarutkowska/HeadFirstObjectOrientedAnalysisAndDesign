namespace Chapter10;

public class Connection
{
    public Station Station1 { get; set; }
    public Station Station2 { get; set; }
    public string LineName { get; set; }

    public Connection(Station station1, Station station2, string lineName)
    {
        Station1 = station1;
        Station2 = station2;
        LineName = lineName;
    }
}