using System;
using System.Collections.Generic;

namespace SRP
{
    public class LibrarySector
    {
        private static int sectorCount = 0;
        private int shelveCount;
        private List<object> shelveObjects;

        public LibrarySector()
        {
           this.shelveCount = 0;
           this.shelveObjects = new List<object>();
           LibrarySector.sectorCount++;
    
        }
        public void AddShelve(object shelve)
        {
            this.shelveObjects.Add(shelve);
            this.shelveCount++;
            Console.WriteLine("The shelve has been added properly");
        }

        public List<object> GetShelveObjects()
        {
            return this.shelveObjects;
        }

        // static methods.
        public static int GetSectorCount()
        {
            return LibrarySector.sectorCount;
        }

    }
}



