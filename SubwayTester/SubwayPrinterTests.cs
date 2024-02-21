using Chapter10;
using System;
using System.Collections.Generic;
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
        var output = reader.ReadToEnd();
        
        for (var i = 0 ; i< connections.Count;++i)
        {
            if (i == 0)
            {
                Assert.Contains($"Start out at {connections[i].Station1.Name}", output);
                Assert.Contains($"Get on the {connections[i].LineName} heading towards {connections[i].Station2.Name}.", output);
                continue;
            }

            if (i == connections.Count - 1)
            {
                Assert.Contains($"Get off at {connections[i].Station2.Name} and enjoy yourself!", output);
            }
            else
            {
                Assert.Contains($"Switch over to the {connections[i].LineName}, heading towards {connections[i].Station2.Name}.", output);
            }

            if (i > 0 && i < connections.Count - 1)
            {
                Assert.Contains($"Continue past {connections[i - 1].Station2.Name}...", output);
                Assert.Contains($"When you get to {connections[i].Station2.Name}, get off the {connections[i].LineName}.", output);
            }
        }
    }
}