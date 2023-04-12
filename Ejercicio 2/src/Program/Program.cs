using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mateo", 19, "099403021");
            Doctor doctor = new Doctor("Juan", "neurology");
            string appointmentResult = AppointmentService.CreateAppointment(person.personName, "986782342", person.phoneNumber, DateTime.Now, "Wall Street", doctor.doctorName);
            Console.WriteLine(appointmentResult);
        }
    }
}
