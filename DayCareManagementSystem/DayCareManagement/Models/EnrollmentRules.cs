using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
	public class EnrollmentRules
	{
		private int MinAge { get; set; }
		private int MaxAge { get; set; }
		private String AgeRange { get; set; }
		private int GroupSize { get; set; }
		private String Ratio { get; set; }
		private int MaxGroup { get; set; }

		public EnrollmentRules(int minAge, int maxAge, String ageRange, int groupSize, String ratio, int maxGroup)
		{
			this.MinAge = minAge;
			this.MaxAge = maxAge;
			this.AgeRange = ageRange;
			this.GroupSize = groupSize;
			this.Ratio = ratio;
			this.MaxGroup = maxGroup;
		}

		public override string ToString()
		{
			return $"MinAge {MinAge}";
		}
		public void showRuleDetails()
		{
			this.ToString();
		}
	}
}