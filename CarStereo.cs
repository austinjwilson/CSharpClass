using System;

namespace CSharpClass
{
    public class CarStereo : Radio
    {
        string _bluetooth;
        string _sateliteradio;

        public void mp3Capability()
        {

        }

        public override void PlaysMusic()
        {
            Console.WriteLine("Car Stereo plays music");
        } 
    }
}