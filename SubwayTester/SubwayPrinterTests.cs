using Chapter10;
using System;
using System.Collections.Generic;
using System.Text;
using AutoFixture.Xunit2;
using Xunit;

namespace SubwayTester;

public class SubwayPrinterTests
{
    [Theory]
    [AutoData]
    public void PrintDirections_PrintsDirectionsCorrectly(List<Connection>connections)
    {
        var outputStream = new MemoryStream();
        var subwayPrinter = new SubwayPrinter(outputStream);
        
        subwayPrinter.PrintDirections(connections);

        outputStream.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(outputStream);
        
        for (var i = 0 ; i< connections.Count;++i)
        {
            var stringBuilder = new StringBuilder();
            
            if (i == 0)
            {
                stringBuilder.Append($"Start out at {connections[i].Station1.Name}");
                stringBuilder.Append($"Get on the {connections[i].LineName} heading towards {connections[i].Station2.Name}.");
                continue;
            }

            if (i == connections.Count - 1)
            {
                stringBuilder.Append($"Get off at {connections[i].Station2.Name} and enjoy yourself!");
            }
            else
            {
                stringBuilder.Append($"Switch over to the {connections[i].LineName}, heading towards {connections[i].Station2.Name}.");
            }

            if (i > 0 && i < connections.Count - 1)
            {
                stringBuilder.Append($"Continue past {connections[i].Station1.Name}...");
                stringBuilder.Append($"When you get to {connections[i].Station2.Name}, get off the {connections[i].LineName}.");
            }
        }
    }
}