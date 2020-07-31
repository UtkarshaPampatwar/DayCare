using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Student:Person
    {
        private int StudentId { get; set; }
        private String FatherName { get; set; }
        private String MotherName { get; set; }
        private List<Immunization> ImmunizationRecord { get; set; }
        private DateTime DateOfJoining { get; set; }
        private int GroupID { get; set; }
        private int ClassID { get; set; }
        private String Address { get; set; }
        private String PhoneNumber { get; set; }
        private DateTime DateOfBirth { get; set; }

        public Student(String firstName, String lastName, int age, String address, String fatherName, String motherName, String phoneNumber, DateTime dateOfJoining, int studentID, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FatherName = fatherName;
            this.MotherName = motherName;
            this.DateOfJoining = dateOfJoining;
            this.Age = age;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.StudentId = studentID;
            this.DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"StudentId {StudentId} | FatherName {FatherName}";
        }

        public void showDetails()
        {
            Console.WriteLine(this.ToString());
        }
        /*private double grade { get; }
        private double gpa { get; set; }

        public Student()
        {

        }

        public Student(int Id, string FirstName, string LastName, int Age, double grade,double gpa)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.grade = grade;
            this.gpa = gpa;
        }*/
    }
}
