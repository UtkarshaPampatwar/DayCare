using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Student:Person
    {
        public int StudentId { get; set; }
        public String FatherName { get; set; }
        public String MotherName { get; set; }
        public List<Immunization> ImmunizationRecord { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int GroupID { get; set; }
        public int ClassID { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

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

        public void showStudentDetails()
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
