namespace Chapter10;

public class SubwayPrinter
{
    private StreamWriter _writer;

    public SubwayPrinter(Stream outputStream)
    {
        _writer = new StreamWriter(outputStream);
    }

    public void PrintDirections(List<Connection> route)
    {
        var connection = route[0];
        var currentLine = connection.LineName;
        var previousLine = currentLine;

        _writer.WriteLine($"Start out at {connection.Station1.Name}.");
        _writer.WriteLine($"Get on the {currentLine} heading towards {connection.Station2.Name}.");

        for (var i = 1; i < route.Count; i++)
        {
            connection = route[i];
            currentLine = connection.LineName;

            Console.WriteLine($"Processing connection: {connection.Station1.Name} to {connection.Station2.Name}, Line: {currentLine}");

            if (currentLine.Equals(previousLine))
            {
                _writer.WriteLine($"Continue past {connection.Station1.Name}...");
            }
            else
            {
                _writer.WriteLine($"When you get to {connection.Station1.Name} get off the {previousLine}.");
                _writer.WriteLine($"Switch over to the {currentLine}, heading towards {connection.Station2.Name}.");
                previousLine = currentLine;
            }
        }
        _writer.WriteLine($"Get off at {connection.Station2.Name} and enjoy yourself!");
        _writer.Flush();
    }
}