using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;

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

		public static Dictionary<String, Models.ImmunizationRules> immunizationRules = new Dictionary<String, Models.ImmunizationRules>();
		public static String getEnrollmentrulesfilename()
		{
			return enrollmentRulesFileName;
		}
		

		public static Models.ImmunizationRules getImmunizationRule(String vaccine)
		{
			return DayCareController.immunizationRules.GetValueOrDefault(vaccine);
		}

		
	}
}