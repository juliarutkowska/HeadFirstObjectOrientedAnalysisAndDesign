namespace Chapter2;

public class DogDoorSimulator
{
    public static void Main(string[] args)
    {
        var door = new DogDoor();
        var recognizer = new BarkRecognizer(door);

        Console.WriteLine("Fido barks to go outside...");
        recognizer.Recognize("Woof");
        Console.WriteLine("Fido has gone outside...");
        door.Close(); // Close the door when Fido is outside

        Console.WriteLine("Fido's all done...");
            
        // Simulate Fido being stuck outside and then coming back after 10 seconds
        Console.WriteLine("...but he's stuck outside!");
        Console.WriteLine("Fido starts barking...");
        recognizer.Recognize("Woof");
        Console.WriteLine("Fido's back inside...");
        door.Close(); // Close the door when Fido is back inside
    }
}