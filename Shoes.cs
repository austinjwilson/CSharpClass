using System;

/* This is lab for Lesson 12 */
namespace CSharpClass
{
    public class Shoes
    {
        int _laces;
        string _eyelets;
        string _soles;
         
        public virtual void ShoesWorn()
        {
            Console.WriteLine("These shoes are worn");
        } // end method worn

        public void Worn(int laces)
        {
            
        } // end method worn

    } // end method shoes
} // end class