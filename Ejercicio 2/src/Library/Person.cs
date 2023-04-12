using System;
using System.Text;

namespace Library
{
    public class Person
    {
        public string personName {get;}
        public int personAge {get;}
        public string phoneNumber {get;}
        public Person(string personName, int personAge, string phoneNumber)
        {
            this.personName = personName;
            this.personAge = personAge;
            this.phoneNumber = phoneNumber;
        }

    }
}
