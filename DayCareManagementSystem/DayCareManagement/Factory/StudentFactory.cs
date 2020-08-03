using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using DayCareManagement.Models;

namespace DayCareManagement.Factory
{
	public class StudentFactory
	{
		public  static StudentFactory instance = null;
		public static int StudentCount { get; set; } = 0;
		CultureInfo provider = CultureInfo.InvariantCulture;
		public void setStudentCount(int studentCount)
		{
			StudentFactory.StudentCount = studentCount;
		}
		public static StudentFactory getObj()
		{
			if (instance == null)
			{
				instance = new StudentFactory();
			}
			return instance;
		}
		string dateString = "06/15/2008";
		string format = "d";
		public StudentFactory()
		{
		}
		public Student getStudentObj(String data)
		{
			StudentCount += 1;
			Console.WriteLine("Student ID in SINGLE is " + StudentCount);
			String[] eachLine = null;
			eachLine = data.Split(",");
			String firstName = eachLine[0];
			String lastName = eachLine[1];
			String dateOfBirth = eachLine[2];
			String address = eachLine[3];
			String fatherName = eachLine[5];
			String motherName = eachLine[4];
			String phoneNumber = eachLine[6];
			String dateOfJoining = eachLine[7];
			int age = Convert.ToInt32(eachLine[8]);
			Student studentObj = new Student(firstName, lastName, age, address, fatherName, motherName, phoneNumber, DateTime.Parse(dateOfJoining), StudentCount, DateTime.Parse(dateOfBirth));
			return studentObj;
		}

		//INIT
		public List<Student> initStudentObj(List<String> data, bool updateAge)
		{
			String[] eachLine = null;
			List<Student> studentList = new List<Student>();
			IEnumerator<String> it = data.GetEnumerator();
			while (it.MoveNext())
			{
				StudentCount += 1;
				Console.WriteLine("Student ID in initStudentObj is " + StudentCount);
				eachLine = it.Current.Split(",");
				//System.out.println("eachLine[0] is"+eachLine[0]);
				if (eachLine[0] == "\n")
				{
					Console.WriteLine("Empty line encountered");
					continue;
				}
				int studentID = Convert.ToInt32(eachLine[0]);
				String firstName = eachLine[1];
				String lastName = eachLine[2];
				int age = Convert.ToInt32(eachLine[3]);
				String address = eachLine[4];
				String fatherName = eachLine[5];
				String motherName = eachLine[6];
				String phoneNumber = eachLine[7];
				String dateOfJoining = eachLine[8];
				String dateOfBirth = eachLine[9];
				if (updateAge)
				{
					Console.WriteLine("Updating age");
					DateTime currentDOB = DateTime.Parse(dateOfBirth);
					//LocalDateTime newDOB = currentDOB.plusMonths(6);
					//dateOfBirth = dateFormat.format(Date.from(currentDOB.atZone(ZoneId.systemDefault()).toInstant()));
					//String dob = dateFormat.format(DateofBirth.getDate());
					String studentData = firstName + "," + lastName + "," + dateOfBirth;
					Console.WriteLine("Age was " + age);
					DateTime currentDate = DateTime.Now.AddMonths(6);
					age = DayCare.getStuAge(studentData, currentDate);
					Console.WriteLine("New Age is " + age);
				}
				studentList.Add(new Student(firstName, lastName, age, address, fatherName, motherName, phoneNumber, DateTime.ParseExact(dateOfJoining, "MM/dd/yyyy", null), studentID, DateTime.ParseExact(dateOfBirth, "MM/dd/yyyy", null)));
			}
			return studentList;
		}
		
		//SINGLE
		
	}
} 
