using System;
using MySql.Data.MySqlClient; // Import MySQL library
using PhysioDynamik_Prototype_1;
namespace PhysioDynamik_Prototype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the system and patients
            SystemClass system = new SystemClass();
            Patient patient = new Patient
            {
                Name = "John Doe",
                PatientID = 1,
                Email = "john.doe@example.com",
                PhoneNumber = "123-456-7890",
                DateOfBirth = new DateTime(1990, 1, 1)
            };

            Console.WriteLine("---- Display Available Slots ----");
            // Display available slots
            system.DisplayAvailableSlots();

            Console.WriteLine("\n---- Booking an Appointment ----");
            // Patient books an appointment
            patient.SelectAppointment(system, "10:00 AM", 101); // Assuming TherapistID = 101

            Console.WriteLine("\n---- View All Appointments ----");
            // Retrieve and display all appointments
            system.GetAppointments();

            Console.WriteLine("\n---- Cancel an Appointment ----");
            // Cancel the first appointment
            if (patient.AppointmentList.Count > 0)
            {
                Appointment appointmentToCancel = patient.AppointmentList[0];
                appointmentToCancel.CancelAppointment();
            }

            Console.WriteLine("\n---- View Updated Appointment Status ----");
            // View updated status
            if (patient.AppointmentList.Count > 0)
            {
                patient.AppointmentList[0].ViewStatus();
            }

            Console.WriteLine("\n---- Display Updated Available Slots ----");
            // Display available slots after cancellation
            system.DisplayAvailableSlots();
        }
    }
}