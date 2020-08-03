using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayCareManagement.Factory;
using System.Globalization;
using DayCareManagement.Models;

namespace DayCareManagement.Models
{
	public class DayCare
	{
		private List<Classroom> ClassroomList = new List<Classroom>();
		private List<Teacher> TeacherList = new List<Teacher>();
		private List<EnrollmentRules> EnrollmentruleList = null;
		private static DateTime DateFormat = new DateTime(07 / 31 / 2020);
		private ImmunizationFactory ImmunizationFactoryInstance;
		
		public DayCare()
		{
			this.ImmunizationFactoryInstance = ImmunizationFactory.getInstance();
		}

		public ImmunizationFactory getImmunizationFactoryInstance()
		{
			return ImmunizationFactoryInstance;
		}

		public void setImmunizationFactoryInstance(ImmunizationFactory immunizationFactoryInstance)
		{
			this.ImmunizationFactoryInstance = immunizationFactoryInstance;
		}
		private Dictionary<int, Student> studentMap = new Dictionary<int, Student>();


		public Dictionary<int, Student> getstudentMap()
		{
			return this.studentMap;
		}



		public List<EnrollmentRules> getEnrollmentruleList()
		{
			return this.EnrollmentruleList;
		}

		public void setEnrollmentruleList(List<EnrollmentRules> enrollmentruleList)
		{
			this.EnrollmentruleList = enrollmentruleList;
		}

		public void addClassroom(Classroom classroom)
		{
			this.ClassroomList.Add(classroom);
		}

		public void removeClassroom(Classroom classroom)
		{

		}

		public List<Teacher> getTeacherList()
		{
			return this.TeacherList;
		}

		public void setTeacherList(List<Teacher> TeacherList)
		{
			this.TeacherList = TeacherList;
		}

		public void addClassroomID(int classroomID)
		{

		}

		public void removeClassroomID(Classroom classroomID)
		{

		}

		public void showDayCareDetails()
		{
			this.ToString();
		}

		public List<Classroom> getClassroomList()
		{
			return ClassroomList;
		}

		public void setClassroomList(List<Classroom> ClassroomList)
		{
			this.ClassroomList = ClassroomList;
		}

		public void showTeacherListDetails()
		{
			foreach (var teacher in TeacherList)     // inferred Type Teacher
			{
				Console.WriteLine(teacher.ToString());
			}
			/*foreach (Teacher teacher in TeacherList)
			{
				
				if (teacher.getisAvailable())
				{
					Console.WriteLine("teacher is available to be assigned to a group");
				}
			}*/
		}


		public EnrollmentRules getApplicableEnrollmentRule(int age)
		{
			
			foreach (EnrollmentRules enrollmentRules in this.getEnrollmentruleList())
			{
				if ((enrollmentRules.MinAge <= age && age <= enrollmentRules.MaxAge))
				{
					Console.WriteLine("Rule found");
					return enrollmentRules;
				}
			}
			Console.WriteLine("Invalid Age input for Student");
			throw new Exception("Invalid age");
				/*throw new InvalidValue("Invalid Age input for Student");*/

			}
	
	
	public void enrollStudent(List<Student> studentList) 
{
			foreach (Student student in studentList) {
				int studentAge = student.Age;
				EnrollmentRules rule = this.getApplicableEnrollmentRule(studentAge);
				Console.WriteLine("Applicable rule is " + rule.AgeRange);
				this.setClassIDGroupID(student, rule);
				Console.WriteLine("Student Enrollemnt Complete");
				student.showStudentDetails();
				studentMap.Add(student.StudentId, student);
				Console.WriteLine("Student Enrollemnt Complete\n");
	}

}

public static DateTime GetStuDOB(String studentData)
{
	String[] eachLine = studentData.Split(",");
	DateTime dOB;
	try
	{
		dOB = DateTime.Parse(eachLine[2]);
		Console.WriteLine("dOB is " + dOB);
	}
	catch (FormatException e)
	{
		Console.WriteLine("Date not parsed", e);
		return new DateTime();
	}

	return dOB;

}

public static int getStuAge(String studentData, DateTime currentTime)
{
	/*int ageInMonths = 0;
	DateTime c;
	c.setTime(getStuDOB(studentData));
	int year = c.get(DateTIme.YEAR);
	int month = c.get(Calendar.MONTH) + 1;
	int date = c.get(Calendar.DATE);
	DateTime l1 = LocalDate.of(year, month, date);
	System.out.println("l1 is " + l1);
	//LocalDate currentTime = LocalDate.now();
	System.out.println("now1 is " + currentTime);
	Period age = Period.between(l1, currentTime);
	if (age.getYears() != 0)
	{
		ageInMonths = ageInMonths + (age.getYears() * 12);
	}
	if (age.getMonths() != 0)
	{
		ageInMonths = ageInMonths + age.getMonths();
	}
	System.out.println("period age is " + age);*/
	return 0;
}

