using System;

namespace CSharpClass
{
    public class Radio
    {
        int _speakers;
        string _dials;
        string _antenna;
    
        public virtual void PlaysMusic()
        {
            Console.WriteLine("Radio Plays Music");
        } // end method radio plays music
    }
}