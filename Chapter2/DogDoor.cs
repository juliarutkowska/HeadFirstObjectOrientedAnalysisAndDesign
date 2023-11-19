namespace Chapter2;

using System;
using System.Threading;

public class DogDoor
{
    public bool IsOpen { get; private set; }

    public void Open()
    {
        Console.WriteLine("The dog door opens.");
        IsOpen = true;
    }

    public void Close()
    {
        Console.WriteLine("The dog door closes.");
        IsOpen = false;
    }
}



// namespace Chapter2
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