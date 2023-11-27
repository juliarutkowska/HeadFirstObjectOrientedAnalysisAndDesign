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
        if (_door.GetAllowedBarks().Contains(bark.Type))
        {
            Console.WriteLine($"BarkRecognizer heard a '{bark.Type}'.");
            _door.Open();
        }
        else
        {
            Console.WriteLine($"BarkRecognizer didn't recognize the {bark.Type}. This dog is not allowed.");
        }
    }
//     private readonly DogDoor _door;
//     
//     public BarkRecognizer(DogDoor door)
//     {
//         _door = door;
//     }
//
//     public void Recognize(Bark bark)
//     {
//         Console.WriteLine($"BarkRecognizer heard a '{bark}'.");
//         var allowedBarks = _door.AllowedBark();
//
//         if (!Enumerable.Contains(allowedBarks, bark)) return;
//         _door.Open();
//     }

    // public void Recognize(Bark bark)
    // {
    //     Console.WriteLine($"    BarkRecognizer: heard a '{bark.Sound}'");
    //     if (_door.AllowedBark().Equals(bark.Sound, StringComparison.OrdinalIgnoreCase))
    //     {
    //         _door.Open();
    //     }
    //     else
    //     {
    //         Console.WriteLine("This dog is not allowed.");
    //     }
    // }
}
    // public void Recognize(string bark)
    // {
    //     Console.WriteLine($"    BarkRecognizer: heard a '{bark}'");
    //     _door.Open();
    // }
