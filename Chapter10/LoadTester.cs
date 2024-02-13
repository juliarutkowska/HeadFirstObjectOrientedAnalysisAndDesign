namespace Chapter10;

public class LoadTester
{
    public static void Main(String[] args)
    {
        try
        {
            var loader = new SubwayLoader();
            var objectville = loader.LoadFromFile(new FileInfo("ObjectvilleSubway.txt"));

            Console.WriteLine("Testing stations");
            if (objectville.HasStation("DRY Drive") &&
                objectville.HasStation("Weather-O-Rama, Inc.") &&
                objectville.HasStation("Boards 'R' Us"))
            {
                Console.WriteLine("... station test passed successfully.");
            }
            else
            {
                Console.WriteLine("...station test FAILED.");
                Environment.Exit(-1);
            }

            Console.WriteLine("\nTesting connections...");
            if (objectville.HasConnection("DRY Drive", "Head First Theater", "Meyer Line") &&
                objectville.HasConnection("LSP Lane", "JavaBeans Boulevard", "Booch Line") &&
                objectville.HasConnection("OOA&D Oval", "Head First Labs", "Gamma Line"))
            {
                Console.WriteLine("...connections test passed successfully.");
            }
            else
            {
                Console.WriteLine("...connections test FAILED");
                Environment.Exit(-1);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}