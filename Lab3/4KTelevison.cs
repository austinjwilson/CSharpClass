using System;

namespace CSharpClass.Lab3
{
    public class FourKTelevison : Televison
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turn on with app");
        }
        public FourKTelevison(int size, decimal price, int ports, bool isMountable)
            :base (size, price, ports, isMountable)
        {

        }
        public FourKTelevison(int size, decimal price)
            :this(size, price, 2, false)
        {

        }
    }
}