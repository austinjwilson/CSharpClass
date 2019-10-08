using System;

namespace CSharpClass.Labs
{
    public class Pony : Horse
    {
        string _teeth;
        string _wiryHair;

        public Pony()
            : this("big", "wiry")
            {}
        
        public Pony(string teeth, string wiryHair)
        {
            Teeth = teeth;
            WiryHair = wiryHair; 
        }
        
        public string Teeth
        {
            get { return _teeth; }
            set { _teeth = value; }
        } 

        public string WiryHair
        {
            get { return _wiryHair; }
            set { _wiryHair = value; }
        } 
        
        public void ExportGoods()
        {
            
        }

        public override void Racing()
        {
            Console.WriteLine("This pony is not racing");
        }
    } // end class
} // end namespace