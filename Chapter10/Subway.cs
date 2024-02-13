namespace Chapter10;

public class Subway
{
    private List<Station> _stations;
    private List<Connection> _connections;
    
    public Subway()
    {
        _stations = new List<Station>();
        _connections = new List<Connection>();
    }

    public void AddStation(string stationName)
    {
        if (!HasStation(stationName))
        {
            var station = new Station(stationName);
            _stations.Add(station);
        }
    }

    public bool HasStation(string stationName)
    {
        return _stations.Contains(new Station(stationName));
    }

    public void AddConnection(string station1Name, string station2Name, string lineName)
    {
        if (HasStation(station1Name) && HasStation(station2Name))
        {
            var station1 = new Station(station1Name);
            var station2 = new Station(station2Name);
            var connection = new Connection(station1, station2, lineName);
            _connections.Add(connection);
            _connections.Add(new Connection(station2, station1, connection.LineName));
        }
        else
        {
            throw new ArgumentException("Invalid connection!");
        }
    }

    public bool HasConnection(string station1Name, string station2Name, string lineName)
    {
        var station1 = new Station(station1Name);
        var station2 = new Station(station2Name);
        foreach (var connection in _connections)
        {
            if (connection.LineName.Equals(lineName, StringComparison.OrdinalIgnoreCase))
            {
                if (connection.Station1.Equals(station1) && connection.Station2.Equals(station2))
                {
                    return true;
                }
            }
        }
        return false;
    }
}