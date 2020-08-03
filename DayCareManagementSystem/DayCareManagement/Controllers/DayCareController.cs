﻿using DayCareManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using DayCareManagement.Factory;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis;
using System.Globalization;
using Microsoft.VisualBasic.FileIO;

namespace DayCareManagement.Controllers
{
	public class DayCareController : Controller
	{
		public IHttpContextAccessor _httpContextAccessor;

		public static DayCareFactory factory = DayCareFactory.getObj();


		public DayCareController(IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
		}

		private static String studentFileName = "C:\\Users\\putka\\OneDrive\\Documents\\NEU\\Sem 5\\Object Oriented with C#\\Project - Ajay\\DayCare\\DayCareManagementSystem\\DayCareManagement\\student.csv";
		private static String teacherFileName = "C:\\Users\\putka\\OneDrive\\Documents\\NEU\\Sem 5\\Object Oriented with C#\\Project - Ajay\\DayCare\\DayCareManagementSystem\\DayCareManagement\\teacher.csv";
		private static String demoFileName = "demo.csv";
		private static String enrollmentRulesFileName = "C:\\Users\\putka\\OneDrive\\Documents\\NEU\\Sem 5\\Object Oriented with C#\\Project - Ajay\\DayCare\\DayCareManagementSystem\\DayCareManagement\\enrollmentRules.csv";
		private static String immunizationFileName = "C:\\Users\\putka\\OneDrive\\Documents\\NEU\\Sem 5\\Object Oriented with C#\\Project - Ajay\\DayCare\\DayCareManagementSystem\\DayCareManagement\\Student_Immunization_Record.csv";


		private Models.DayCare dayCareObj = null;

		public static Dictionary<String, ImmunizationRules> immunizationRules = new Dictionary<String, ImmunizationRules>();
		private static DateTime dateFormat = new DateTime(2020, 07, 31);

		private DayCareFactory dayCarefactoryObj = null;
		private EnrollmentRulesFactory enrollmentFactoryObj = null;
		private StudentFactory studentFactoryObj = null;
		private TeacherFactory teacherFactoryObj = null;
		private String username = "admin";
		private String password = "admin";
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Index(String username1, String password1)
		{
			Console.WriteLine(username == username1);
			Console.WriteLine(password == password1);
			return View("Login");
		}

		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult Login()
		{
			return View();
		}

		public DayCare getDayCareObj()
		{
			return dayCareObj;
		}



		public void setDayCareObj(DayCare dayCareObj)
		{
			this.dayCareObj = dayCareObj;
		}



		public DayCareFactory getDayCarefactoryObj()
		{
			return dayCarefactoryObj;
		}



		public void setDayCarefactoryObj(DayCareFactory dayCarefactoryObj)
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
		
		public IActionResult GetTeacherInfo()
		{

			return View();
		}

		public void FileTeacherWrite()
		{

		}

		[HttpPost]
		public IActionResult Rules()
		{
			List<Rules> rules = new List<Rules>();
			using (TextFieldParser parser = new TextFieldParser(enrollmentRulesFileName))
			{
				
				parser.SetDelimiters(new string[] { "," });
				parser.HasFieldsEnclosedInQuotes = true;

				// Skip over header line.
				parser.ReadLine();

				while (!parser.EndOfData)
				{
					string[] fields = parser.ReadFields();
					rules.Add(new Rules
					{
						AgeGroup = fields[0],
						GroupSize = int.Parse(fields[1]),
						Ratio = fields[2],
						MaxGroups = fields[3]
					});
				}
			}
			return View(rules);
		}
		public IActionResult AddStudent()
		{
			return View();
		}
		public IActionResult AddTeacher()
		{
			return View();
		}
		
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
		public TeacherFactory getTeacherFactoryObj()
		{
			return teacherFactoryObj;
		}

		public void setTeacherFactoryObj(TeacherFactory teacherFactoryObj)
		{
			this.teacherFactoryObj = teacherFactoryObj;
		}

	
		public IActionResult GetStudentInfo()
		{
			return View();
		}



		[HttpPost]
		public IActionResult RetrieveStudentInfo(String ID)
		{
			String studentInfo = "";

			int id = int.Parse(ID);
			Student s1 = null;
			if (factory.getDayCareObj().getstudentMap().ContainsKey(id))
			{
				s1 = (Student)factory.getDayCareObj().getstudentMap().GetValueOrDefault(id);
				//studentInfo = s1.StudentId + "," + s1.FirstName + "," + s1.LastName + "," + s1.Age + "," + s1.Address + "," + s1.FatherName + "," + s1.MotherName + "," + s1.PhoneNumber + "," + s1.DateOfJoining + "," + s1.DateOfBirth;
				Console.WriteLine("studentInfo to be returned is " + studentInfo);

			}
			return View("GetStudentInfo", s1);
		}


