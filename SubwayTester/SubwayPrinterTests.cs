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
        // var route = new List<Connection>();
        // {
        //     new Connection(new Station("Ajax Rapids"), new Station("HTML Heights"), "Booch Line" )
        //     {
        //         LineName = "Booch Line", Station1 = new Station("Ajax Rapids") { Name = "Station1" },
        //         Station2 = new Station("HTML Heights") { Name = "Station2" }
        //     },
        //     new Connection(new Station("OOA&D Oval"), new Station("Head First Lounge"), "Gamma Line")
        //     {
        //         LineName = "Gamma Line", Station1 = new Station("OOA&D Oval") { Name = "Station2" },
        //         Station2 = new Station("Head First Lounge") { Name = "Station3" }
        //     }
        // };
        
        subwayPrinter.PrintDirections(connections);

        outputStream.Seek(0, SeekOrigin.Begin);
        using var reader = new StreamReader(outputStream);
        var output = reader.ReadToEnd();
        Assert.Contains("Start out at ", output);
        // Assert.Contains("Get on the Line1 heading towards Station2.", output);
        // Assert.Contains("Continue past  Station2...", output);
        // Assert.Contains("When you get to Station2, get off the Line1.", output);
        // Assert.Contains("Switch over to the Line2, heading towards Station3.", output);
        // Assert.Contains("Get off at Station3 and enjoy yourself!", output);
    }
}