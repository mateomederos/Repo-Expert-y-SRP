using System;
using System.Collections.Generic;

namespace SRP
{
    public class LibraryShelve
    {
        private static int shelveCount = 0;
        private int bookCount;
        private List<object> bookObjects;

        public LibraryShelve()
        {
            LibraryShelve.shelveCount++;
            this.bookCount = 0;
            this.bookObjects = new List<object>();
    
        }
        public void SaveBook(object book)
        {
            bookObjects.Add(book);
            this.bookCount++;
            Console.WriteLine("The book has been saved properly");
        }

        public List<object> GetBookObjects()
        {
            return this.bookObjects;
        }

        // static methods.
        public static int GetShelveCount()
        {
            return LibraryShelve.shelveCount;
        }

    }
}
