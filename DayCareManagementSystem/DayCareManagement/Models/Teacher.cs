using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Teacher:Person
    {
        public int TeacherId { get; set; }
        public int GroupID { get; set; }
        public int ClassID { get; set; }
        public Boolean IsAvailable { get; set; }
        public String Address { get; set; }
        public int Credit { get; set; }

        public String PhoneNumber { get; set; }
        public Teacher()
        {

        }

        public Teacher(string FirstName, string LastName, int TeacherId, Boolean isAvailable, String address, String phoneNumber)
        {
            this.TeacherId = TeacherId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsAvailable = isAvailable;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            //this.Credit = credit;
        }
    }
}
