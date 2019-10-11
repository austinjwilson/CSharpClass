using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* This class goes over Lesson 16 content
Collection & LINQ */
namespace CSharpClass.Lessons
{
    public class Lesson16
    {
        public void MyArrayListExample()
        {
            ArrayList myList = new ArrayList();
            myList.Add("Hello");
            myList.Add(42);
            myList.Add(true);
            myList.Add('T');
            PrintValues(myList);
        
        }

        private void PrintValues(IEnumerable myListing)
        {
            foreach (Object item in myListing)
            {
                Console.WriteLine("Values : {0}", item);
            }
        }

        public void MyHashtableExample()
        {
            Hashtable myHash = new Hashtable();
            myHash.Add(10, "CSharp");
            myHash.Add(20, 24);
            myHash.Add(30, "Rocks");
            myHash.Add(40, 'J'); 

            foreach (DictionaryEntry item in myHash)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                item.Key, item.Value);
            }
        }

        public void MyListExample()
        {
            List<string> myList = new List<string>();
            myList.Add("Alpha");    
            myList.Add("Bravo");
            myList.Add("Charlie");
            myList.Add("Delta");
            myList.Add("Echo");
            myList.Add("Foxtrot");

            foreach (string item in myList)
            {
                Console.WriteLine(item);
            }
        }

        public void MyOtherList()
        {
            List<House> myHouseList = new List<House>();
            myHouseList.Add(new House(24, "concrete"));
            myHouseList.Add(new House());
            myHouseList.Add(new House(36, "brick", "shingle", "red"));

            foreach (House item in myHouseList)
            {
                Console.WriteLine(item.DoorColor + " , "+ item.RoofType);
            }
        }

        public void MyDictionaryExample()
        {
            Dictionary<int, string> myList = new Dictionary<int, string>();
            myList.Add(10, "CSharp");
            myList.Add(20, "Rocks");
            myList.Add(30, "Happy");
            myList.Add(40, "Friday");

            // to get a single value we use the TryGetValue mehtod 
            string temp = " ";
            if(myList.TryGetValue(20, out temp)) 
            {
                Console.WriteLine("Key 20 is {0}", temp);
            } 
            foreach (KeyValuePair<int, string> item in myList)
            {
                Console.WriteLine("Key: {0}, Value: {1}", 
                item.Key, item.Value);
            }
        
        }

        public void MyLinqExample()
        {
            int[] scores = new int[] {97,92,88,60,55,40,20};

            IEnumerable<int> query = from score in scores
            where score < 85
            select score;

            foreach (int item in query)
            {
                Console.WriteLine(item);
            }
        }


        public void MyOtherLinq()
        {
            List<House> myHouseList = new List<House>();
            myHouseList.Add(new House(23, "concrete"));
            myHouseList.Add(new House(24, "steel","plastic", "red"));
            myHouseList.Add(new House());
            myHouseList.Add(new House(32, "wood", "wood", "blue"));

            var subset = from theHouse in myHouseList
            where theHouse.RoofType == "shingle"
            orderby theHouse.DoorColor
            select theHouse;

            foreach (House item in subset)
            {
                Console.WriteLine("My house has a {0} roof", item.RoofType);
            }
        }
    }
}