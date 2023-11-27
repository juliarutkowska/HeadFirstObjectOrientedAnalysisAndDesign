namespace Chapter2;

using System;
using System.Threading;

public class DogDoorSimulator
{
    public static void Main(string[] args)
    {
        DogDoor door = new DogDoor();
        door.AddAllowedBark(BarkType.Rowlf);
        door.AddAllowedBark(BarkType.Rooowlf);
        door.AddAllowedBark(BarkType.Rawlf);
        door.AddAllowedBark(BarkType.Woof);

        BarkRecognizer recognizer = new BarkRecognizer(door);

        // Simulate Bruce barking
        Console.WriteLine("Bruce starts barking.");
        recognizer.Recognize(new Bark(BarkType.Rowlf));

        Console.WriteLine("\nBruce has gone outside...");
        door.Close();
        
        Thread.Sleep(10000);

        Console.WriteLine("\nBruce all done...");
        Console.WriteLine("...but he's stuck outside!");

        // Simulate a small dog barking
        Console.WriteLine("A small dog starts barking.");
        recognizer.Recognize(new Bark(BarkType.Yip));

        Thread.Sleep(5000);

        // Simulate Bruce barking again
        Console.WriteLine("\nBruce starts barking.");
        recognizer.Recognize(new Bark(BarkType.Rooowlf));

        Console.WriteLine("\nBruce's back inside...");
        door.Close();
    }
}

// public class DogDoorSimulator
// {
//     public static void Main(string[] args)
//     {
//         var door = new DogDoor();
//         var recognizer = new BarkRecognizer(door);
//         
//         Console.WriteLine("Fido barks to go outside...");
//         recognizer.Recognize(new Bark("Woof"));
//         Console.WriteLine("Fido has gone outside...");
//         door.Close();
//
//         Console.WriteLine("Fido's all done...");
//             
//         // Simulate Fido being stuck outside and then coming back after 10 seconds
//         Console.WriteLine("...but he's stuck outside!");
//         Console.WriteLine("Fido starts barking...");
//         recognizer.Recognize(new Bark("Woof"));
//         Console.WriteLine("Fido's back inside...");
//         door.Close();
//     }
// }