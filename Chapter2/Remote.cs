namespace Chapter2;

using System;
using System.Timers;
public class Remote
{
    private DogDoor door;
    private Timer timer;

    public Remote(DogDoor door)
    {
        this.door = door;

        // Initialize the timer
        timer = new Timer(5000);
        timer.Elapsed += TimerElapsed;
    }

    public void PressButton()
    {
        Console.WriteLine("Pressing the remote control button...");
        if (door.IsOpen())
        {
            door.Close();
        }
        else
        {
            door.Open();
        }
        timer.Start();
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
        door.Close();
        timer.Stop();
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