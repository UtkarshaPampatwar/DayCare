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
        public List<Immunization> ImmunizationRecord;
        public DateTime DateOfJoining { get; set; }
        public int GroupID { get; set; }
        public int ClassID { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Student()
        {

        }
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
        public List<Immunization> getImmunizationRecord()
        {
            return ImmunizationRecord;
        }
        public void setImmunizationRecord(List<Immunization> immunizationRecord)
        {
            this.ImmunizationRecord = immunizationRecord;
        }
        public String getPhoneNumber()
        {
            return PhoneNumber;
        }
        public void setPhoneNumber(String phoneNumber)
        {
            this.PhoneNumber = phoneNumber;
        }
        public DateTime getDateOfJoining()
        {
            return DateOfJoining;
        }
        public void setDateOfJoining(DateTime dateOfJoining)
        {
            this.DateOfJoining = dateOfJoining;
        }
        public int getGroupID()
        {
            return GroupID;
        }
        public void setGroupID(int groupID)
        {
            this.GroupID = groupID;
        }
        public int getClassID()
        {
            return ClassID;
        }
        public void setClassID(int classID)
        {
            this.ClassID = classID;
        }
        public int getAge()
        {
            return Age;
        }
        public void setAge(int age)
        {
            this.Age = age;
        }

        public String getAddress()
        {
            return Address;
        }
        public void setAddress(String address)
        {
            this.Address = address;
        }
        public DateTime getDateOfBirth()
        {
            return DateOfBirth;
        }
        public void setDateOfBirth(DateTime dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
        }
    }
}
