using DayCareManagement.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
	public class ImmunizationRecord:Immunization
	{
		private String immunizationName;
		private int numberOfDosesGiven;
		private int numberOfDosesPending;
		private DateTime nextDueDate;
		private Boolean isOverdue;
		private Boolean isImmune;

		public bool checkImmuinityStatus()
		{
			return this.isImmune;
		}

		public void checkImmunizationStatus(DateTime bDate)
		{
			if (this.numberOfDosesPending > 0)
			{
				this.nextDueDate = DayCareController.getImmunizationRule(immunizationName).getNextDueDate(bDate, this.numberOfDosesPending);
				this.isOverdue = nextDueDate < DateTime.Now ? true : false;
			}
			else if (this.numberOfDosesPending == 0)
				this.isImmune = true;
		}

		public bool checkOverdueStatus()
		{
			return this.isOverdue;
		}

		public string getImmunizationName()
		{
			return this.immunizationName;
		}

		public DateTime getNextDueDate()
		{
			return nextDueDate;
		}

		public int getNumberOfDosesGiven()
		{
			return this.numberOfDosesGiven;
		}

		public int getNumberOfDosesPending()
		{
			return numberOfDosesPending;
		}

		public void setImmunizationName(string immunizationName)
		{
			this.immunizationName = immunizationName;
		}

		public void setNumberOfDosesGiven(int numberOfDosesGiven)
		{
			this.numberOfDosesGiven = numberOfDosesGiven;
		}

		public void setNumberOfDosesPending(int numberOfDosesPending)
		{
			this.numberOfDosesPending = numberOfDosesPending;
		}

		public void updateNumberofDosesPending()
		{
			this.numberOfDosesPending = DayCareController.getImmunizationRule(this.immunizationName).getMaxNumberOfDoses() - this.numberOfDosesGiven;
		}
		public ImmunizationRecord(String immunizationName, int numberOfDosesGiven)
		{
			this.immunizationName = immunizationName;
			this.numberOfDosesGiven = numberOfDosesGiven;
			this.numberOfDosesPending = DayCareController.getImmunizationRule(this.immunizationName).getMaxNumberOfDoses() - this.numberOfDosesGiven;
			this.isOverdue = false;
			this.isImmune = false;
		}
	}

	
	
	
}
