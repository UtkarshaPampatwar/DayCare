using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Teacher:Person
    {
        private int TeacherId { get; set; }
        private int GroupID { get; set; }
        private int ClassID { get; set; }
        private Boolean IsAvailable { get; set; }
        private String Address { get; set; }
        private int Credit { get; set; }

        private String PhoneNumber { get; set; }
        public Teacher()
        {

        }

        public Teacher(string FirstName, string LastName, int TeacherId, Boolean isAvailable, String address, String phoneNumber, int credit)
        {
            this.TeacherId = TeacherId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.IsAvailable = isAvailable;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Credit = credit;
        }
    }
}
