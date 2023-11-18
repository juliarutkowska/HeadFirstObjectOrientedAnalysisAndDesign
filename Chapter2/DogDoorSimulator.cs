namespace Chapter2;

public class DogDoorSimulator
{
    public static void Main(string[] args)
    {
        var door = new DogDoor();
        BarkRecognizer recognizer = new BarkRecognizer(door);
        var remote = new Remote(door);
        
        //simulate the hardware hearing a bark
        Console.WriteLine("Fido barks to go outside...");
        recognizer.Recognize("Woof");
        Console.WriteLine();
        
        Console.WriteLine("Fido has gone outside...");
        Console.WriteLine();

        Console.WriteLine("Fido's all done...");
        Console.WriteLine();

        try
        {
            Thread.Sleep(10000);
        }
        catch (ThreadInterruptedException e)
        {
        }
        
        Console.WriteLine("...but he's stuck outside!");
        
        //simulate the hardware hearing a bark
        Console.WriteLine("\n Fido starts barking...");
        recognizer.Recognize("\n Woof");
        
        Console.WriteLine("Fido's back inside...");
        Console.WriteLine();
    }
}