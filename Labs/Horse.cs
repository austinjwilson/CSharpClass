using System;

namespace CSharpClass.Labs
{
    public class Horse
    {
        int _hooves;
        string _tail;    
        //string _softHair;
        //string _largeBody;

        public Horse()
            : this(4, "soft")
            { }
        
        public Horse(int hooves, string tail)
            : this(hooves, tail,"fluffy", "big" )
            {

            }

        public Horse(int hooves, string tail, string softHair,
        string largeBody)
        {
            this._hooves = hooves;
            this._tail = tail;
            SoftHair = softHair;
            LargeBody = largeBody;
        }
        
        public int Hooves { get; set; }

        public string Tail { get; set; }

        public string SoftHair { get; set; }

        public string LargeBody { get; private set; }

        public virtual void Racing()
        {
            Console.WriteLine("The horse is racing");
        } // end method racing

        public void Wrangling(string largeBody)
        {

        }
    } // end class
} // end namespace