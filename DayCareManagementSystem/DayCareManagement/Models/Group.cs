﻿using System;
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
        public Teacher teacher = null;
        public EnrollmentRules EnrollmentRule = null;
        public int ClassID { get; set; }

        public Teacher getTeacher()
        {
            return teacher;
        }
        public void setTeacher(Teacher teacher)
        {
            this.teacher = teacher;
        }
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
        public List<Student> getStudentList()
        {
            return this.StudentList;
        }
        public EnrollmentRules getEnrollmentRule()
        {
            return EnrollmentRule;
        }

        public void setEnrollmentRule(EnrollmentRules enrollmentRule)
        {
            this.EnrollmentRule = enrollmentRule;
        }

        public void setStudentList(List<Student> studentList)
        {
            this.StudentList = studentList;
        }
        public override string ToString()
        {
            return $"Group {GroupID} | EnrollmentRule {EnrollmentRule}";
        }

       
    }

}