 bool enrollStudent(StudentFactory stuFactObj, String studentData)
{
	bool addStudentStatus = true;
	Console.WriteLine("Received student data for processing");
	Console.WriteLine("studentData "+studentData);
	DateTime currentDate = DateTime.Now;
	int age = getStuAge(studentData, currentDate);
	Console.WriteLine("age:"+age+" months");
	studentData = studentData+","+(new DateTime())+","+age;
			Console.WriteLine("final studentData before parsing   "+studentData);
Student student = stuFactObj.getStudentObj(studentData); ;
int studentAge = student.Age;
EnrollmentRules rule = this.getApplicableEnrollmentRule(studentAge);
			Console.WriteLine("Applicable rule is "+rule.AgeRange);
			this.setClassIDGroupID(student, rule);
			Console.WriteLine("Student Enrollemnt Complete");
student.showStudentDetails();
			Console.WriteLine("Student Enrollemnt Complete\n");
String data = student.StudentId+","+student.FirstName+","+student.LastName+","+student.Age+","+
						student.Address+","+student.FatherName+","+student.MotherName+","+student.PhoneNumber+","+
						(student.DateOfJoining)+","+(student.DateOfBirth);
			Console.WriteLine("data to be written is "+data);
System.IO.File.AppendAllText("student.csv", data);
studentMap.Add(student.StudentId, student);
			return addStudentStatus;
}

public bool enrollTeacher(TeacherFactory teaFactObj, String teacherData)
{
	bool addTeacherStatus = true;
	Console.WriteLine("Received teacher data for processing");
	Console.WriteLine("teacherData "+teacherData);
	Teacher teacher = teaFactObj.getSingleTeacherObj(teacherData);
	Console.WriteLine("Teacher Enrollemnt Complete");
	teacher.show();
	//9,TeanineName, TeasecondName,true, #1 Hunt, 100, 8888888888
	String data = teacher.TeacherId+","+teacher.FirstName+","+teacher.LastName+","+teacher.IsAvailable+","+teacher.Address+","+teacher.PhoneNumber;
	Console.WriteLine("data to be written is "+data);
	System.IO.File.AppendAllText("teacher.csv", data);
			return (addTeacherStatus);
}
public Student findStudentById(int studentId)
{
	Console.WriteLine("ID to be searched: " + studentId);
	Student studentObj = null;
	bool studentFound = false;
	foreach (Classroom classroom in this.getClassroomList())
	{
		Console.WriteLine("\nClassID:" + classroom.classroomID + "\tAge group:" + classroom.enrollmentRule.MinAge + "-" + classroom.enrollmentRule.MaxAge + "months");
		foreach (Group group in classroom.groupList)
		{
					Console.WriteLine("\n\tGroupID:" + group.GroupID + "   Teacher Assigned:" + group.teacher.FirstName + "\n");
			foreach (Student student in group.StudentList)
			{
				if (studentId == student.StudentId)
				{
					Console.WriteLine(student.StudentId);
					studentObj = student;
					studentFound = true;
					break;
				}
			}
			if (studentFound == true)
				break;
		}
		if (studentFound == true)
			break;
	}
	return studentObj;
}
//2,2,1,3,1,0
//Hib,DTAP,Polio,HepB,MMR,Varicella
private List<Immunization> getImmunizationObject(String csvData, ImmunizationFactory immunizationFactoryInstance) 
{
	List<Immunization> immunizationRec = new List<Immunization>();
		String[] str = csvData.Split(",");

		immunizationRec.Add(immunizationFactoryInstance.getObject(str[1]+","+"Hib"));
		immunizationRec.Add(immunizationFactoryInstance.getObject(str[2]+","+"DTap"));
		immunizationRec.Add(immunizationFactoryInstance.getObject(str[3]+","+"Polio"));
		immunizationRec.Add(immunizationFactoryInstance.getObject(str[4]+","+"Hepatitis B"));
		immunizationRec.Add(immunizationFactoryInstance.getObject(str[5]+","+"MMR"));
		immunizationRec.Add(immunizationFactoryInstance.getObject(str[6]+","+"Varicella"));
		
		return immunizationRec;
	}