		[HttpPost]
		public IActionResult RetrieveTeacherStudentInfo(String ID)
		{
			int id = int.Parse(ID);
			Teacher t1 = null;
			List<Student> studentList = new List<Student>();
			foreach (Classroom classroom in factory.getDayCareObj().getClassroomList())
			{
				foreach (Group group in classroom.getGroupList())
				{

					if (group.getTeacher().TeacherId == id)
					{
						t1 = group.getTeacher();
						int g1 = group.getTeacher().GroupID;

						if (group.GroupID == g1)
						{
							foreach (Student student in group.getStudentList())
							{
								studentList.Add(student);
								
							}
						}
					}
				}
			}
			ViewBag.Teachers = t1;
			ViewBag.Students = studentList;
			return View("GetTeacherInfo");
		}

		public static String getStudentImmInfo(String ID)
		{
			String studentImmInfo = "";
			String overDueStatus = "0";
			int id = int.Parse(ID);
			if (factory.getDayCareObj().getstudentMap().ContainsKey(id))
			{
				Student s1 = (Student)factory.getDayCareObj().getstudentMap()[id];
				foreach (Immunization immdetails in s1.getImmunizationRecord())
				{
					if (immdetails.checkOverdueStatus() == true)
					{
						overDueStatus = "1";
					}
					if (immdetails.getNextDueDate() != null)
					{
						//studentImmInfo = studentImmInfo + (dateFormat.format(Date.from((immdetails.getNextDueDate()).atZone(ZoneId.systemDefault()).toInstant()))) + "," + overDueStatus + ",";
						studentImmInfo = studentImmInfo + immdetails.getNextDueDate() + "," + overDueStatus + ",";
					}
					else
					{
						studentImmInfo = studentImmInfo + immdetails.getNextDueDate() + "," + overDueStatus + ",";
					}
				}
			}

			return studentImmInfo;
		}

		public List<String> sendAllStudentImmunizationDetails()
		{
			List<String> detailsOfStudentImmunizationRecord = new List<String>();
			String ImmunizationData;
			foreach (Classroom classroom in factory.getDayCareObj().getClassroomList())
			{
				
				foreach (Group group in classroom.getGroupList())
				{
					foreach (Student student in group.getStudentList())
					{
						ImmunizationData = student.StudentId.ToString() + "," + student.FirstName + "," + student.LastName;
						Console.WriteLine("ImmunizationData  " + ImmunizationData);
						foreach (Immunization im in student.getImmunizationRecord())
						{
							if (im.getNextDueDate() != null)
							{
								ImmunizationData += "," + im.getNextDueDate().ToString();
							}
						}
						detailsOfStudentImmunizationRecord.Add(ImmunizationData);
						ImmunizationData = null;
					}
				}
			}
			return detailsOfStudentImmunizationRecord;
		}

		public void addSixMonths() 
		{
			StudentFactory studentFactoryObj = StudentFactory.getObj();
			List<String> demoDateList = System.IO.File.ReadLines(demoFileName).ToList();
			foreach (String string1 in demoDateList) 
			{
				DateTime demoDate = DateTime.Parse(string1);
			}
			foreach (Classroom classroom in factory.getDayCareObj().getClassroomList())
			{
				foreach (Group group in classroom.getGroupList()) 
				{
					group.getStudentList().Clear();
					group.setTeacher(null);
				}
					classroom.getGroupList().Clear();
			}
			factory.getDayCareObj().getClassroomList().Clear();

			studentFactoryObj.setStudentCount(0);
			List<String> student_data = System.IO.File.ReadLines(studentFileName).ToList();
			
			List<Student> studentList = studentFactoryObj.initStudentObj(student_data, true);

			factory.getDayCareObj().enrollStudent(studentList);
		
		}

