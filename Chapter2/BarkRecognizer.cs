namespace Chapter2;

public class BarkRecognizer
{
    private readonly DogDoor _door;
    
    public BarkRecognizer(DogDoor door)
    {
        _door = door;
    }

    public void Recognize(Bark bark)
    {
        Console.WriteLine($"    BarkRecognizer: heard a '{bark.Sound}'");
        if (_door.AllowedBark().Equals(bark.Sound, StringComparison.OrdinalIgnoreCase))
        {
            _door.Open();
        }
        else
        {
            Console.WriteLine("This dog is not allowed.");
        }
    }
}
    // public void Recognize(string bark)
    // {
    //     Console.WriteLine($"    BarkRecognizer: heard a '{bark}'");
    //     _door.Open();
    // }
