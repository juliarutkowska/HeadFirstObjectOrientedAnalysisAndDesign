namespace Chapter2;

using System;

public class Remote
{
    private readonly DogDoor _door;

    public Remote(DogDoor door)
    {
        _door = door;
    }

    public void PressButton()
    {
        Console.WriteLine("Pressing the remote control button...");
        if (_door.IsOpen)
        {
            _door.Close();
        }
        else
        {
            _door.Open();
            // Simulate the door closing automatically after 5 seconds
            Thread.Sleep(5000);
            _door.Close();
        }
    }
}


//
// import java.util.Timer
// import java.util.TimerTask
// public class Remote
// {
//     private DogDoor door;
//
//     public Remote(DogDoor door)
//     {
//         this.door = door;
//     }
//
//     public void PressButton()
//     {
//         Console.WriteLine("Pressing the remote control button...");
//         if (door.IsOpen())
//         {
//             door.Close();
//         }
//         else
//         {
//             door.Open();
//         }
//     }
//     
//     final Timer timer = new Timer();
//     timer.schedule(new TimerTask()
//     {
//         public void run()
//         {
//             door.Close();
//             timer.cancel();
//         }
//     }, 5000);
// }