using System;

namespace CSharpClass.Labs
{
    public class Horse
    {
        int _hooves;
        string _tail;    
        string _softHair;
        string _largeBody;

        public virtual void Racing()
        {
            Console.WriteLine("The horse is racing");
        } // end method racing

        public void Wrangling(string largeBody)
        {

        }
    } // end class
} // end namespace