using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public string doctorName {get;}
        public string areaOfSpecialization {get;}
        public Doctor(string doctorName, string areaOfSpecialization)
        {
            this.doctorName = doctorName;
            this.areaOfSpecialization = areaOfSpecialization;
        }

    }
}
