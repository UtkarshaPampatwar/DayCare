using System;

namespace DayCareManagement.Models
{
	public interface Immunization
	{
		public void setImmunizationName(String name);
		public String getImmunizationName();
		public void setNumberOfDosesGiven(int doses);
		public void checkImmunizationStatus(DateTime bDate);
		public DateTime getNextDueDate();
		public void updateNumberofDosesPending();
		public int getNumberOfDosesPending();
		public void setNumberOfDosesPending(int numberOfDosesPending);
		public int getNumberOfDosesGiven();
		public Boolean checkImmuinityStatus();
		public Boolean checkOverdueStatus();

	}
}