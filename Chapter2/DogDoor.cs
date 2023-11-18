namespace Chapter2;

public class DogDoor
{
    private bool _isOpen;

    public void Open()
    {
        Console.WriteLine("The dog door opens.");
        _isOpen = true;
    }

    public void Close()
    {
        Console.WriteLine("The dog door closes.");
        _isOpen = false;
    }

    public bool IsOpen()
    {
        return _isOpen;
    }
}