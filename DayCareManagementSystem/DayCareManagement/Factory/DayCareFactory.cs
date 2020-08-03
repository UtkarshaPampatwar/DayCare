using DayCareManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DayCareManagement.Factory
{
	public class DayCareFactory
	{
		private static DayCareFactory instance = null;
		private EnrollmentRulesFactory enr = null;
		private StudentFactory sfr = null;
		Models.DayCare dayCare = null;
		private DayCareFactory()
		{
		}

		public static DayCareFactory getObj()
		{
			if (instance == null)
			{
				instance = new DayCareFactory();
			}
			return instance;
		}

		public Models.DayCare getDayCareObj()
		{
			
			if (dayCare == null)
			{
				dayCare = new Models.DayCare();
			}
			
			return dayCare;
		}

		public EnrollmentRulesFactory getEnrollmentRuleObj()
		{
			if (enr == null)
			{
				enr = new EnrollmentRulesFactory();
			}
			return enr;
		}

		public StudentFactory getStudentObj()
		{
			if (sfr == null)
			{
				sfr = new StudentFactory();
			}
			return sfr;
		}

	}
}
