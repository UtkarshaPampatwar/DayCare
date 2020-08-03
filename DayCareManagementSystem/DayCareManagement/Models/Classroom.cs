using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Classroom
    {
        public int capcity { get; set; }

        //public List<Teacher> teachers = new List<Teacher>();

        //public List<Student> students = new List<Student>();
        public List<Group> groupList = new List<Group>();
        public int classroomID;
        public EnrollmentRules enrollmentRule;
        public Classroom(int classroomID, EnrollmentRules enrollmentRule)
        {
            this.classroomID = classroomID;
            this.enrollmentRule = enrollmentRule;
        }
        public int getNumOfGroups()
        {
            return this.groupList.Count;
        }

        public void showClassDetails()
        {
            Console.WriteLine(this.ToString());
        }
        public void addGroupObj(Group group)
        {
            this.groupList.Add(group);
        }

        public List<Group> getGroupList()
        {
            return this.groupList;
        }

        public void setGroupList(List<Group> groupList)
        {
            this.groupList = groupList;
        }
        public int getClassroomID()
        {
            return classroomID;
        }

        public void setClassroomID(int classroomID)
        {
            this.classroomID = classroomID;
        }
    }
    
}