		public List<String> getEnrollmentStatus()
		{
			
			List<String> studentdataList = new List<String>();
			foreach (Classroom classroom in factory.getDayCareObj().getClassroomList())
			{
				foreach (Group group in classroom.getGroupList())
				{
					foreach (Student student in group.getStudentList())
					{
						String studentData = "";
						int daysPending = 0;
						DateTime enrollmentDueDate = student.DateOfJoining.AddYears(1);

						DateTime enrollmeantdate = enrollmentDueDate;
						int year = enrollmeantdate.Year;
						int month = enrollmeantdate.Month + 1;
						int date = enrollmeantdate.Day;
						DateTime l2 = DateTime.Now;
						int diff_year = l2.Year - year;
						int diff_month = l2.Month - month;
						int diff_day = l2.Day - date;

						if (diff_year != 0)
						{
							daysPending = daysPending + (diff_year * 365);
						}
						if (diff_month != 0)
						{
							daysPending = daysPending + diff_month * 30;
						}
						daysPending += diff_day;


						studentData = student.StudentId + "," + student.FirstName + "," + student.LastName + "," + student.DateOfJoining + "," +
								enrollmentDueDate + "," + daysPending;
						
						studentdataList.Add(studentData);
					}
				}
			}
			

			return studentdataList;
		}
		public static void createDayCareImmunizationRules()
		{
			int[] hib = { 2, 4, 6, 15 };
			int[] DTap = { 2, 4, 6, 15 };
			int[] polio = { 0, 6, 12 };
			int[] hep = { 0,2,15};
			int[] mmr = { 0 };
			DayCareController.immunizationRules.Add("Hib", new ImmunizationRules(4, hib.ToList()));
			DayCareController.immunizationRules.Add("DTap", new ImmunizationRules(4, DTap.ToList()));
			DayCareController.immunizationRules.Add("Polio", new ImmunizationRules(3, polio.ToList()));
			DayCareController.immunizationRules.Add("Hepatitis B", new ImmunizationRules(3, hep.ToList()));
			DayCareController.immunizationRules.Add("MMR", new ImmunizationRules(1, mmr.ToList()));
			DayCareController.immunizationRules.Add("Varicella", new ImmunizationRules(1, mmr.ToList()));

		}
		public static void demo()
		{
			EnrollmentRulesFactory enrollFactoryObj = factory.getEnrollmentRuleObj();
			List<String> enrollmentRegulationList = new List<String>();
			//minAge, maxAge, num of Students, num of Teachers, groupSize 
			enrollmentRegulationList.Add("6,12,4,1,3");
			enrollmentRegulationList.Add("13,24,5,1,3");
			enrollmentRegulationList.Add("25,35,6,1,3");
			enrollmentRegulationList.Add("36,47,8,1,3");
			enrollmentRegulationList.Add("48,59,12,1,2");
			enrollmentRegulationList.Add("60,100,15,1,2");
			DayCare day = factory.getDayCareObj();
			day.setEnrollmentruleList(enrollFactoryObj.getRuleObj(enrollmentRegulationList));
			List<String> rulesList = new List<String>();
			String firstLine = "Age Group,\tgroupSize,\tratio,\tmaxGroups/Class";
			rulesList.Add(firstLine);
			foreach (EnrollmentRules EnrollmentRules in day.getEnrollmentruleList())
			{
				String rule = "" + EnrollmentRules.MinAge + "-" + EnrollmentRules.MaxAge + ",\t\t\t"
						+ EnrollmentRules.GroupSize + ", \t\t\t" + EnrollmentRules.Ratio + ", \t\t\t" + EnrollmentRules.MaxGroup;
				
				rulesList.Add(rule);
			}

			System.IO.File.WriteAllLines(enrollmentRulesFileName, rulesList);
			createDayCareImmunizationRules();

			//Teacher Factory object initialization
			TeacherFactory teacherFactoryObj = TeacherFactory.getTeacherFactoryObj();
			List<String> teacher_data = System.IO.File.ReadLines(teacherFileName).ToList();
			Console.WriteLine("Student File read successfully");
			day.setTeacherList(teacherFactoryObj.getTeacherObj(teacher_data));

			//Student Factory object inittialization
			StudentFactory studentFactoryObj = StudentFactory.getObj();
			List<String> student_data = System.IO.File.ReadLines(studentFileName).ToList();
			Console.WriteLine("Student File read successfully");
			List<Student> studentList = studentFactoryObj.initStudentObj(student_data, false);
			day.enrollStudent(studentList);

			List<String> immunization_data = System.IO.File.ReadLines(immunizationFileName).ToList();
			day.mapStudentIDToImmunizationData(immunization_data, studentList, day.getImmunizationFactoryInstance());

			foreach (Classroom classroom in day.getClassroomList())
			{
				//System.out.print("\nClassID:" + classroom.classroomID + "\tAge group:" + classroom.getEnrollmentRule().getMinAge() + "-" + classroom.getEnrollmentRule().getMaxAge() + "months");
				foreach (Group group in classroom.getGroupList())
				{
					//System.out.print("\n\tGroupID:" + group.getGroupID() + "   Teacher Assigned:" + group.getTeacher().getFirstName() + "\n");
					foreach (Student student in group.getStudentList())
					{
						if (student.getImmunizationRecord() != null)
							foreach (Immunization im in student.getImmunizationRecord())
							{
								im.checkImmunizationStatus(student.DateOfBirth);
							}
					}
				}
			}
		}
	}
}