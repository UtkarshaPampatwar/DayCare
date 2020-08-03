using System;
using System.Collections.Generic;
using System.Text;
using DayCareManagement.Models;

namespace DayCareManagement.Factory
{
	public class EnrollmentRulesFactory
	{
		//private static EnrollmentRulesFactory instance = null;
		public EnrollmentRulesFactory()
		{
		}

		/*public static EnrollmentRulesFactory getObj()
		{
			if (instance == null)
			{
				instance = new EnrollmentRulesFactory();
			}
			return instance;
		}*/

		public List<EnrollmentRules> getRuleObj(List<String> enrollmentRegulationList)
		{
			List<EnrollmentRules> EnrollmentRulesList = new List<Models.EnrollmentRules>();
			IEnumerator<String> it = enrollmentRegulationList.GetEnumerator();
			while (it.MoveNext())
			{
				String[] parameter = it.Current.Split(",");
				int minAge = Convert.ToInt32(parameter[0]);

				int maxAge = Convert.ToInt32(parameter[1]);
				int numOfStu = Convert.ToInt32(parameter[2]);
				int numOfTea = Convert.ToInt32(parameter[3]);
				int groupSize = Convert.ToInt32(parameter[4]);
				String ageRange = minAge.ToString() + "-" + maxAge.ToString();
				String ratio = numOfStu.ToString() + ":" + numOfTea.ToString();
				EnrollmentRulesList.Add(new EnrollmentRules(minAge, maxAge, ageRange, numOfStu, ratio, groupSize));
			}

			return EnrollmentRulesList;
		}
	}
}