	public void mapStudentIDToImmunizationData(List<String> csvImmunizationData, List<Student> studentList, ImmunizationFactory immunizationFactoryInstance) 
{
		foreach(String csvData in csvImmunizationData)
		{
		String[] studentID = csvData.Split(",");
		List<Immunization> list = getImmunizationObject(csvData, immunizationFactoryInstance);

		foreach (Student student in studentList)
		{
			if (student.StudentId == int.Parse(studentID[0]))
			{
				student.ImmunizationRecord = list;
			}
		}
	}
	//		System.out.println("MAPPING DONE\n");
}

public void mapStudentIDToImmunizationDataFromUI(String immunizationRecord) 
{
	Student studentObj = null;
	List<Immunization> immunizationRec = getImmunizationObject(immunizationRecord, this.ImmunizationFactoryInstance);
	studentObj = findStudentById(StudentFactory.StudentCount);
	studentObj.ImmunizationRecord = immunizationRec;
	System.IO.File.AppendAllText("Student_Immunization_Record.csv", immunizationRecord);
}

public Classroom setClassIDGroupID(Student student, EnrollmentRules rule)
{
	bool classroomFound = false;
	bool groupFound = false;
	bool teacherFound = false;
	Classroom vacantClassroom = null;
		if (this.ClassroomList.Count==0) {
		Classroom classObj = new Classroom(this.ClassroomList.Count, rule);
		classroomFound = true;
		this.addClassroom(classObj);
		Console.WriteLine("No classrooms available, new class created");
		Group groupObj = new Group(classObj.getNumOfGroups(), classObj.enrollmentRule);
		groupObj.ClassID = classObj.classroomID;
		Console.WriteLine("No groups available, new group created");
		classObj.addGroupObj(groupObj);
		//add teacher
		foreach (Teacher teacher in TeacherList)
		{
			if (teacher.IsAvailable)
			{
				teacher.IsAvailable = false;
				teacher.ClassID = classObj.classroomID;
				teacher.GroupID = groupObj.GroupID;
				groupObj.teacher =teacher;
				teacherFound = true;
				break;
			}
		}

		if (groupObj.getGroupSize() + 1 <= groupObj.EnrollmentRule.GroupSize)
		{
			groupFound = true;
			groupObj.AddStudent(student);
			student.GroupID = groupObj.GroupID;
			Console.WriteLine("groupID set");
			student.ClassID=classObj.classroomID;
			Console.WriteLine("classID set");
			return classObj;
		}
	}
		else {
		foreach (Classroom classroom in this.ClassroomList)
		{
			if (classroom.enrollmentRule.Equals(rule))
			{
				Console.WriteLine("classroom.getNumOfGroups()  " + classroom.getNumOfGroups() + "  classroom.getEnrollmentRule().getMaxGroup()  " + classroom.enrollmentRule.MaxGroup);
				if (classroom.getNumOfGroups() <= classroom.enrollmentRule.MaxGroup)
				{
					if (classroom.getNumOfGroups() == classroom.enrollmentRule.MaxGroup)
					{
						Console.WriteLine("Classroom is full");
						foreach (Group group in classroom.groupList)
						{
							Console.WriteLine("group.getGroupSize()+1" + (group.getGroupSize() + 1) + " group.getEnrollmentRule().getGroupSize() " + group.EnrollmentRule.GroupSize);
							if (group.getGroupSize() + 1 <= group.EnrollmentRule.GroupSize)
							{
								Console.WriteLine("Group with vacancy found");
								groupFound = true;
								classroomFound = true;
								group.AddStudent(student);
								student.GroupID = group.GroupID;
								Console.WriteLine("groupID set");
								student.ClassID= classroom.classroomID;
								Console.WriteLine("classID set");
								return classroom;
							}
						}
					}
					else
					{
						classroomFound = true;
						vacantClassroom = classroom;
						foreach (Group group1 in classroom.groupList)
						{
							Console.WriteLine("group.getGroupSize()+1" + (group1.getGroupSize() + 1) + " group.getEnrollmentRule().getGroupSize() " + group1.EnrollmentRule.GroupSize);
							if (group1.getGroupSize() + 1 <= group1.EnrollmentRule.MaxGroup)
							{
								Console.WriteLine("Group with vacancy found");
								groupFound = true;
								group1.AddStudent(student);
								student.GroupID= group1.GroupID;
								Console.WriteLine("groupID set");
								student.ClassID = classroom.classroomID;
								Console.WriteLine("classID set");
								return classroom;
							}
							else
							{
								Console.WriteLine("Group is full");
							}
						}
					}
				}
				else
				{
					Console.WriteLine("Classroom is full");
				}
			}
			else
			{
						Console.WriteLine("Class rule mismatch");
			}
			if (classroomFound == true && vacantClassroom != null)
			{
						Console.WriteLine("Vacant classroom available, group is full, creating new group");
						Console.WriteLine("inputs for creating new group are " + vacantClassroom.getNumOfGroups() + "  " + vacantClassroom.enrollmentRule);
				Group newGroup = new Group(vacantClassroom.getNumOfGroups(), vacantClassroom.enrollmentRule);
				newGroup.ClassID = vacantClassroom.classroomID;
				vacantClassroom.addGroupObj(newGroup);
				//add teacher
				foreach (Teacher teacher in TeacherList)
				{
					if (teacher.IsAvailable)
					{
						teacher.IsAvailable = false;
						teacher.ClassID = newGroup.ClassID;
						teacher.GroupID = newGroup.GroupID;
						newGroup.teacher = teacher;
						teacherFound = true;
						break;
					}
				}
				Console.WriteLine("check ***  " + newGroup.GroupID + "  " + (newGroup.getGroupSize() + 1) + "   " + newGroup.EnrollmentRule.GroupSize);
				if (newGroup.getGroupSize() + 1 <= newGroup.EnrollmentRule.GroupSize)
				{
					groupFound = true;
					newGroup.AddStudent(student);
					student.GroupID = newGroup.GroupID;
					Console.WriteLine("groupID set");
					student.ClassID = vacantClassroom.classroomID;
					Console.WriteLine("classID set");
					return vacantClassroom;
				}
			}
		}
	}
	Console.WriteLine("classroomFound is "+classroomFound +"  groupFound  "+groupFound);
		if (classroomFound == false && groupFound == false) {
				Console.WriteLine("Class and group not found");
				Console.WriteLine("Creating new class and group");
		Classroom classObj = new Classroom(this.ClassroomList.Count, rule);
		classroomFound = true;
		this.addClassroom(classObj);
		Group groupObj = new Group(classObj.getNumOfGroups(), classObj.enrollmentRule);
		groupObj.ClassID = classObj.classroomID;
		classObj.addGroupObj(groupObj);
		//add teacher
		foreach (Teacher teacher in TeacherList)
		{
			if (teacher.IsAvailable)
			{
				teacher.IsAvailable= false;
				teacher.ClassID = groupObj.ClassID;
				teacher.GroupID = groupObj.GroupID;
				groupObj.teacher = teacher;
				teacherFound = true;
				break;
			}
		}
		if (groupObj.getGroupSize() + 1 <= groupObj.EnrollmentRule.GroupSize)
		{
			groupFound = true;
			groupObj.AddStudent(student);
			student.GroupID = groupObj.GroupID;
			Console.WriteLine("groupID set");
			student.ClassID = classObj.classroomID;
			Console.WriteLine("classID set");
			return classObj;
		}

	}
		throw new Exception("Invalid input while assigning Class ID");
		}
	}
}

