using System;

/* This class is a child class of House
Lesson 12 Inheritance */
namespace CSharpClass.Lessons
{
    public class Condo : House
    {
        //string _balcony;

        public Condo()
            : this("metal") {} 

        public Condo(string balcony)
            : base(32, "concrete")
        {
            Balcony = balcony;
        }


        public string Balcony { get; set; }

        public void Maintenance() { base.DoorOpenClose(); } 

        public override void DoorOpenClose() 
        {   
            base.DoorOpenClose();
            Console.WriteLine("This condo door is closed");
        }
        
    }
}