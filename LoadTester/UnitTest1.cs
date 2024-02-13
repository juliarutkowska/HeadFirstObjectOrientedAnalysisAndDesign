using Chapter10;

namespace LoadTester
{
    using System.IO;
    using Xunit;


    namespace YourNamespace.Tests
    {
        public class SubwayLoaderTests
        {
            [Fact]
            public void TestStations()
            {
                var loader = new SubwayLoader();
                var objectville = loader.LoadFromFile(new FileInfo("ObjectvilleSubway.txt"));

                Assert.True(objectville.HasStation("DRY Drive"));
                Assert.True(objectville.HasStation("Weather-O-Rama, Inc."));
                Assert.True(objectville.HasStation("Boards 'R' Us"));
            }

            [Fact]
            public void TestConnections()
            {
                var loader = new SubwayLoader();
                var objectville = loader.LoadFromFile(new FileInfo("ObjectvilleSubway.txt"));

                Assert.True(objectville.HasConnection("DRY Drive", "Head First Theater", "Meyer Line"));
                Assert.True(objectville.HasConnection("LSP Lane", "JavaBeans Boulevard", "Booch Line"));
                Assert.True(objectville.HasConnection("OOA&D Oval", "Head First Labs", "Gamma Line"));
            }
        }
    }
}