using System;

namespace CSharpClass.Lab3
{
    public class HDTelevison : Televison
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turn on with remote");
        }
        public HDTelevison(int size, decimal price, int ports, bool isMountable)
            :base (size, price, ports, isMountable)
        {

        }
        public HDTelevison(int size, decimal price)
            :this(size, price, 4, false)
        {

        }
    }
}