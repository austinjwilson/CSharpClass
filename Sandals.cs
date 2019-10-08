using System;


namespace CSharpClass
{
    public class Sandals : Shoes
    {
        //string _straps;
    
        public Sandals()
            : this("leather") {}

        public Sandals(string straps)
        {
            Straps = straps;
        }

        public string Straps { get; set; }

        public void Protects()
        {

        } // end method protects

        public override void ShoesWorn()
        {
            Console.WriteLine("These sandals are worn");
        } // end method worn

    } // end method Sandals
} // end class