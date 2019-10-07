using System;

namespace CSharpClass.Labs
{
    public class Pony : Horse
    {
        string _teeth;
        string _wiryHair;

        public void ExportGoods()
        {
            
        }

        public override void Racing()
        {
            Console.WriteLine("This pony is not racing");
        }
    } // end class
} // end namespace