using System.Transactions;

namespace Appendix2;

public abstract class Inheritance
{
    public class Jet : Airplane
    {
        private const int Multiplier = 2;
        private int speed;
        public int Speed
        {
            get => speed;
            set => speed = value * Multiplier;
        }

        public void Accelerate()
        {
            Speed *= 2;
        }
    }
}

//     public class Jet : Airplane
//     {
//         private const int MULTIPLIER = 2;
//
//         public void SetSpeed(int speed)
//         {
//             base.SetSpeed(speed * MULTIPLIER);
//         }
//
//         public void Accelerate()
//         {
//             base.SetSpeed(GetSpeed() * 2);
//         }
//     }
// }
    