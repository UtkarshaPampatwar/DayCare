using DayCareManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using DayCareManagement.Models;
using DayCareManagement.Factory;

namespace DayCareManagement.Controllers
{
	public class DayCareController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
		private static String studentFileName = "student.csv";
		private static String teacherFileName = "teacher.csv";
		private static String demoFileName = "demo.csv";
		private static String enrollmentRulesFileName = "enrollmentRules.csv";
		private static readonly String immunizationFileName = "Student_Immunization_Record.csv";
		
		
		private Models.DayCare dayCareObj = null;
		
		public static Dictionary<String, ImmunizationRules> immunizationRules = new Dictionary<String, ImmunizationRules>();
		private static DateTime dateFormat = new DateTime(2020,07,31);

		private DayCareFactory dayCarefactoryObj = null;
		private EnrollmentRulesFactory enrollmentFactoryObj = null;
		private StudentFactory studentFactoryObj = null;
		private TeacherFactory teacherFactoryObj = null;

		public static String getEnrollmentrulesfilename()
		{
			return enrollmentRulesFileName;
		}
		
		public static ImmunizationRules getImmunizationRule(String vaccine)
		{
			return DayCareController.immunizationRules.GetValueOrDefault(vaccine);
		}

		public static String getStudentfilename()
		{
			return studentFileName;
		}

		public DayCare getDayCareObj()
		{
			return dayCareObj;
		}

		public void setDayCareObj(DayCare dayCareObj)
		{
			this.dayCareObj = dayCareObj;
		}

		/*public DayCareFactory getDayCarefactoryObj()
		{
			return dayCarefactoryObj;
		}

		public void setDayCarefactoryObj(Factory.DayCareFactory dayCarefactoryObj)
		{
			this.dayCarefactoryObj = dayCarefactoryObj;
		}

		public EnrollmentRulesFactory getEnrollmentFactoryObj()
		{
			return enrollmentFactoryObj;
		}

		public void setEnrollmentFactoryObj(Factory.EnrollmentRulesFactory enrollmentFactoryObj)
		{
			this.enrollmentFactoryObj = enrollmentFactoryObj;
		}

		public StudentFactory getStudentFactoryObj()
		{
			return studentFactoryObj;
		}

		public void setStudentFactoryObj(StudentFactory studentFactoryObj)
		{
			this.studentFactoryObj = studentFactoryObj;
		}
*/
		public TeacherFactory getTeacherFactoryObj()
		{
			return teacherFactoryObj;
		}

		public void setTeacherFactoryObj(TeacherFactory teacherFactoryObj)
		{
			this.teacherFactoryObj = teacherFactoryObj;
		}



	}
}