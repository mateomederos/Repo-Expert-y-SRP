using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");

            LibraryShelve d1 = new LibraryShelve();
            LibraryShelve d2 = new LibraryShelve();
            LibrarySector sec1 = new LibrarySector();

            sec1.AddShelve(d1);
            sec1.AddShelve(d2);
            foreach (object shelve in sec1.GetShelveObjects())
            {   
                Console.WriteLine($"{shelve}");
            }

        }
    }
}