using Chapter6;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace UnitTester;
using Xunit;

public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Theory]
    [InlineData("infantry", "infantry")]
    [InlineData("cavalry", "cavalry")]
    [InlineData("archer", "archer")]
    public void TestType(string type, string expectedOutputType)
    {
        var unit = new Unit(1000);
        unit.Type = type;
        var outputType = unit.Type;

        Assert.Equal(expectedOutputType, outputType);
    }

    [Theory]
    [InlineData("hitPoints", 25)]
    [InlineData("strength", 50)]
    public void TestUnitSpecificProperty(string propertyName, object inputValue)
    {
        var unit = new Unit(1000);
        unit.SetProperty(propertyName, inputValue);
        var outputValue = unit.GetProperty(propertyName);

        Assert.Equal(inputValue, outputValue);
    }

    [Theory]
    [InlineData("strength")]
    [InlineData("speed")]
    public void TestNonExistentProperty(string propertyName)
    {
        var unit = new Unit(1000);

        object? outputValue;
        try
        {
            outputValue = unit.GetProperty(propertyName);
        }
        catch (NullException testPassed)
        {
            _testOutputHelper.WriteLine(testPassed.ToString());
            throw;
        }
        
        Assert.Null(outputValue);
    }
    
    
}