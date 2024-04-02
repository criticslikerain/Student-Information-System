using System;
using System.Speech.Synthesis;

namespace Student_Information_System
{
    class UserInformation
    {
        public static void DisplayUserInfo(Data user)
        {
            Console.WriteLine("\nUser Information");
            Console.WriteLine("Username: " + user.Username);
            Console.WriteLine("Name: " + user.Name);
            Console.WriteLine("Surname: " + user.Surname);
            Console.WriteLine("Birthdate: " + user.Birthdate);
            Console.WriteLine("Contact Number: " + user.ContactNum);
            Console.WriteLine("Emergency Contact: " + user.EmergencyContact);
            Console.WriteLine("Address: " + user.Address);
            Console.WriteLine("User ID: " + user.UserID);
            Console.WriteLine("Registration Date: " + user.RegistrationDate);
            Console.WriteLine("Gender: " + user.Gender);
            Console.WriteLine("Religion: " + user.Religion);
            Console.WriteLine("Nationality: " + user.Nationality);
            Console.WriteLine("Grade Year: " + user.GradeYear);
            Console.WriteLine("Enrollment Status: " + user.EnrollmentStatus);
        }
    }
}
