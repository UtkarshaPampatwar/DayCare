using DayCareManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Factory
{
	public class TeacherFactory
	{
		private static TeacherFactory instance = null;
		private static int teacherCount = 0;

		public TeacherFactory()
		{

		}

		public static TeacherFactory getTeacherFactoryObj()
		{
			if (instance == null)
			{
				instance = new TeacherFactory();
				return instance;
			}
			else
			{
				return instance;
			}
		}

		//INIT
		/*public virtual List<Teacher> getTeacherObj(List<String> teacherData)
		{
			List<Teacher> teacherList = new List<Teacher>();
			//Iterator<String> it = teacherData.iterator();
			foreach(String val in teacherData)
			{
				String[] eachLine = null;
				teacherCount += 1;
				eachLine = val.Split(",");
				String teacherID = eachLine[0];
				String firstName = eachLine[1];
				String lastName = eachLine[2];
				String isAvailable = eachLine[3];
				String address = eachLine[4];
				String phoneNumber = eachLine[5];
				String credit = eachLine[6];
				teacherList.Add(new Teacher(firstName, lastName, int.Parse(teacherID), Boolean.Parse(isAvailable), address, phoneNumber, int.Parse(credit)));
				
			}
			return teacherList;



		}*/

		public virtual List<Teacher> getTeacherObj(List<string> teacherData)
		{
			List<Teacher> teacherList = new List<Teacher>();
			IEnumerator<string> it = teacherData.GetEnumerator();
			string[] eachLine = null;
			while (it.MoveNext())
			{
				teacherCount += 1;
				eachLine = it.Current.Split(",");
				int teacherID = Convert.ToInt32(eachLine[0]);
				String firstName = eachLine[1];
				String lastName = eachLine[2];
				String isAvailable = eachLine[3];
				String address = eachLine[4];
				String phoneNumber = eachLine[5];
				//String credit = eachLine[6];
				teacherList.Add(new Teacher(firstName, lastName, teacherID, Boolean.Parse(isAvailable), address, phoneNumber));
			}
			return teacherList;
		}


		//SINGLE
		public Teacher getSingleTeacherObj(String teacherData)
		{
			teacherCount += 1;
			String[] eachLine = teacherData.Split(",");
			String firstName = eachLine[0];
			String lastName = eachLine[1];
			String isAvailable = eachLine[3];
			String address = eachLine[2];
			String phoneNumber = eachLine[4];
			//Dan  Peters  10  false  Yes  9876543210
			Console.WriteLine($"{firstName} +  {lastName} + {teacherCount} + {isAvailable} + {address} + {phoneNumber}");
			return new Teacher(firstName, lastName, teacherCount, Boolean.Parse(isAvailable), address, phoneNumber);
		}
	}
}
