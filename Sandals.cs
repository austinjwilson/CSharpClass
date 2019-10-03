using System;


namespace CSharpClass
{
    public class Sandals : Shoes
    {
        string _straps;
    
        public void Protects()
        {

        } // end method protects

        public override void ShoesWorn()
        {
            Console.WriteLine("These sandals are worn");
        } // end method worn

    } // end method Sandals
} // end class