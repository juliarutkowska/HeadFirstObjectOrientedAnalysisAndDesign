using Chapter10;
using System.Text;
using AutoFixture.Xunit2;

namespace SubwayTester;

public class SubwayPrinterTests
{
    [Theory]
    [AutoData]
    public void PrintDirections_PrintsDirectionsCorrectly(List<Connection> connections)
    {
        var outputStream = new MemoryStream();
        var subwayPrinter = new SubwayPrinter(outputStream);

        subwayPrinter.PrintDirections(connections);

        outputStream.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(outputStream);
        var output = reader.ReadToEnd();
        var stringBuilder = new StringBuilder();
        for (var i = 0; i < connections.Count; ++i)
        {
            if (i == 0)
            {
                stringBuilder.AppendLine($"Start out at {connections[i].Station1.Name}.");
                stringBuilder.AppendLine($"Get on the {connections[i].LineName} heading towards {connections[i].Station2.Name}.");
                continue;
            }
            
            if (connections[i].LineName.Equals(connections[i-1].LineName))
            {
                stringBuilder.AppendLine($"Continue past {connections[i].Station1.Name}...");
            }
            else
            {
                stringBuilder.AppendLine($"When you get to {connections[i].Station1.Name} get off the {connections[i-1].LineName}.");
                stringBuilder.AppendLine($"Switch over to the {connections[i].LineName}, heading towards {connections[i].Station2.Name}.");
            }
            
            if (i == connections.Count - 1)
            {
                stringBuilder.AppendLine($"Get off at {connections[i].Station2.Name} and enjoy yourself!");
            }
        }
        Assert.Equal(stringBuilder.ToString(), output);
    }

    //     for (var i = 0 ; i < connections.Count;++i)
    //     {
    //         if (i == 0)
    //         {
    //             stringBuilder.AppendLine($"Start out at {connections[i].Station1.Name}.");
    //             stringBuilder.AppendLine($"Get on the {connections[i].LineName} heading towards {connections[i].Station2.Name}.");
    //             continue;
    //         }
    //
    //         if (i > 0 && i < connections.Count - 1)
    //         {
    //             stringBuilder.AppendLine($"Continue past {connections[i].Station1.Name}...");
    //             
    //         }
    //         else
    //         {
    //             stringBuilder.AppendLine($"When you get to {connections[i].Station2.Name} get off the {connections[i].LineName}.");
    //             stringBuilder.AppendLine($"Switch over to the {connections[i].LineName}, heading towards {connections[i].Station2.Name}.");
    //         }
    //         
    //         if (i == connections.Count - 1)
    //         {
    //             stringBuilder.AppendLine($"Get off at {connections[i].Station2.Name} and enjoy yourself!");
    //         }
    //         
    //     }
    //     Assert.Equal(stringBuilder.ToString(), output);
    // }
}