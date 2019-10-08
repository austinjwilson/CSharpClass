using System;

/* This is lab for Lesson 12 */
namespace CSharpClass
{
    public class Shoes
    {
        //int  _eyelets;
        //string _laces;
        //string _soles;

        public int Eyelets { get; set; }

        public string Laces { get; set; }

        public string Soles { get; private set; }

        public virtual void ShoesWorn()
        {
            Console.WriteLine("These shoes are worn");
        } // end method worn

        public void Worn(int laces)
        {
            
        } // end method worn

    } // end method shoes
} // end class