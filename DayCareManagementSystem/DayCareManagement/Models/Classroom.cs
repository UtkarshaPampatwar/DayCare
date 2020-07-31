using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Classroom
    {
        private int capcity { get; set; }

        private List<Teacher> teachers = new List<Teacher>();

        private List<Student> students = new List<Student>();
        private List<Group> groupList = new List<Group>();
        private int classroomID;
        private EnrollmentRules enrollmentRule;
    }
}
