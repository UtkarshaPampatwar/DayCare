using System;
using System.Collections.Generic;
using System.Text;
using DayCareManagement.Models;

namespace DayCareManagement.Factory
{
    public class ImmunizationFactory
    {

		private static ImmunizationFactory immunizationFactoryInstance;

		private ImmunizationFactory()
		{
			ImmunizationFactory.immunizationFactoryInstance = null;
		}

		public static ImmunizationFactory getInstance()
		{

			if (ImmunizationFactory.immunizationFactoryInstance == null)
			{
				immunizationFactoryInstance = new ImmunizationFactory();
			}

			return immunizationFactoryInstance;

		}

	public Immunization getObject()
		{
			return (new ImmunizationRecord());
		}

	public Immunization getObject(String csvData)
		{

			String[] ObjData = csvData.Split(",");
			int dosesGiven = int.Parse(ObjData[0]);
			return new ImmunizationRecord(ObjData[1], dosesGiven);
		}
	}
}
