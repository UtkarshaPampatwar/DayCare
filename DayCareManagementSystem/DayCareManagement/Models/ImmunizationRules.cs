using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models

{
	public class ImmunizationRules
	{
		/// <summary>
		/// numberofDoses determnine if the students is yet to have another vacaccine shot
		/// </summary>
		public int maxNumberOfDoses;

		/// <summary>
		/// List of dosage with intervals for each student
		/// </summary>
		public List<int> dosageIntervals;

		public ImmunizationRules()
		{

		}
		public ImmunizationRules(int maxNumberOfDoses)
		{
			this.maxNumberOfDoses = maxNumberOfDoses;
		}
		public DateTime getNextDueDate(DateTime bDate, int numberOfDosesPending)
		{
			if (numberOfDosesPending > 0)
			{ 
				bDate = bDate.AddMonths(this.dosageIntervals[(this.maxNumberOfDoses - numberOfDosesPending)]);
			}
			return bDate;
		}

		public ImmunizationRules(int maxNumberOfDoses, List<int> dosageIntervals)
		{

			this.dosageIntervals = new List<int>();
			this.maxNumberOfDoses = maxNumberOfDoses;
			foreach (int integer in dosageIntervals)
			{
				this.dosageIntervals.Add(integer);
			}
		}

		public int getMaxNumberOfDoses()
		{
			return maxNumberOfDoses;
		}
		public void setMaxNumberOfDoses(int maxNumberOfDoses)
		{
			this.maxNumberOfDoses = maxNumberOfDoses;

		}
	}
}
