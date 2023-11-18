namespace Chapter2;

public class BarkRecognizer
{
    private readonly DogDoor _door;

    public BarkRecognizer(DogDoor door)
    {
        _door = door;
    }

    public void Recognize(string bark)
    {
        Console.WriteLine($"    BarkRecognizer: heard a'{bark}'");
        _door.Open();
    }
}