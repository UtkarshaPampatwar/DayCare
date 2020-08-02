using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Group
    {
        public int GroupID { get; set; }
        public List<Student> StudentList = new List<Student>();
        public Teacher teacher { get; set; } = null;
        public EnrollmentRules EnrollmentRule { get; set; } = null;
        public int ClassID { get; set; }

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
