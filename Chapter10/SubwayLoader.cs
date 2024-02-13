namespace Chapter10;

public class SubwayLoader
{
    private Subway _subway;

    public SubwayLoader()
    {
        _subway = new Subway();
    }

    public Subway LoadFromFile(FileInfo subwayFile)
    {
        using (var reader = new StreamReader(subwayFile.FullName))
        {
            LoadStations(_subway, reader);
            var lineName = reader.ReadLine();
            while (lineName != null && lineName.Length > 0)
            {
                LoadLine(_subway, reader, lineName);
                lineName = reader.ReadLine();
            }
        }
        return _subway;
    }
    
    private void LoadStations(Subway subway, StreamReader reader)
    {
        var currentLine = reader.ReadLine();
        while (currentLine != null && currentLine.Length > 0)
        {
            subway.AddStation(currentLine);
            currentLine = reader.ReadLine();
        }
    }

    private void LoadLine(Subway subway, StreamReader reader, string lineName)
    {
        var station1Name = reader.ReadLine();
        var station2Name = reader.ReadLine();

        while (station2Name is { Length: > 0 })
        {
            if (station1Name != null) subway.AddConnection(station1Name, station2Name, lineName);
            station1Name = station2Name;
            station2Name = reader.ReadLine();
        }
    }
    
}