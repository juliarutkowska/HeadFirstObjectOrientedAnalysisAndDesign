namespace Chapter10;

public class Subway
    {
        private List<Station> _stations;
        private List<Connection> _connections;
        private Dictionary<Station, List<Station>> _network;

        public Subway()
        {
            _stations = new List<Station>();
            _connections = new List<Connection>();
            _network = new Dictionary<Station, List<Station>>();
        }

        public void AddStation(string stationName)
        {
            if (HasStation(stationName)) return;
            var station = new Station(stationName);
            _stations.Add(station);
        }

        public bool HasStation(string stationName)
        {
            return _stations.Exists(station => station.Name == stationName);
        }

        public void AddConnection(string station1Name, string station2Name, string lineName)
        {
            if (HasStation(station1Name) && HasStation(station2Name))
            {
                var station1 = _stations.Find(station => station.Name == station1Name);
                var station2 = _stations.Find(station => station.Name == station2Name);
                var connection = new Connection(station1, station2, lineName);
                _connections.Add(connection);
                _connections.Add(new Connection(station2, station1, connection.LineName));

                AddToNetwork(station1, station2);
                AddToNetwork(station2, station1);
            }
            else
            {
                throw new Exception($"Invalid connection: {station1Name} + {station2Name} + {lineName}");
            }
        }

        private void AddToNetwork(Station station1, Station station2)
        {
            if (_network.ContainsKey(station1))
            {
                var connectingStations = _network[station1];
                if (!connectingStations.Contains(station2))
                {
                    connectingStations.Add(station2);
                }
            }
            else
            {
                var connectingStations = new List<Station>();
                connectingStations.Add(station2);
                _network[station1] = connectingStations;
            }
        }

        public List<Connection> GetDirections(string startStationName, string endStationName)
        {
            if (!HasStation(startStationName) || !HasStation(endStationName))
            {
                throw new Exception("Stations entered do not exist on this subway");
            }

            var start = _stations.Find(station => station.Name == startStationName);
            var end = _stations.Find(station => station.Name == endStationName);
            var route = new List<Connection>();
            var reachableStations = new List<Station>();
            var previousStations = new Dictionary<Station, Station>();
            var neighbors = _network[start];

            foreach (var neighbor in neighbors)
            {
                if (neighbor.Equals(end))
                {
                    route.Add(GetConnection(start, end));
                    return route;
                }

                reachableStations.Add(neighbor);
                previousStations[neighbor] = start;
            }

            var nextStations = new List<Station>(neighbors);
            var currentStation = start;

            foreach (var station in _stations)
            {
                var tmpNextStations = new List<Station>();
                foreach (var currentNeighbor in _network[currentStation])
                {
                    if (currentNeighbor.Equals(end))
                    {
                        reachableStations.Add(currentNeighbor);
                        previousStations[currentNeighbor] = currentStation;
                        break;
                    }

                    if (!reachableStations.Contains(currentNeighbor))
                    {
                        reachableStations.Add(currentNeighbor);
                        tmpNextStations.Add(currentNeighbor);
                        previousStations[currentNeighbor] = currentStation;
                    }
                }
                nextStations = new List<Station>(tmpNextStations);
            }

            var keepLooping = true;
            var keyStation = end;

            while (keepLooping)
            {
                var station = previousStations[keyStation];
                route.Insert(0, GetConnection(station, keyStation));
                if (start.Equals(station))
                {
                    keepLooping = false;
                }
                keyStation = station;
            }

            return route;
        }

        private Connection GetConnection(Station station1, Station station2)
        {
            foreach (var connection in _connections)
            {
                if (station1.Equals(connection.Station1) && station2.Equals(connection.Station2))
                {
                    return connection;
                }
            }
            return null;
        }

        public bool HasConnection(string station1Name, string station2Name, string lineName)
        {
            var station1 = _stations.Find(station => station.Name == station1Name); 
            var station2 = _stations.Find(station => station.Name == station2Name);
            foreach (var connection in _connections)
            {
                if (connection.LineName.Equals(lineName, StringComparison.OrdinalIgnoreCase))
                {
                    if (station2 != null && station1 != null && connection.Station1.Equals(station1) && (connection.Station2.Equals(station2)))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

//private List<Station> _stations;
// private List<Connection> _connections;
//     
// public Subway()
// {
//     _stations = new List<Station>();
//     _connections = new List<Connection>();
// }
//
// public void AddStation(string stationName)
// {
//     if (!HasStation(stationName))
//     {
//         var station = new Station(stationName);
//         _stations.Add(station);
//     }
// }
//
// public bool HasStation(string stationName)
// {
//     return _stations.Contains(new Station(stationName));
// }
//
// public void AddConnection(string station1Name, string station2Name, string lineName)
// {
//     if (HasStation(station1Name) && HasStation(station2Name))
//     {
//         var station1 = new Station(station1Name);
//         var station2 = new Station(station2Name);
//         var connection = new Connection(station1, station2, lineName);
//         _connections.Add(connection);
//         _connections.Add(new Connection(station2, station1, connection.LineName));
//     }
//     else
//     {
//         throw new ArgumentException("Invalid connection!");
//     }
// }
//
// public bool HasConnection(string station1Name, string station2Name, string lineName)
// {
//     var station1 = new Station(station1Name);
//     var station2 = new Station(station2Name);
//     foreach (var connection in _connections)
//     {
//         if (connection.LineName.Equals(lineName, StringComparison.OrdinalIgnoreCase))
//         {
//             if (connection.Station1.Equals(station1) && connection.Station2.Equals(station2))
//             {
//                 return true;
//             }
//         }
//     }
//     return false;
// }