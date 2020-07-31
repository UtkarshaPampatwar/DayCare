using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Group
    {
        private int GroupID { get; set; }
        private List<Student> StudentList = new List<Student>();
        private Teacher teacher { get; set; } = null;   
        private EnrollmentRules EnrollmentRule { get; set; } = null;
        private int ClassID { get; set; }

        public Group(int GroupId, EnrollmentRules EnrollmentRule)
        {
            this.GroupID = GroupId;
            this.EnrollmentRule = EnrollmentRule;
        }
        public void AddStudent(Student s)
        {
            this.StudentList.Add(s);
        }

        public int getGroupSize()
        {
            return this.StudentList.Count();
        }

        public void showGroupDetails()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Group {GroupID} | EnrollmentRule {EnrollmentRule}";
        }

        
    }

}
