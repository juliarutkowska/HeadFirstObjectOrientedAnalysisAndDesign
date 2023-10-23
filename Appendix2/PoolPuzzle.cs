namespace Appendix2;

public abstract class FlyTest
{
    public static void Main(string[] args)
    {
        var biplane = new Airplane();
        biplane.Speed = 212;
        Console.WriteLine(biplane.Speed);
        
        var boeing = new Inheritance.Jet();
        boeing.Speed = 422;
        Console.WriteLine(boeing.Speed);
        
        var x = 0;
        while (x < 4)
        {
            boeing.Accelerate();
            Console.WriteLine(boeing.Speed);
            
            if (boeing.Speed > 5000)
            {
                biplane.Speed *= 2;
            }
            else
            {
                boeing.Accelerate();
            }
            x++;
        }
        
        Console.WriteLine(biplane.Speed);
    }
}

// public class FlyTest
// {
//     public static void Main(string[] args)
//     {
//         Airplane biplane = new Airplane();
//         biplane.SetSpeed(212);
//         Console.WriteLine(biplane.GetSpeed());
//         
//         Inheritance.Jet boeing = new Inheritance.Jet();
//         boeing.SetSpeed(422);
//         Console.WriteLine(boeing.GetSpeed());
//         
//         int x = 0;
//         while (x < 4)
//         {
//             boeing.Accelerate();
//             Console.WriteLine(boeing.GetSpeed());
//             
//             if (boeing.GetSpeed() > 5000)
//             {
//                 biplane.SetSpeed(biplane.GetSpeed() * 2);
//             }
//             else
//             {
//                 boeing.Accelerate();
//             }
//             x++;
//         }
//         Console.WriteLine(biplane.GetSpeed());
//     }
// }
