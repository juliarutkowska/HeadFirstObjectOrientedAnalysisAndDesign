namespace Chapter2;

using System;
using System.Threading;

public class DogDoor
{
    public bool IsOpen { get; private set; }

    private readonly List<BarkType> _allowedBarks = new List<BarkType>();

    public void AddAllowedBark(BarkType bark)
    {
        _allowedBarks.Add(bark);
    }

    public List<BarkType> GetAllowedBarks()
    {
        return _allowedBarks;
    }

    public void Close()
    {
        Console.WriteLine("The dog door closes.");
    }

    public void Open()
    {
        Console.WriteLine("The dog door opens.");
        IsOpen = true;
    }
}
//
    // private readonly List<Bark> _allowedBarks = new();    
    //
    // public IEnumerable<Bark> AllowedBark()
    // {
    //     return _allowedBarks;
    // }
    //
    // public void AddAllowedBark(Bark bark) {
    //     _allowedBarks.Add(bark);
    // }
    //
    
    //
    // public void Close()
    // {
    //     Console.WriteLine("The dog door closes.");
    //     IsOpen = false;
    // }

// namespace Chapter2-4
// {
//     public class DogDoor
//     {
//         private bool _isOpen;
//         private Timer timer;
//
//         public DogDoor()
//         {
//             _isOpen = false;
//             timer = new Timer(5000); // Set timer interval to 5000 milliseconds (5 seconds)
//             timer.Elapsed += TimerElapsed;
//         }
//
//         public void Open()
//         {
//             Console.WriteLine("The dog door opens.");
//             _isOpen = true;
//
//             // Start the timer when the door is opened
//             timer.Start();
//         }
//
//         public void Close()
//         {
//             Console.WriteLine("The dog door closes.");
//             _isOpen = false;
//
//             // Stop the timer when the door is closed
//             timer.Stop();
//         }
//
//         public bool IsOpen()
//         {
//             return _isOpen;
//         }
//
//         private void TimerElapsed(object sender, ElapsedEventArgs e)
//         {
//             Console.WriteLine("Timer elapsed! Closing the door...");
//             Close(); // Close the door when the timer elapses
//         }
//     }
// }